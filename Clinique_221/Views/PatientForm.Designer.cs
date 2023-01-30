namespace Clinique_221.Views
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.dtgvListePatient = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecherche = new System.Windows.Forms.PictureBox();
            this.txtRecherchePatient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListePatient)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListePatient
            // 
            this.dtgvListePatient.AllowUserToOrderColumns = true;
            this.dtgvListePatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvListePatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListePatient.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListePatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListePatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListePatient.ColumnHeadersHeight = 30;
            this.dtgvListePatient.Location = new System.Drawing.Point(26, 73);
            this.dtgvListePatient.MultiSelect = false;
            this.dtgvListePatient.Name = "dtgvListePatient";
            this.dtgvListePatient.ReadOnly = true;
            this.dtgvListePatient.RowHeadersVisible = false;
            this.dtgvListePatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListePatient.Size = new System.Drawing.Size(759, 360);
            this.dtgvListePatient.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRecherche);
            this.panel1.Controls.Add(this.txtRecherchePatient);
            this.panel1.Controls.Add(this.dtgvListePatient);
            this.panel1.Location = new System.Drawing.Point(30, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 500);
            this.panel1.TabIndex = 1;
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
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.panel1);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListePatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecherche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListePatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnRecherche;
        private System.Windows.Forms.TextBox txtRecherchePatient;
    }
}