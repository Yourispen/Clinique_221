namespace Clinique_221.Views
{
    partial class PrestationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestationForm));
            this.dtgvListe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFiltreParDate = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnRecherche = new System.Windows.Forms.PictureBox();
            this.txtRecherchePatient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListe
            // 
            this.dtgvListe.AllowUserToAddRows = false;
            this.dtgvListe.AllowUserToOrderColumns = true;
            this.dtgvListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListe.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListe.ColumnHeadersHeight = 30;
            this.dtgvListe.Location = new System.Drawing.Point(26, 73);
            this.dtgvListe.MultiSelect = false;
            this.dtgvListe.Name = "dtgvListe";
            this.dtgvListe.ReadOnly = true;
            this.dtgvListe.RowHeadersVisible = false;
            this.dtgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListe.Size = new System.Drawing.Size(759, 360);
            this.dtgvListe.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnFiltreParDate);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnRecherche);
            this.panel1.Controls.Add(this.txtRecherchePatient);
            this.panel1.Controls.Add(this.dtgvListe);
            this.panel1.Location = new System.Drawing.Point(30, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 500);
            this.panel1.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(26, 38);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(129, 31);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Nouveau";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnFiltreParDate
            // 
            this.btnFiltreParDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltreParDate.BackColor = System.Drawing.Color.Gray;
            this.btnFiltreParDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreParDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltreParDate.ForeColor = System.Drawing.Color.White;
            this.btnFiltreParDate.Location = new System.Drawing.Point(528, 12);
            this.btnFiltreParDate.Name = "btnFiltreParDate";
            this.btnFiltreParDate.Size = new System.Drawing.Size(52, 29);
            this.btnFiltreParDate.TabIndex = 13;
            this.btnFiltreParDate.Text = "OK";
            this.btnFiltreParDate.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(791, 73);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(129, 31);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(284, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(220, 22);
            this.dtpDate.TabIndex = 10;
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
            // PrestationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.panel1);
            this.Name = "PrestationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PrestationForm";
            this.Load += new System.EventHandler(this.PrestationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecherche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltreParDate;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.PictureBox btnRecherche;
        private System.Windows.Forms.TextBox txtRecherchePatient;
        private System.Windows.Forms.Button btnAjouter;
    }
}