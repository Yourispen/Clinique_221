namespace Clinique_221.Views
{
    partial class AjoutRdvForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAjoutPatient = new System.Windows.Forms.Panel();
            this.chlboxAntecedentMedical = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomParent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chboxMasculin = new System.Windows.Forms.CheckBox();
            this.chboxFeminin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomComplet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.gboxPatient = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecherchePatient = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.gboxRdv = new System.Windows.Forms.GroupBox();
            this.pnlAjoutRdv = new System.Windows.Forms.Panel();
            this.chlboxListeDesPrestations = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chboxPrestation = new System.Windows.Forms.CheckBox();
            this.chboxConsultation = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDateRdv = new System.Windows.Forms.DateTimePicker();
            this.lblListePrestation = new System.Windows.Forms.Label();
            this.cboxListeDesMedecin = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.btnAjouterDemandeRdv = new System.Windows.Forms.Button();
            this.btnAnnulerDemandeRdv = new System.Windows.Forms.Button();
            this.pnlTitreBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chboxNouveauPatient = new System.Windows.Forms.CheckBox();
            this.chboxAncienPatient = new System.Windows.Forms.CheckBox();
            this.pnlRechercherPatient = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlAjoutPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxPatient.SuspendLayout();
            this.gboxRdv.SuspendLayout();
            this.pnlAjoutRdv.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTitreBar.SuspendLayout();
            this.pnlRechercherPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlAjoutPatient);
            this.panel1.Controls.Add(this.gboxPatient);
            this.panel1.Controls.Add(this.gboxRdv);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 517);
            this.panel1.TabIndex = 0;
            // 
            // pnlAjoutPatient
            // 
            this.pnlAjoutPatient.BackColor = System.Drawing.Color.White;
            this.pnlAjoutPatient.Controls.Add(this.chlboxAntecedentMedical);
            this.pnlAjoutPatient.Controls.Add(this.label7);
            this.pnlAjoutPatient.Controls.Add(this.label6);
            this.pnlAjoutPatient.Controls.Add(this.txtNomParent);
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
            this.chlboxAntecedentMedical.FormattingEnabled = true;
            this.chlboxAntecedentMedical.Items.AddRange(new object[] {
            "Diabète",
            "Hypertension",
            "Hépatite"});
            this.chlboxAntecedentMedical.Location = new System.Drawing.Point(23, 244);
            this.chlboxAntecedentMedical.Name = "chlboxAntecedentMedical";
            this.chlboxAntecedentMedical.Size = new System.Drawing.Size(320, 49);
            this.chlboxAntecedentMedical.TabIndex = 16;
            this.chlboxAntecedentMedical.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Antécédent Médical";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nom du parent";
            // 
            // txtNomParent
            // 
            this.txtNomParent.Location = new System.Drawing.Point(25, 196);
            this.txtNomParent.Name = "txtNomParent";
            this.txtNomParent.Size = new System.Drawing.Size(322, 20);
            this.txtNomParent.TabIndex = 11;
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.chboxFeminin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.txtNomComplet.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.gboxPatient.Controls.Add(this.chboxAncienPatient);
            this.gboxPatient.Controls.Add(this.chboxNouveauPatient);
            this.gboxPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPatient.Location = new System.Drawing.Point(1, 19);
            this.gboxPatient.Name = "gboxPatient";
            this.gboxPatient.Size = new System.Drawing.Size(373, 458);
            this.gboxPatient.TabIndex = 17;
            this.gboxPatient.TabStop = false;
            this.gboxPatient.Text = "Patient";
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // gboxRdv
            // 
            this.gboxRdv.Controls.Add(this.pnlAjoutRdv);
            this.gboxRdv.Controls.Add(this.btnAjouterDemandeRdv);
            this.gboxRdv.Controls.Add(this.btnAnnulerDemandeRdv);
            this.gboxRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRdv.Location = new System.Drawing.Point(382, 19);
            this.gboxRdv.Name = "gboxRdv";
            this.gboxRdv.Size = new System.Drawing.Size(412, 458);
            this.gboxRdv.TabIndex = 18;
            this.gboxRdv.TabStop = false;
            this.gboxRdv.Text = "Rendez-vous";
            // 
            // pnlAjoutRdv
            // 
            this.pnlAjoutRdv.BackColor = System.Drawing.Color.White;
            this.pnlAjoutRdv.Controls.Add(this.chlboxListeDesPrestations);
            this.pnlAjoutRdv.Controls.Add(this.groupBox2);
            this.pnlAjoutRdv.Controls.Add(this.label9);
            this.pnlAjoutRdv.Controls.Add(this.dtpDateRdv);
            this.pnlAjoutRdv.Controls.Add(this.lblListePrestation);
            this.pnlAjoutRdv.Controls.Add(this.cboxListeDesMedecin);
            this.pnlAjoutRdv.Controls.Add(this.lblMedecin);
            this.pnlAjoutRdv.Location = new System.Drawing.Point(6, 38);
            this.pnlAjoutRdv.Name = "pnlAjoutRdv";
            this.pnlAjoutRdv.Size = new System.Drawing.Size(393, 306);
            this.pnlAjoutRdv.TabIndex = 12;
            // 
            // chlboxListeDesPrestations
            // 
            this.chlboxListeDesPrestations.CheckOnClick = true;
            this.chlboxListeDesPrestations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlboxListeDesPrestations.FormattingEnabled = true;
            this.chlboxListeDesPrestations.Location = new System.Drawing.Point(26, 215);
            this.chlboxListeDesPrestations.Name = "chlboxListeDesPrestations";
            this.chlboxListeDesPrestations.Size = new System.Drawing.Size(356, 72);
            this.chlboxListeDesPrestations.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chboxPrestation);
            this.groupBox2.Controls.Add(this.chboxConsultation);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(22, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 46);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // chboxPrestation
            // 
            this.chboxPrestation.AutoSize = true;
            this.chboxPrestation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxPrestation.Location = new System.Drawing.Point(213, 15);
            this.chboxPrestation.Name = "chboxPrestation";
            this.chboxPrestation.Size = new System.Drawing.Size(99, 25);
            this.chboxPrestation.TabIndex = 7;
            this.chboxPrestation.Text = "Prestation";
            this.chboxPrestation.UseVisualStyleBackColor = true;
            // 
            // chboxConsultation
            // 
            this.chboxConsultation.AutoSize = true;
            this.chboxConsultation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxConsultation.Location = new System.Drawing.Point(70, 15);
            this.chboxConsultation.Name = "chboxConsultation";
            this.chboxConsultation.Size = new System.Drawing.Size(117, 25);
            this.chboxConsultation.TabIndex = 6;
            this.chboxConsultation.Text = "Consultation";
            this.chboxConsultation.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Type";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date du rendez-vous";
            // 
            // dtpDateRdv
            // 
            this.dtpDateRdv.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRdv.Location = new System.Drawing.Point(23, 140);
            this.dtpDateRdv.Name = "dtpDateRdv";
            this.dtpDateRdv.Size = new System.Drawing.Size(220, 22);
            this.dtpDateRdv.TabIndex = 18;
            // 
            // lblListePrestation
            // 
            this.lblListePrestation.AutoSize = true;
            this.lblListePrestation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePrestation.Location = new System.Drawing.Point(22, 191);
            this.lblListePrestation.Name = "lblListePrestation";
            this.lblListePrestation.Size = new System.Drawing.Size(164, 21);
            this.lblListePrestation.TabIndex = 17;
            this.lblListePrestation.Text = "Liste des prestations";
            // 
            // cboxListeDesMedecin
            // 
            this.cboxListeDesMedecin.FormattingEnabled = true;
            this.cboxListeDesMedecin.Location = new System.Drawing.Point(26, 233);
            this.cboxListeDesMedecin.Name = "cboxListeDesMedecin";
            this.cboxListeDesMedecin.Size = new System.Drawing.Size(356, 32);
            this.cboxListeDesMedecin.TabIndex = 18;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.Location = new System.Drawing.Point(22, 209);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(76, 21);
            this.lblMedecin.TabIndex = 17;
            this.lblMedecin.Text = "Médecin";
            this.lblMedecin.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnAjouterDemandeRdv
            // 
            this.btnAjouterDemandeRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterDemandeRdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouterDemandeRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDemandeRdv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDemandeRdv.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDemandeRdv.Location = new System.Drawing.Point(41, 399);
            this.btnAjouterDemandeRdv.Name = "btnAjouterDemandeRdv";
            this.btnAjouterDemandeRdv.Size = new System.Drawing.Size(129, 31);
            this.btnAjouterDemandeRdv.TabIndex = 13;
            this.btnAjouterDemandeRdv.Text = "Créer";
            this.btnAjouterDemandeRdv.UseVisualStyleBackColor = false;
            // 
            // btnAnnulerDemandeRdv
            // 
            this.btnAnnulerDemandeRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnnulerDemandeRdv.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnulerDemandeRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerDemandeRdv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerDemandeRdv.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerDemandeRdv.Location = new System.Drawing.Point(241, 399);
            this.btnAnnulerDemandeRdv.Name = "btnAnnulerDemandeRdv";
            this.btnAnnulerDemandeRdv.Size = new System.Drawing.Size(129, 31);
            this.btnAnnulerDemandeRdv.TabIndex = 14;
            this.btnAnnulerDemandeRdv.Text = "Annuler";
            this.btnAnnulerDemandeRdv.UseVisualStyleBackColor = false;
            // 
            // pnlTitreBar
            // 
            this.pnlTitreBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitreBar.Controls.Add(this.label1);
            this.pnlTitreBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitreBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitreBar.Name = "pnlTitreBar";
            this.pnlTitreBar.Size = new System.Drawing.Size(824, 34);
            this.pnlTitreBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Créer un Rendez-vous";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chboxNouveauPatient
            // 
            this.chboxNouveauPatient.AutoSize = true;
            this.chboxNouveauPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxNouveauPatient.Location = new System.Drawing.Point(90, 19);
            this.chboxNouveauPatient.Name = "chboxNouveauPatient";
            this.chboxNouveauPatient.Size = new System.Drawing.Size(99, 25);
            this.chboxNouveauPatient.TabIndex = 6;
            this.chboxNouveauPatient.Text = "Nouveau";
            this.chboxNouveauPatient.UseVisualStyleBackColor = true;
            this.chboxNouveauPatient.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chboxAncienPatient
            // 
            this.chboxAncienPatient.AutoSize = true;
            this.chboxAncienPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxAncienPatient.Location = new System.Drawing.Point(236, 19);
            this.chboxAncienPatient.Name = "chboxAncienPatient";
            this.chboxAncienPatient.Size = new System.Drawing.Size(82, 25);
            this.chboxAncienPatient.TabIndex = 7;
            this.chboxAncienPatient.Text = "Ancien";
            this.chboxAncienPatient.UseVisualStyleBackColor = true;
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
            // AjoutRdvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(824, 569);
            this.Controls.Add(this.pnlTitreBar);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutRdvForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutRdvForm";
            this.Load += new System.EventHandler(this.AjoutRdvForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlAjoutPatient.ResumeLayout(false);
            this.pnlAjoutPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxPatient.ResumeLayout(false);
            this.gboxPatient.PerformLayout();
            this.gboxRdv.ResumeLayout(false);
            this.pnlAjoutRdv.ResumeLayout(false);
            this.pnlAjoutRdv.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlTitreBar.ResumeLayout(false);
            this.pnlTitreBar.PerformLayout();
            this.pnlRechercherPatient.ResumeLayout(false);
            this.pnlRechercherPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTitreBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomComplet;
        private System.Windows.Forms.CheckBox chboxMasculin;
        private System.Windows.Forms.CheckBox chboxFeminin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlAjoutPatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomParent;
        private System.Windows.Forms.CheckedListBox chlboxAntecedentMedical;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlAjoutRdv;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDateRdv;
        private System.Windows.Forms.ComboBox cboxListeDesMedecin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chboxPrestation;
        private System.Windows.Forms.CheckBox chboxConsultation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox chlboxListeDesPrestations;
        private System.Windows.Forms.Label lblListePrestation;
        private System.Windows.Forms.Button btnAnnulerDemandeRdv;
        private System.Windows.Forms.Button btnAjouterDemandeRdv;
        private System.Windows.Forms.Button btnRecherchePatient;
        private System.Windows.Forms.GroupBox gboxPatient;
        private System.Windows.Forms.GroupBox gboxRdv;
        private System.Windows.Forms.CheckBox chboxAncienPatient;
        private System.Windows.Forms.CheckBox chboxNouveauPatient;
        private System.Windows.Forms.Panel pnlRechercherPatient;
    }
}