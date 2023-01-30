namespace Clinique_221.Views
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPrestation = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnRdv = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitreBar = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.lblCompte = new System.Windows.Forms.Label();
            this.lblTitrePage = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitreBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnPrestation);
            this.pnlMenu.Controls.Add(this.btnConsultation);
            this.pnlMenu.Controls.Add(this.btnPatient);
            this.pnlMenu.Controls.Add(this.btnRdv);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 633);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnPrestation
            // 
            this.btnPrestation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestation.FlatAppearance.BorderSize = 0;
            this.btnPrestation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestation.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrestation.Image = ((System.Drawing.Image)(resources.GetObject("btnPrestation.Image")));
            this.btnPrestation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestation.Location = new System.Drawing.Point(0, 260);
            this.btnPrestation.Name = "btnPrestation";
            this.btnPrestation.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPrestation.Size = new System.Drawing.Size(220, 60);
            this.btnPrestation.TabIndex = 5;
            this.btnPrestation.Text = "       Prestations";
            this.btnPrestation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrestation.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            this.btnConsultation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultation.FlatAppearance.BorderSize = 0;
            this.btnConsultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultation.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsultation.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultation.Image")));
            this.btnConsultation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultation.Location = new System.Drawing.Point(0, 200);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnConsultation.Size = new System.Drawing.Size(220, 60);
            this.btnConsultation.TabIndex = 4;
            this.btnConsultation.Text = "       Consultations";
            this.btnConsultation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnPatient
            // 
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(0, 140);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPatient.Size = new System.Drawing.Size(220, 60);
            this.btnPatient.TabIndex = 3;
            this.btnPatient.Text = "       Patients";
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRdv
            // 
            this.btnRdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRdv.FlatAppearance.BorderSize = 0;
            this.btnRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdv.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRdv.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRdv.Image = ((System.Drawing.Image)(resources.GetObject("btnRdv.Image")));
            this.btnRdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRdv.Location = new System.Drawing.Point(0, 80);
            this.btnRdv.Name = "btnRdv";
            this.btnRdv.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRdv.Size = new System.Drawing.Size(220, 60);
            this.btnRdv.TabIndex = 2;
            this.btnRdv.Text = "       Rendez-vous";
            this.btnRdv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRdv.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 80);
            this.pnlLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLINIQUE 221";
            // 
            // pnlTitreBar
            // 
            this.pnlTitreBar.BackColor = System.Drawing.Color.White;
            this.pnlTitreBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitreBar.Controls.Add(this.btnDeconnexion);
            this.pnlTitreBar.Controls.Add(this.lblCompte);
            this.pnlTitreBar.Controls.Add(this.lblTitrePage);
            this.pnlTitreBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitreBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitreBar.Name = "pnlTitreBar";
            this.pnlTitreBar.Size = new System.Drawing.Size(1004, 80);
            this.pnlTitreBar.TabIndex = 1;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeconnexion.BackColor = System.Drawing.Color.Red;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.Location = new System.Drawing.Point(870, 0);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(129, 31);
            this.btnDeconnexion.TabIndex = 13;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            // 
            // lblCompte
            // 
            this.lblCompte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCompte.Location = new System.Drawing.Point(-4, 0);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(198, 23);
            this.lblCompte.TabIndex = 1;
            this.lblCompte.Text = "Compte(Roly Spen)";
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitrePage.AutoSize = true;
            this.lblTitrePage.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitrePage.Location = new System.Drawing.Point(-7, 46);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(238, 33);
            this.lblTitrePage.TabIndex = 0;
            this.lblTitrePage.Text = "Nom de la  Page";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1224, 633);
            this.Controls.Add(this.pnlTitreBar);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitreBar.ResumeLayout(false);
            this.pnlTitreBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnRdv;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnPrestation;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Panel pnlTitreBar;
        private System.Windows.Forms.Label lblTitrePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}