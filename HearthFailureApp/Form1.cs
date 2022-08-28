using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFailureApp
{
    public partial class HeartFailureForm : Form
    {
        string[] healthDetailOfPatients;

        public HeartFailureForm()
        {
            InitializeComponent();

            textBox_age.Text = "75";
            textBox_anaemia.Text = "0";
            textBox_cr_ph.Text = "582";
            textBox_diabetes.Text = "0";
            textBox_ej_fr.Text = "20";
            textBox_platelets.Text = "265000";
            textBox_se_cr.Text = "1.9";
            textBox_time.Text = "4";
        }

        private void btn_send_patient_data_Click(object sender, EventArgs e)
        {
            healthDetailOfPatients = new string[] {
                textBox_age.Text,
                textBox_anaemia.Text,
                textBox_cr_ph.Text,
                textBox_diabetes.Text,
                textBox_ej_fr.Text,
                textBox_platelets.Text,
                textBox_se_cr.Text,
                textBox_time.Text
                };

            RequestResponse.SetGivenDetails(healthDetailOfPatients);
            RequestResponse.InvokeRequestResponseService().Wait();

            label_diagnosis_prediction.Text = RequestResponse.finalDiagnosis;

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void textBox_diabetes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
