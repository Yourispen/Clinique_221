namespace Clinique_221.Views
{
    partial class AjoutConsultationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboxPatient = new System.Windows.Forms.GroupBox();
            this.pnlRechercherPatient = new System.Windows.Forms.Panel();
            this.btnRecherchePatient = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomComplet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chboxMasculin = new System.Windows.Forms.CheckBox();
            this.chboxFeminin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chlboxAntecedentMedical = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlAjoutPatient = new System.Windows.Forms.Panel();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.pnlTitreBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxConsultation = new System.Windows.Forms.GroupBox();
            this.pnlMedicament = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gboxOrdonnance = new System.Windows.Forms.GroupBox();
            this.chboxAvec = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chboxSans = new System.Windows.Forms.CheckBox();
            this.dtgvListeMedicament = new System.Windows.Forms.DataGridView();
            this.btnSupprimerMedicament = new System.Windows.Forms.Button();
            this.txtCodeMedicament = new System.Windows.Forms.TextBox();
            this.btnAjouterMedicament = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gboxPatient.SuspendLayout();
            this.pnlRechercherPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAjoutPatient.SuspendLayout();
            this.pnlTitreBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gboxConsultation.SuspendLayout();
            this.pnlMedicament.SuspendLayout();
            this.gboxOrdonnance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeMedicament)).BeginInit();
            this.SuspendLayout();
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
            this.btnRecherchePatient.BackColor = System.Drawing.Color.DodgerBlue;
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
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.Location = new System.Drawing.Point(25, 140);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(220, 22);
            this.dtpDateNaissance.TabIndex = 9;
            // 
            // pnlTitreBar
            // 
            this.pnlTitreBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitreBar.Controls.Add(this.label1);
            this.pnlTitreBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitreBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitreBar.Name = "pnlTitreBar";
            this.pnlTitreBar.Size = new System.Drawing.Size(855, 34);
            this.pnlTitreBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details Consultation";
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
            this.panel1.Controls.Add(this.gboxConsultation);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 517);
            this.panel1.TabIndex = 5;
            // 
            // gboxConsultation
            // 
            this.gboxConsultation.Controls.Add(this.pnlMedicament);
            this.gboxConsultation.Controls.Add(this.gboxOrdonnance);
            this.gboxConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxConsultation.Location = new System.Drawing.Point(382, 19);
            this.gboxConsultation.Name = "gboxConsultation";
            this.gboxConsultation.Size = new System.Drawing.Size(428, 394);
            this.gboxConsultation.TabIndex = 18;
            this.gboxConsultation.TabStop = false;
            this.gboxConsultation.Text = "Consultation";
            // 
            // pnlMedicament
            // 
            this.pnlMedicament.BackColor = System.Drawing.Color.White;
            this.pnlMedicament.Controls.Add(this.label8);
            this.pnlMedicament.Controls.Add(this.btnAjouterMedicament);
            this.pnlMedicament.Controls.Add(this.txtCodeMedicament);
            this.pnlMedicament.Controls.Add(this.btnSupprimerMedicament);
            this.pnlMedicament.Controls.Add(this.dtgvListeMedicament);
            this.pnlMedicament.Location = new System.Drawing.Point(6, 129);
            this.pnlMedicament.Name = "pnlMedicament";
            this.pnlMedicament.Size = new System.Drawing.Size(409, 248);
            this.pnlMedicament.TabIndex = 12;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(431, 440);
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
            this.btnAnnuler.Location = new System.Drawing.Point(621, 440);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(129, 31);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // gboxOrdonnance
            // 
            this.gboxOrdonnance.Controls.Add(this.chboxAvec);
            this.gboxOrdonnance.Controls.Add(this.label6);
            this.gboxOrdonnance.Controls.Add(this.chboxSans);
            this.gboxOrdonnance.Location = new System.Drawing.Point(87, 50);
            this.gboxOrdonnance.Name = "gboxOrdonnance";
            this.gboxOrdonnance.Size = new System.Drawing.Size(221, 62);
            this.gboxOrdonnance.TabIndex = 15;
            this.gboxOrdonnance.TabStop = false;
            // 
            // chboxAvec
            // 
            this.chboxAvec.AutoSize = true;
            this.chboxAvec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxAvec.Location = new System.Drawing.Point(142, 24);
            this.chboxAvec.Name = "chboxAvec";
            this.chboxAvec.Size = new System.Drawing.Size(62, 25);
            this.chboxAvec.TabIndex = 7;
            this.chboxAvec.Text = "Avec";
            this.chboxAvec.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ordonnance";
            // 
            // chboxSans
            // 
            this.chboxSans.AutoSize = true;
            this.chboxSans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxSans.Location = new System.Drawing.Point(57, 24);
            this.chboxSans.Name = "chboxSans";
            this.chboxSans.Size = new System.Drawing.Size(62, 25);
            this.chboxSans.TabIndex = 6;
            this.chboxSans.Text = "Sans";
            this.chboxSans.UseVisualStyleBackColor = true;
            // 
            // dtgvListeMedicament
            // 
            this.dtgvListeMedicament.AllowUserToOrderColumns = true;
            this.dtgvListeMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvListeMedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListeMedicament.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListeMedicament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListeMedicament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListeMedicament.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListeMedicament.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListeMedicament.Location = new System.Drawing.Point(12, 92);
            this.dtgvListeMedicament.MultiSelect = false;
            this.dtgvListeMedicament.Name = "dtgvListeMedicament";
            this.dtgvListeMedicament.ReadOnly = true;
            this.dtgvListeMedicament.RowHeadersVisible = false;
            this.dtgvListeMedicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListeMedicament.Size = new System.Drawing.Size(275, 142);
            this.dtgvListeMedicament.TabIndex = 16;
            // 
            // btnSupprimerMedicament
            // 
            this.btnSupprimerMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSupprimerMedicament.BackColor = System.Drawing.Color.Tomato;
            this.btnSupprimerMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerMedicament.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMedicament.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerMedicament.Location = new System.Drawing.Point(293, 88);
            this.btnSupprimerMedicament.Name = "btnSupprimerMedicament";
            this.btnSupprimerMedicament.Size = new System.Drawing.Size(102, 31);
            this.btnSupprimerMedicament.TabIndex = 15;
            this.btnSupprimerMedicament.Text = "Supprimer";
            this.btnSupprimerMedicament.UseVisualStyleBackColor = false;
            // 
            // txtCodeMedicament
            // 
            this.txtCodeMedicament.Location = new System.Drawing.Point(31, 40);
            this.txtCodeMedicament.Name = "txtCodeMedicament";
            this.txtCodeMedicament.Size = new System.Drawing.Size(167, 29);
            this.txtCodeMedicament.TabIndex = 16;
            // 
            // btnAjouterMedicament
            // 
            this.btnAjouterMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouterMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterMedicament.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterMedicament.ForeColor = System.Drawing.Color.White;
            this.btnAjouterMedicament.Location = new System.Drawing.Point(206, 38);
            this.btnAjouterMedicament.Name = "btnAjouterMedicament";
            this.btnAjouterMedicament.Size = new System.Drawing.Size(81, 31);
            this.btnAjouterMedicament.TabIndex = 16;
            this.btnAjouterMedicament.Text = "Ajouter";
            this.btnAjouterMedicament.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Code du Medicament";
            // 
            // AjoutConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 569);
            this.Controls.Add(this.pnlTitreBar);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutConsultationForm";
            this.Text = "AjoutConsultationForm";
            this.Load += new System.EventHandler(this.AjoutConsultationForm_Load);
            this.gboxPatient.ResumeLayout(false);
            this.pnlRechercherPatient.ResumeLayout(false);
            this.pnlRechercherPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAjoutPatient.ResumeLayout(false);
            this.pnlAjoutPatient.PerformLayout();
            this.pnlTitreBar.ResumeLayout(false);
            this.pnlTitreBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gboxConsultation.ResumeLayout(false);
            this.pnlMedicament.ResumeLayout(false);
            this.pnlMedicament.PerformLayout();
            this.gboxOrdonnance.ResumeLayout(false);
            this.gboxOrdonnance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPatient;
        private System.Windows.Forms.Panel pnlRechercherPatient;
        private System.Windows.Forms.Button btnRecherchePatient;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomComplet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chboxMasculin;
        private System.Windows.Forms.CheckBox chboxFeminin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chlboxAntecedentMedical;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlAjoutPatient;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Panel pnlTitreBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxConsultation;
        private System.Windows.Forms.Panel pnlMedicament;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox gboxOrdonnance;
        private System.Windows.Forms.CheckBox chboxAvec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chboxSans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAjouterMedicament;
        private System.Windows.Forms.TextBox txtCodeMedicament;
        private System.Windows.Forms.Button btnSupprimerMedicament;
        private System.Windows.Forms.DataGridView dtgvListeMedicament;
    }
}