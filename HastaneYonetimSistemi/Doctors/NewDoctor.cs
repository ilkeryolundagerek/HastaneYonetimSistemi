using HastaneYonetimSistemi.Managers;
using HastaneYonetimSistemi.Models;
using HastaneYonetimSistemi.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace HastaneYonetimSistemi.Doctors
{
    public partial class NewDoctor : Form
    {
        public NewDoctor()
        {
            InitializeComponent();
        }

        private void btn_doctor_cancel_Click(object sender, EventArgs e)
        {
            //Aktif formu kapatır, ama form bu değilse uygulama sonlanmaz.
            this.Close();
        }

        private void btn_doctor_save_Click(object sender, EventArgs e)
        {
            bool validation_status = true;
            string message = "";

            if (string.IsNullOrEmpty(tb_doctor_name.Text))
            {
                message += "İsim alanı boş bırakılamaz.\n";
                validation_status = false;
            }

            if (string.IsNullOrEmpty(tb_doctor_surname.Text))
            {
                message += "Soyisim alanı boş bırakılamaz.\n";
                validation_status = false;
            }

            if (!mtb_doctor_tckn.Text.IsTCKN())
            {
                message += "Geçerli bir kimlik numarası girilmelidir.\n";
                validation_status = false;
            }

            if (!(rb_doctor_male.Checked || rb_doctor_female.Checked || rb_doctor_other.Checked))
            {
                message += "Lütfen cinsiyet belirtiniz.\n";
                validation_status = false;
            }

            if (dtp_doctor_dateOfBirth.Value > DateTime.Now)
            {
                message += "Bugünden daha geç bir tarih bilgisi giremezsiniz.\n";
                validation_status = false;
            }

            if (
                    !(
                        mtb_doctor_phone.MaskCompleted &&
                        (
                            mtb_doctor_phone.Text.StartsWith("50") ||
                            mtb_doctor_phone.Text.StartsWith("53") ||
                            mtb_doctor_phone.Text.StartsWith("54") ||
                            mtb_doctor_phone.Text.StartsWith("55")
                        )
                    )
                )
            {
                message += "Telefon numaranız standart formata aykırı.\n";
                validation_status = false;
            }

            if (cb_doctor_bloodType.SelectedIndex == 0)
            {
                message += "Kan grubu seçimi yapılmamış.\n";
                validation_status = false;
            }

            if (cb_doctor_departments.SelectedIndex == 0)
            {
                message += "Bölüm seçimi yapılmamış.\n";
                validation_status = false;
            }

            if (cb_doctor_specializations.SelectedIndex == 0)
            {
                message += "Uzmalık seçimi yapılmamış.\n";
                validation_status = false;
            }

            if (!tb_doctor_email.Text.IsEmail())
            {
                message += "Geçerli bir e-posta adresi girilmelidir.\n";
                validation_status = false;
            }

            if (validation_status)
            {
                NewDoctorModel model = new NewDoctorModel()
                {
                    Firstname = tb_doctor_name.Text,
                    Lastname = tb_doctor_surname.Text,
                    NationalId = long.Parse(mtb_doctor_tckn.Text),
                    BloodType = cb_doctor_bloodType.SelectedItem.ToString(),
                    Department = cb_doctor_departments.SelectedItem.ToString(),
                    Specialization = cb_doctor_specializations.SelectedItem.ToString(),
                    Email = tb_doctor_email.Text,
                    DateOfBirth = dtp_doctor_dateOfBirth.Value,
                    PhoneNumber = long.Parse(mtb_doctor_phone.Text)
                };

                if (rb_doctor_male.Checked)
                {
                    model.Gender = rb_doctor_male.Text;
                }
                else if (rb_doctor_female.Checked)
                {
                    model.Gender = rb_doctor_female.Text;
                }
                else if (rb_doctor_other.Checked)
                {
                    model.Gender = rb_doctor_other.Text;
                }

                //Kayıt Burada Olacak.
                DoctorManager manager = new DoctorManager();
                manager.Create(model);

                DialogResult result = MessageBox.Show("Doktor kaydı ekleme başarılı, yeni kayıt eklemek ister misiniz?", "Doktor Kaydı başarılı...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        private void NewDoctor_Load(object sender, EventArgs e)
        {
            cb_doctor_bloodType.SelectedIndex = 0;

            Dictionary<string, string[]> specs = GetSpecs();

            cb_doctor_departments.Items.Insert(0, "Seçiniz...");
            cb_doctor_departments.Items.AddRange(specs["departments"]);
            cb_doctor_departments.SelectedIndex = 0;

            cb_doctor_specializations.Items.Insert(0, "Seçiniz...");
            cb_doctor_specializations.Items.AddRange(specs["specializations"]);
            cb_doctor_specializations.SelectedIndex = 0;
        }

        private Dictionary<string, string[]> GetSpecs()
        {
            string specsData = File.ReadAllText("bolumler_uzmanliklar.json");
            return JsonSerializer.Deserialize<Dictionary<string, string[]>>(specsData);
        }
    }
}
