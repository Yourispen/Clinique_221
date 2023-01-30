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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RdvForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltreParDate = new System.Windows.Forms.Button();
            this.btnAnnulerRdv = new System.Windows.Forms.Button();
            this.btnValiderRdv = new System.Windows.Forms.Button();
            this.dtpDateRdv = new System.Windows.Forms.DateTimePicker();
            this.btnRecherche = new System.Windows.Forms.PictureBox();
            this.txtRecherchePatient = new System.Windows.Forms.TextBox();
            this.btnAjouterRdv = new System.Windows.Forms.Button();
            this.dtgvListeRdv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecherche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeRdv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtgvListeRdv);
            this.panel1.Controls.Add(this.btnFiltreParDate);
            this.panel1.Controls.Add(this.btnAnnulerRdv);
            this.panel1.Controls.Add(this.btnValiderRdv);
            this.panel1.Controls.Add(this.dtpDateRdv);
            this.panel1.Controls.Add(this.btnRecherche);
            this.panel1.Controls.Add(this.txtRecherchePatient);
            this.panel1.Controls.Add(this.btnAjouterRdv);
            this.panel1.Location = new System.Drawing.Point(28, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnFiltreParDate
            // 
            this.btnFiltreParDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltreParDate.BackColor = System.Drawing.Color.Gray;
            this.btnFiltreParDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreParDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltreParDate.ForeColor = System.Drawing.Color.White;
            this.btnFiltreParDate.Location = new System.Drawing.Point(528, 16);
            this.btnFiltreParDate.Name = "btnFiltreParDate";
            this.btnFiltreParDate.Size = new System.Drawing.Size(52, 29);
            this.btnFiltreParDate.TabIndex = 13;
            this.btnFiltreParDate.Text = "OK";
            this.btnFiltreParDate.UseVisualStyleBackColor = false;
            // 
            // btnAnnulerRdv
            // 
            this.btnAnnulerRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnnulerRdv.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnulerRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerRdv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerRdv.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerRdv.Location = new System.Drawing.Point(791, 119);
            this.btnAnnulerRdv.Name = "btnAnnulerRdv";
            this.btnAnnulerRdv.Size = new System.Drawing.Size(129, 31);
            this.btnAnnulerRdv.TabIndex = 12;
            this.btnAnnulerRdv.Text = "Annuler";
            this.btnAnnulerRdv.UseVisualStyleBackColor = false;
            // 
            // btnValiderRdv
            // 
            this.btnValiderRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnValiderRdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnValiderRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderRdv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderRdv.ForeColor = System.Drawing.Color.White;
            this.btnValiderRdv.Location = new System.Drawing.Point(791, 73);
            this.btnValiderRdv.Name = "btnValiderRdv";
            this.btnValiderRdv.Size = new System.Drawing.Size(129, 31);
            this.btnValiderRdv.TabIndex = 11;
            this.btnValiderRdv.Text = "Valider";
            this.btnValiderRdv.UseVisualStyleBackColor = false;
            // 
            // dtpDateRdv
            // 
            this.dtpDateRdv.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRdv.Location = new System.Drawing.Point(284, 19);
            this.dtpDateRdv.Name = "dtpDateRdv";
            this.dtpDateRdv.Size = new System.Drawing.Size(220, 22);
            this.dtpDateRdv.TabIndex = 10;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecherche.BackColor = System.Drawing.Color.Silver;
            this.btnRecherche.Image = ((System.Drawing.Image)(resources.GetObject("btnRecherche.Image")));
            this.btnRecherche.Location = new System.Drawing.Point(730, 38);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(27, 20);
            this.btnRecherche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.TabStop = false;
            // 
            // txtRecherchePatient
            // 
            this.txtRecherchePatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRecherchePatient.Location = new System.Drawing.Point(757, 38);
            this.txtRecherchePatient.Name = "txtRecherchePatient";
            this.txtRecherchePatient.Size = new System.Drawing.Size(163, 20);
            this.txtRecherchePatient.TabIndex = 2;
            this.txtRecherchePatient.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAjouterRdv
            // 
            this.btnAjouterRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterRdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouterRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterRdv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterRdv.ForeColor = System.Drawing.Color.White;
            this.btnAjouterRdv.Location = new System.Drawing.Point(26, 31);
            this.btnAjouterRdv.Name = "btnAjouterRdv";
            this.btnAjouterRdv.Size = new System.Drawing.Size(129, 31);
            this.btnAjouterRdv.TabIndex = 1;
            this.btnAjouterRdv.Text = "Nouveau";
            this.btnAjouterRdv.UseVisualStyleBackColor = false;
            // 
            // dtgvListeRdv
            // 
            this.dtgvListeRdv.AllowUserToAddRows = false;
            this.dtgvListeRdv.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListeRdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListeRdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListeRdv.Location = new System.Drawing.Point(26, 73);
            this.dtgvListeRdv.Name = "dtgvListeRdv";
            this.dtgvListeRdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListeRdv.Size = new System.Drawing.Size(759, 360);
            this.dtgvListeRdv.TabIndex = 14;
            // 
            // RdvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.panel1);
            this.Name = "RdvForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RdvForm";
            this.Load += new System.EventHandler(this.RdvForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecherche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeRdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnRecherche;
        private System.Windows.Forms.TextBox txtRecherchePatient;
        private System.Windows.Forms.Button btnAjouterRdv;
        private System.Windows.Forms.DateTimePicker dtpDateRdv;
        private System.Windows.Forms.Button btnAnnulerRdv;
        private System.Windows.Forms.Button btnValiderRdv;
        private System.Windows.Forms.Button btnFiltreParDate;
        private System.Windows.Forms.DataGridView dtgvListeRdv;
    }
}