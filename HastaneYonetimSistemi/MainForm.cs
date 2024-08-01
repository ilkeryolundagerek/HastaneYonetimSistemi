using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimSistemi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void menu_item_newPatient_Click(object sender, EventArgs e)
        {
            openForm(new Patients.NewPatient());
        }

        private void openForm(Form current_form)
        {
            bool isOpen = false;

            foreach (Form form in Application.OpenForms)
            {
                if (current_form.Name == form.Name)
                {
                    isOpen = true;
                    break;
                }
            }

            if (!isOpen)
            {
                current_form.MdiParent = this;
                current_form.Show();
            }
        }

        private void menu_item_listPatient_Click(object sender, EventArgs e)
        {
            openForm(new Patients.ListPatients());
        }

        private void menu_item_newDoctor_Click(object sender, EventArgs e)
        {
            openForm(new Doctors.NewDoctor());
        }
    }
}
