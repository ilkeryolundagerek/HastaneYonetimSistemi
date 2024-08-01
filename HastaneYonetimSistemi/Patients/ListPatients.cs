using HastaneYonetimSistemi.Managers;
using HastaneYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimSistemi.Patients
{
    public partial class ListPatients : Form
    {
        public ListPatients()
        {
            InitializeComponent();
        }

        private void ListPatients_Load(object sender, EventArgs e)
        {
            FillList();
        }


        private List<NewPatientModel> GetPatients()
        {
            List<NewPatientModel> result = new List<NewPatientModel>();

            //Veri tabanından aktif hasta kayıtları burada okunacak.

            PatientManager manager = new PatientManager();
            result = manager.ReadAll();


            //NewPatientModel data = new NewPatientModel()
            //{
            //    Id = 1,
            //    Firstname = "İlker",
            //    Lastname = "Turan",
            //    BloodType = "B Rh+",
            //    City = "İstanbul",
            //    District = "Kadıköy",
            //    Address = ".....",
            //    DateOfBirth = DateTime.Now,
            //    Gender = "Erkek",
            //    NationalId = 12345679812,
            //    PhoneNumber = 500000000
            //};
            //result.Add(data);
            return result;
        }

        private void FillList()
        {
            var patients = GetPatients();
            dgv_patientList.AutoGenerateColumns = false;
            dgv_patientList.DataSource = patients;
            status_lbl_patient_count.Text = patients.Count().ToString();
        }

        private void menu_edit_patient_Click(object sender, EventArgs e)
        {
            PatientManager manager = new PatientManager();
            int patient_id = (int)dgv_patientList.SelectedRows[0].Cells[0].Value;
            NewPatientModel patient = manager.ReadOne(patient_id);
            MessageBox.Show($"{patient.Firstname} {patient.Lastname}");
        }

        private void menu_delete_patient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kayıt silinecektir, emin misiniz?", "Hasta Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                PatientManager manager = new PatientManager();
                int patient_id = (int)dgv_patientList.SelectedRows[0].Cells[0].Value;
                manager.Delete(patient_id);
                MessageBox.Show("Hasta kaydı başarıyla silindi.");
                FillList();
            }
        }
    }
}
