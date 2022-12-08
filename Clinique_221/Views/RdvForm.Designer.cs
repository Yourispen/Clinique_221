namespace Clinique_221.Views
{
    partial class RdvForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RdvForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvListeRdv = new System.Windows.Forms.DataGridView();
            this.dtgcAnnulerRdv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgcModifierRdv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgcEtatRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcNomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcTypeRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcNomPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcDateRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterRdv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeRdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnAjouterRdv);
            this.panel1.Controls.Add(this.dtgvListeRdv);
            this.panel1.Location = new System.Drawing.Point(28, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 463);
            this.panel1.TabIndex = 0;
            // 
            // dtgvListeRdv
            // 
            this.dtgvListeRdv.AllowUserToAddRows = false;
            this.dtgvListeRdv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvListeRdv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvListeRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvListeRdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListeRdv.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListeRdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListeRdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvListeRdv.ColumnHeadersHeight = 30;
            this.dtgvListeRdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgcDateRdv,
            this.dtgcNomPatient,
            this.dtgcTypeRdv,
            this.dtgcNomMedecin,
            this.dtgcEtatRdv,
            this.dtgcModifierRdv,
            this.dtgcAnnulerRdv});
            this.dtgvListeRdv.Location = new System.Drawing.Point(18, 54);
            this.dtgvListeRdv.Name = "dtgvListeRdv";
            this.dtgvListeRdv.ReadOnly = true;
            this.dtgvListeRdv.RowHeadersVisible = false;
            this.dtgvListeRdv.Size = new System.Drawing.Size(894, 360);
            this.dtgvListeRdv.TabIndex = 0;
            // 
            // dtgcAnnulerRdv
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dtgcAnnulerRdv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgcAnnulerRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtgcAnnulerRdv.HeaderText = "";
            this.dtgcAnnulerRdv.Name = "dtgcAnnulerRdv";
            this.dtgcAnnulerRdv.ReadOnly = true;
            this.dtgcAnnulerRdv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgcAnnulerRdv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtgcModifierRdv
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dtgcModifierRdv.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgcModifierRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtgcModifierRdv.HeaderText = "";
            this.dtgcModifierRdv.Name = "dtgcModifierRdv";
            this.dtgcModifierRdv.ReadOnly = true;
            this.dtgcModifierRdv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgcModifierRdv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtgcEtatRdv
            // 
            this.dtgcEtatRdv.HeaderText = "Etat";
            this.dtgcEtatRdv.Name = "dtgcEtatRdv";
            this.dtgcEtatRdv.ReadOnly = true;
            // 
            // dtgcNomMedecin
            // 
            this.dtgcNomMedecin.HeaderText = "Medecin";
            this.dtgcNomMedecin.Name = "dtgcNomMedecin";
            this.dtgcNomMedecin.ReadOnly = true;
            // 
            // dtgcTypeRdv
            // 
            this.dtgcTypeRdv.HeaderText = "Type";
            this.dtgcTypeRdv.Name = "dtgcTypeRdv";
            this.dtgcTypeRdv.ReadOnly = true;
            // 
            // dtgcNomPatient
            // 
            this.dtgcNomPatient.HeaderText = "Patient";
            this.dtgcNomPatient.Name = "dtgcNomPatient";
            this.dtgcNomPatient.ReadOnly = true;
            // 
            // dtgcDateRdv
            // 
            this.dtgcDateRdv.HeaderText = "Date";
            this.dtgcDateRdv.Name = "dtgcDateRdv";
            this.dtgcDateRdv.ReadOnly = true;
            // 
            // btnAjouterRdv
            // 
            this.btnAjouterRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterRdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouterRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterRdv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterRdv.ForeColor = System.Drawing.Color.White;
            this.btnAjouterRdv.Location = new System.Drawing.Point(18, 12);
            this.btnAjouterRdv.Name = "btnAjouterRdv";
            this.btnAjouterRdv.Size = new System.Drawing.Size(129, 31);
            this.btnAjouterRdv.TabIndex = 1;
            this.btnAjouterRdv.Text = "Nouveau";
            this.btnAjouterRdv.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(749, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(722, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // RdvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 514);
            this.Controls.Add(this.panel1);
            this.Name = "RdvForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RdvForm";
            this.Load += new System.EventHandler(this.RdvForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeRdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvListeRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcDateRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcNomPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcTypeRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcNomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcEtatRdv;
        private System.Windows.Forms.DataGridViewButtonColumn dtgcModifierRdv;
        private System.Windows.Forms.DataGridViewButtonColumn dtgcAnnulerRdv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAjouterRdv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}