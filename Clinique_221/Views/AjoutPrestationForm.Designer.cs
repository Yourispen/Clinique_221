namespace Clinique_221.Views
{
    partial class AjoutPrestationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAjoutRdv = new System.Windows.Forms.Panel();
            this.pnlRechercherPatient = new System.Windows.Forms.Panel();
            this.btnRecherchePatient = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxPrestation = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pnlTitreBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAjoutPatient = new System.Windows.Forms.Panel();
            this.chlboxAntecedentMedical = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chboxMasculin = new System.Windows.Forms.CheckBox();
            this.chboxFeminin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomComplet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.gboxPatient = new System.Windows.Forms.GroupBox();
            this.lblListePrestation = new System.Windows.Forms.Label();
            this.chlboxListeDesPrestations = new System.Windows.Forms.CheckedListBox();
            this.pnlAjoutRdv.SuspendLayout();
            this.pnlRechercherPatient.SuspendLayout();
            this.gboxPrestation.SuspendLayout();
            this.pnlTitreBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAjoutPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details Prestation";
            // 
            // pnlAjoutRdv
            // 
            this.pnlAjoutRdv.BackColor = System.Drawing.Color.White;
            this.pnlAjoutRdv.Controls.Add(this.chlboxListeDesPrestations);
            this.pnlAjoutRdv.Controls.Add(this.lblListePrestation);
            this.pnlAjoutRdv.Location = new System.Drawing.Point(6, 38);
            this.pnlAjoutRdv.Name = "pnlAjoutRdv";
            this.pnlAjoutRdv.Size = new System.Drawing.Size(409, 212);
            this.pnlAjoutRdv.TabIndex = 12;
            // 
            // pnlRechercherPatient
            // 
            this.pnlRechercherPatient.Controls.Add(this.btnRecherchePatient);
            this.pnlRechercherPatient.Controls.Add(this.txtCode);
            this.pnlRechercherPatient.Controls.Add(this.label2);
            this.pnlRechercherPatient.Location = new System.Drawing.Point(6, 50);
            this.pnlRechercherPatient.Name = "pnlRechercherPatient";
            this.pnlRechercherPatient.Size = new System.Drawing.Size(361, 81);
            this.pnlRechercherPatient.TabIndex = 16;
            // 
            // btnRecherchePatient
            // 
            this.btnRecherchePatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecherchePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnRecherchePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherchePatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherchePatient.ForeColor = System.Drawing.Color.White;
            this.btnRecherchePatient.Location = new System.Drawing.Point(272, 26);
            this.btnRecherchePatient.Name = "btnRecherchePatient";
            this.btnRecherchePatient.Size = new System.Drawing.Size(81, 31);
            this.btnRecherchePatient.TabIndex = 15;
            this.btnRecherchePatient.Text = "Ok";
            this.btnRecherchePatient.UseVisualStyleBackColor = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(16, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(250, 29);
            this.txtCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code du Patient";
            // 
            // gboxPrestation
            // 
            this.gboxPrestation.Controls.Add(this.pnlAjoutRdv);
            this.gboxPrestation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPrestation.Location = new System.Drawing.Point(382, 19);
            this.gboxPrestation.Name = "gboxPrestation";
            this.gboxPrestation.Size = new System.Drawing.Size(428, 355);
            this.gboxPrestation.TabIndex = 18;
            this.gboxPrestation.TabStop = false;
            this.gboxPrestation.Text = "Prestation";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(420, 440);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(129, 31);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Créer";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnnuler.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(628, 440);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(129, 31);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // pnlTitreBar
            // 
            this.pnlTitreBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitreBar.Controls.Add(this.label1);
            this.pnlTitreBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitreBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitreBar.Name = "pnlTitreBar";
            this.pnlTitreBar.Size = new System.Drawing.Size(855, 34);
            this.pnlTitreBar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlAjoutPatient);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.gboxPatient);
            this.panel1.Controls.Add(this.gboxPrestation);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 517);
            this.panel1.TabIndex = 3;
            // 
            // pnlAjoutPatient
            // 
            this.pnlAjoutPatient.BackColor = System.Drawing.Color.White;
            this.pnlAjoutPatient.Controls.Add(this.chlboxAntecedentMedical);
            this.pnlAjoutPatient.Controls.Add(this.label7);
            this.pnlAjoutPatient.Controls.Add(this.label3);
            this.pnlAjoutPatient.Controls.Add(this.groupBox1);
            this.pnlAjoutPatient.Controls.Add(this.txtNomComplet);
            this.pnlAjoutPatient.Controls.Add(this.label5);
            this.pnlAjoutPatient.Controls.Add(this.dtpDateNaissance);
            this.pnlAjoutPatient.Location = new System.Drawing.Point(0, 156);
            this.pnlAjoutPatient.Name = "pnlAjoutPatient";
            this.pnlAjoutPatient.Size = new System.Drawing.Size(360, 315);
            this.pnlAjoutPatient.TabIndex = 11;
            // 
            // chlboxAntecedentMedical
            // 
            this.chlboxAntecedentMedical.CheckOnClick = true;
            this.chlboxAntecedentMedical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlboxAntecedentMedical.FormattingEnabled = true;
            this.chlboxAntecedentMedical.Location = new System.Drawing.Point(23, 221);
            this.chlboxAntecedentMedical.Name = "chlboxAntecedentMedical";
            this.chlboxAntecedentMedical.Size = new System.Drawing.Size(320, 84);
            this.chlboxAntecedentMedical.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Antécédent Médical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom Complet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chboxMasculin);
            this.groupBox1.Controls.Add(this.chboxFeminin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 46);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // chboxMasculin
            // 
            this.chboxMasculin.AutoSize = true;
            this.chboxMasculin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxMasculin.Location = new System.Drawing.Point(142, 17);
            this.chboxMasculin.Name = "chboxMasculin";
            this.chboxMasculin.Size = new System.Drawing.Size(43, 25);
            this.chboxMasculin.TabIndex = 7;
            this.chboxMasculin.Text = "M";
            this.chboxMasculin.UseVisualStyleBackColor = true;
            // 
            // chboxFeminin
            // 
            this.chboxFeminin.AutoSize = true;
            this.chboxFeminin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxFeminin.Location = new System.Drawing.Point(67, 17);
            this.chboxFeminin.Name = "chboxFeminin";
            this.chboxFeminin.Size = new System.Drawing.Size(37, 25);
            this.chboxFeminin.TabIndex = 6;
            this.chboxFeminin.Text = "F";
            this.chboxFeminin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexe";
            // 
            // txtNomComplet
            // 
            this.txtNomComplet.Location = new System.Drawing.Point(23, 30);
            this.txtNomComplet.Name = "txtNomComplet";
            this.txtNomComplet.Size = new System.Drawing.Size(324, 20);
            this.txtNomComplet.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date de naissance";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.Location = new System.Drawing.Point(25, 140);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(220, 22);
            this.dtpDateNaissance.TabIndex = 9;
            // 
            // gboxPatient
            // 
            this.gboxPatient.Controls.Add(this.pnlRechercherPatient);
            this.gboxPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPatient.Location = new System.Drawing.Point(1, 19);
            this.gboxPatient.Name = "gboxPatient";
            this.gboxPatient.Size = new System.Drawing.Size(373, 458);
            this.gboxPatient.TabIndex = 17;
            this.gboxPatient.TabStop = false;
            this.gboxPatient.Text = "Patient";
            // 
            // lblListePrestation
            // 
            this.lblListePrestation.AutoSize = true;
            this.lblListePrestation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePrestation.Location = new System.Drawing.Point(18, 45);
            this.lblListePrestation.Name = "lblListePrestation";
            this.lblListePrestation.Size = new System.Drawing.Size(164, 21);
            this.lblListePrestation.TabIndex = 17;
            this.lblListePrestation.Text = "Liste des prestations";
            // 
            // chlboxListeDesPrestations
            // 
            this.chlboxListeDesPrestations.CheckOnClick = true;
            this.chlboxListeDesPrestations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlboxListeDesPrestations.FormattingEnabled = true;
            this.chlboxListeDesPrestations.Location = new System.Drawing.Point(22, 87);
            this.chlboxListeDesPrestations.Name = "chlboxListeDesPrestations";
            this.chlboxListeDesPrestations.Size = new System.Drawing.Size(356, 89);
            this.chlboxListeDesPrestations.TabIndex = 18;
            // 
            // AjoutPrestationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 569);
            this.Controls.Add(this.pnlTitreBar);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutPrestationForm";
            this.Text = "AjoutPrestationForm";
            this.Load += new System.EventHandler(this.AjoutPrestationForm_Load);
            this.pnlAjoutRdv.ResumeLayout(false);
            this.pnlAjoutRdv.PerformLayout();
            this.pnlRechercherPatient.ResumeLayout(false);
            this.pnlRechercherPatient.PerformLayout();
            this.gboxPrestation.ResumeLayout(false);
            this.pnlTitreBar.ResumeLayout(false);
            this.pnlTitreBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlAjoutPatient.ResumeLayout(false);
            this.pnlAjoutPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAjoutRdv;
        private System.Windows.Forms.Panel pnlRechercherPatient;
        private System.Windows.Forms.Button btnRecherchePatient;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxPrestation;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Panel pnlTitreBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAjoutPatient;
        private System.Windows.Forms.CheckedListBox chlboxAntecedentMedical;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chboxMasculin;
        private System.Windows.Forms.CheckBox chboxFeminin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomComplet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.GroupBox gboxPatient;
        private System.Windows.Forms.CheckedListBox chlboxListeDesPrestations;
        private System.Windows.Forms.Label lblListePrestation;
    }
}