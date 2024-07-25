using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Linq;
using HastaneYonetimSistemi.Models;
using HastaneYonetimSistemi.Managers;

namespace HastaneYonetimSistemi.Patients
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void btn_patient_cancel_Click(object sender, EventArgs e)
        {
            //Aktif formu kapatır, ama form bu değilse uygulama sonlanmaz.
            this.Close();
        }

        private void btn_patient_save_Click(object sender, EventArgs e)
        {
            string message = "";
            bool validation_status = true;

            if (string.IsNullOrEmpty(tb_patient_name.Text))
            {
                message += "İsim alanı boş bırakılamaz.\n";
                validation_status = false;
            }

            if (string.IsNullOrEmpty(tb_patient_surname.Text))
            {
                message += "Soyisim alanı boş bırakılamaz.\n";
                validation_status = false;
            }

            if (!tcknCheck(mtb_patient_tckn.Text))
            {
                message += "Geçerli bir kimlik numarası girilmelidir.\n";
                validation_status = false;
            }

            if (!(rb_patient_male.Checked || rb_patient_female.Checked || rb_patient_other.Checked))
            {
                message += "Lütfen cinsiyet belirtiniz.\n";
                validation_status = false;
            }

            if (dtp_patient_dateOfBirth.Value > DateTime.Now)
            {
                message += "Bugünden daha geç bir tarih bilgisi giremezsiniz.\n";
                validation_status = false;
            }

            if (string.IsNullOrEmpty(tb_patient_address.Text))
            {
                message += "Adres alanı boş bırakılamaz.\n";
                validation_status = false;
            }

            if (
                    !(
                        mtb_patient_phone.MaskCompleted &&
                        (
                            mtb_patient_phone.Text.StartsWith("50") ||
                            mtb_patient_phone.Text.StartsWith("53") ||
                            mtb_patient_phone.Text.StartsWith("54") ||
                            mtb_patient_phone.Text.StartsWith("55")
                        )
                    )
                )
            {
                message += "Telefon numaranız standart formata aykırı.\n";
                validation_status = false;
            }

            if (cb_patient_bloodType.SelectedIndex == 0)
            {
                message += "Kan grubu seçimi yapılmamış.\n";
                validation_status = false;
            }

            if (cb_patient_city.SelectedIndex == 0)
            {
                message += "İl seçimi yapılmamış.\n";
                validation_status = false;
            }

            if (cb_patient_district.SelectedIndex == 0)
            {
                message += "İlçe seçimi yapılmamış.\n";
                validation_status = false;
            }

            if (validation_status)
            {
                NewPatientModel model = new NewPatientModel()
                {
                    Firstname = tb_patient_name.Text,
                    Lastname = tb_patient_surname.Text,
                    NationalId = long.Parse(mtb_patient_tckn.Text),
                    BloodType = cb_patient_bloodType.SelectedItem.ToString(),
                    City = cb_patient_city.SelectedItem.ToString(),
                    District = cb_patient_district.SelectedItem.ToString(),
                    Address = tb_patient_address.Text,
                    DateOfBirth = dtp_patient_dateOfBirth.Value,
                    PhoneNumber = long.Parse(mtb_patient_phone.Text)
                };

                if (rb_patient_male.Checked)
                {
                    model.Gender = rb_patient_male.Text;
                }
                else if (rb_patient_female.Checked)
                {
                    model.Gender = rb_patient_female.Text;
                }
                else if (rb_patient_other.Checked)
                {
                    model.Gender = rb_patient_other.Text;
                }

                //Kayıt Burada Olacak.
                PatientManager manager = new PatientManager();
                manager.Create(model);

                DialogResult result = MessageBox.Show("Hasta kaydı ekleme başarılı, yeni kayıt eklemek ister misiniz?", "Hasta Kaydı başarılı...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    foreach (Control control in this.Controls)
                    {
                        switch (control)
                        {
                            case TextBox tb: tb.Clear(); break;
                            case MaskedTextBox mtb: mtb.Clear(); break;
                            case DateTimePicker dtp: dtp.Value = DateTime.Now; break;
                            case RadioButton rb: rb.Checked = false; break;
                            case ComboBox cb: cb.SelectedIndex = 0; break;
                        }
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(message, "Kayıt başarısız...");
            }
        }

        private bool tcknCheck(string tckn)
        {
            bool isParsed = long.TryParse(tckn, out long tckn_long);
            if (isParsed && tckn_long.ToString().Length == 11)
            {
                long first9 = tckn_long / 100;
                long last2 = tckn_long % 100;
                long odds = 0, evens = 0;
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(first9);
                    long b = first9 % 10;
                    if (i % 2 == 0)
                    {
                        evens += b;
                    }
                    else
                    {
                        odds += b;
                    }
                    first9 /= 10;
                }
                long b10 = (odds * 7 - evens) % 10;
                long b11 = (odds + evens + b10) % 10;
                return last2 == b10 * 10 + b11;
            }
            return false;
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            cb_patient_bloodType.SelectedIndex = 0;


            cb_patient_city.Items.Insert(0, "Seçiniz...");
            //.Keys.ToArray(): İller sözlüğünün anahtar listesini alarak string dizisine çevirdik.
            cb_patient_city.Items.AddRange(GetCityDistrictMap().Keys.ToArray());
            cb_patient_city.SelectedIndex = 0;


            cb_patient_district.Items.Insert(0, "Seçiniz...");
            cb_patient_district.SelectedIndex = 0;

        }

        private Dictionary<string, string[]> GetCityDistrictMap()
        {
            Dictionary<string, string[]> result = new Dictionary<string, string[]>();
            //JavaScript Object Notation (json): Sistemler arası son geliştirilmiş veri iletim dosya formatıdır. Anahtar-Değer ikilisi btün dillerde olduğundan dolayı kullanılmaktadır.
            string fileName = "iller_ilceler.json";
            //File: C# için dosya yönetim sınıfıdır. System.IO kütüphanesinden gelir.
            string citiesData = File.ReadAllText(fileName);

            //Console.WriteLine(citiesData);
            //System.Text.Json kütüphanesi yardımıyla json metnini istenilen nesne formatına dönüştürdük.
            result = JsonSerializer.Deserialize<Dictionary<string, string[]>>(citiesData);

            return result;
        }

        private void cb_patient_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_patient_district.Items.Clear();
            cb_patient_district.Items.Insert(0, "Seçiniz...");
            cb_patient_district.SelectedIndex = 0;

            if (cb_patient_city.SelectedIndex > 0)
            {
                string[] districts = GetCityDistrictMap()[cb_patient_city.SelectedItem.ToString()];
                cb_patient_district.Items.AddRange(districts);
            }
        }
    }
}
