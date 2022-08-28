namespace HeartFailureApp
{
    partial class HeartFailureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_age = new System.Windows.Forms.Label();
            this.label_anaemia = new System.Windows.Forms.Label();
            this.label_cr_ph = new System.Windows.Forms.Label();
            this.label_diabetes = new System.Windows.Forms.Label();
            this.label_platelets = new System.Windows.Forms.Label();
            this.label_serum_cr = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_anaemia = new System.Windows.Forms.TextBox();
            this.textBox_cr_ph = new System.Windows.Forms.TextBox();
            this.textBox_diabetes = new System.Windows.Forms.TextBox();
            this.textBox_platelets = new System.Windows.Forms.TextBox();
            this.textBox_se_cr = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label_diagnosis = new System.Windows.Forms.Label();
            this.btn_send_patient_data = new System.Windows.Forms.Button();
            this.label_ejection_fr = new System.Windows.Forms.Label();
            this.textBox_ej_fr = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_instructions = new System.Windows.Forms.Label();
            this.label_diagnosis_prediction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(148, 51);
            this.label_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(37, 17);
            this.label_age.TabIndex = 0;
            this.label_age.Text = "Age:";
            this.label_age.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_anaemia
            // 
            this.label_anaemia.AutoSize = true;
            this.label_anaemia.Location = new System.Drawing.Point(118, 91);
            this.label_anaemia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_anaemia.Name = "label_anaemia";
            this.label_anaemia.Size = new System.Drawing.Size(67, 17);
            this.label_anaemia.TabIndex = 1;
            this.label_anaemia.Text = "Anaemia:";
            // 
            // label_cr_ph
            // 
            this.label_cr_ph.AutoSize = true;
            this.label_cr_ph.Location = new System.Drawing.Point(9, 139);
            this.label_cr_ph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cr_ph.Name = "label_cr_ph";
            this.label_cr_ph.Size = new System.Drawing.Size(176, 17);
            this.label_cr_ph.TabIndex = 2;
            this.label_cr_ph.Text = "Creatinine phosphokinase:";
            // 
            // label_diabetes
            // 
            this.label_diabetes.AutoSize = true;
            this.label_diabetes.Location = new System.Drawing.Point(117, 189);
            this.label_diabetes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diabetes.Name = "label_diabetes";
            this.label_diabetes.Size = new System.Drawing.Size(68, 17);
            this.label_diabetes.TabIndex = 3;
            this.label_diabetes.Text = "Diabetes:";
            // 
            // label_platelets
            // 
            this.label_platelets.AutoSize = true;
            this.label_platelets.Location = new System.Drawing.Point(117, 276);
            this.label_platelets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_platelets.Name = "label_platelets";
            this.label_platelets.Size = new System.Drawing.Size(66, 17);
            this.label_platelets.TabIndex = 5;
            this.label_platelets.Text = "Platelets:";
            this.label_platelets.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_serum_cr
            // 
            this.label_serum_cr.AutoSize = true;
            this.label_serum_cr.Location = new System.Drawing.Point(64, 319);
            this.label_serum_cr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_serum_cr.Name = "label_serum_cr";
            this.label_serum_cr.Size = new System.Drawing.Size(119, 17);
            this.label_serum_cr.TabIndex = 6;
            this.label_serum_cr.Text = "Serum creatinine:";
            this.label_serum_cr.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(140, 360);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(43, 17);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "Time:";
            this.label_time.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(194, 48);
            this.textBox_age.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(132, 22);
            this.textBox_age.TabIndex = 10;
            this.textBox_age.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_anaemia
            // 
            this.textBox_anaemia.Location = new System.Drawing.Point(194, 91);
            this.textBox_anaemia.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_anaemia.Name = "textBox_anaemia";
            this.textBox_anaemia.Size = new System.Drawing.Size(132, 22);
            this.textBox_anaemia.TabIndex = 11;
            // 
            // textBox_cr_ph
            // 
            this.textBox_cr_ph.Location = new System.Drawing.Point(194, 136);
            this.textBox_cr_ph.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cr_ph.Name = "textBox_cr_ph";
            this.textBox_cr_ph.Size = new System.Drawing.Size(132, 22);
            this.textBox_cr_ph.TabIndex = 12;
            // 
            // textBox_diabetes
            // 
            this.textBox_diabetes.Location = new System.Drawing.Point(194, 184);
            this.textBox_diabetes.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_diabetes.Name = "textBox_diabetes";
            this.textBox_diabetes.Size = new System.Drawing.Size(132, 22);
            this.textBox_diabetes.TabIndex = 13;
            this.textBox_diabetes.TextChanged += new System.EventHandler(this.textBox_diabetes_TextChanged);
            // 
            // textBox_platelets
            // 
            this.textBox_platelets.Location = new System.Drawing.Point(194, 273);
            this.textBox_platelets.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_platelets.Name = "textBox_platelets";
            this.textBox_platelets.Size = new System.Drawing.Size(132, 22);
            this.textBox_platelets.TabIndex = 15;
            // 
            // textBox_se_cr
            // 
            this.textBox_se_cr.Location = new System.Drawing.Point(194, 314);
            this.textBox_se_cr.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_se_cr.Name = "textBox_se_cr";
            this.textBox_se_cr.Size = new System.Drawing.Size(132, 22);
            this.textBox_se_cr.TabIndex = 16;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(194, 355);
            this.textBox_time.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(132, 22);
            this.textBox_time.TabIndex = 17;
            // 
            // label_diagnosis
            // 
            this.label_diagnosis.AutoSize = true;
            this.label_diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_diagnosis.Location = new System.Drawing.Point(13, 448);
            this.label_diagnosis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diagnosis.Name = "label_diagnosis";
            this.label_diagnosis.Size = new System.Drawing.Size(136, 20);
            this.label_diagnosis.TabIndex = 20;
            this.label_diagnosis.Text = "Diagnosis result:";
            // 
            // btn_send_patient_data
            // 
            this.btn_send_patient_data.Location = new System.Drawing.Point(175, 398);
            this.btn_send_patient_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_patient_data.Name = "btn_send_patient_data";
            this.btn_send_patient_data.Size = new System.Drawing.Size(159, 38);
            this.btn_send_patient_data.TabIndex = 22;
            this.btn_send_patient_data.Text = "Send patient data";
            this.btn_send_patient_data.UseVisualStyleBackColor = true;
            this.btn_send_patient_data.Click += new System.EventHandler(this.btn_send_patient_data_Click);
            // 
            // label_ejection_fr
            // 
            this.label_ejection_fr.AutoSize = true;
            this.label_ejection_fr.Location = new System.Drawing.Point(72, 229);
            this.label_ejection_fr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ejection_fr.Name = "label_ejection_fr";
            this.label_ejection_fr.Size = new System.Drawing.Size(113, 17);
            this.label_ejection_fr.TabIndex = 4;
            this.label_ejection_fr.Text = "Ejection fraction:";
            // 
            // textBox_ej_fr
            // 
            this.textBox_ej_fr.Location = new System.Drawing.Point(194, 226);
            this.textBox_ej_fr.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ej_fr.Name = "textBox_ej_fr";
            this.textBox_ej_fr.Size = new System.Drawing.Size(132, 22);
            this.textBox_ej_fr.TabIndex = 14;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_title.Location = new System.Drawing.Point(70, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(228, 26);
            this.label_title.TabIndex = 23;
            this.label_title.Text = "Heart failure diagnosis";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // label_instructions
            // 
            this.label_instructions.AutoSize = true;
            this.label_instructions.Location = new System.Drawing.Point(12, 480);
            this.label_instructions.Name = "label_instructions";
            this.label_instructions.Size = new System.Drawing.Size(317, 68);
            this.label_instructions.TabIndex = 24;
            this.label_instructions.Text = "-if diagnosis result is 1 death od patient is very \r\n possible, if the result is " +
    "0, patient is in no fear of \r\n death\r\n ";
            // 
            // label_diagnosis_prediction
            // 
            this.label_diagnosis_prediction.AutoSize = true;
            this.label_diagnosis_prediction.Location = new System.Drawing.Point(178, 451);
            this.label_diagnosis_prediction.Name = "label_diagnosis_prediction";
            this.label_diagnosis_prediction.Size = new System.Drawing.Size(151, 17);
            this.label_diagnosis_prediction.TabIndex = 25;
            this.label_diagnosis_prediction.Text = "waiting for patient data";
            this.label_diagnosis_prediction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeartFailureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(407, 557);
            this.Controls.Add(this.label_diagnosis_prediction);
            this.Controls.Add(this.label_instructions);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.btn_send_patient_data);
            this.Controls.Add(this.label_diagnosis);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_se_cr);
            this.Controls.Add(this.textBox_platelets);
            this.Controls.Add(this.textBox_ej_fr);
            this.Controls.Add(this.textBox_diabetes);
            this.Controls.Add(this.textBox_cr_ph);
            this.Controls.Add(this.textBox_anaemia);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_serum_cr);
            this.Controls.Add(this.label_platelets);
            this.Controls.Add(this.label_ejection_fr);
            this.Controls.Add(this.label_diabetes);
            this.Controls.Add(this.label_cr_ph);
            this.Controls.Add(this.label_anaemia);
            this.Controls.Add(this.label_age);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HeartFailureForm";
            this.Text = "HeartFailureApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_anaemia;
        private System.Windows.Forms.Label label_cr_ph;
        private System.Windows.Forms.Label label_diabetes;
        private System.Windows.Forms.Label label_platelets;
        private System.Windows.Forms.Label label_serum_cr;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_anaemia;
        private System.Windows.Forms.TextBox textBox_cr_ph;
        private System.Windows.Forms.TextBox textBox_diabetes;
        private System.Windows.Forms.TextBox textBox_platelets;
        private System.Windows.Forms.TextBox textBox_se_cr;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label_diagnosis;
        private System.Windows.Forms.Button btn_send_patient_data;
        private System.Windows.Forms.Label label_ejection_fr;
        private System.Windows.Forms.TextBox textBox_ej_fr;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_instructions;
        private System.Windows.Forms.Label label_diagnosis_prediction;
    }
}

