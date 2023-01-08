namespace Clinique_221.Views
{
    partial class ConnexionForm
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
            this.btnAjouterRdv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouterRdv
            // 
            this.btnAjouterRdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterRdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnAjouterRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterRdv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterRdv.ForeColor = System.Drawing.Color.White;
            this.btnAjouterRdv.Location = new System.Drawing.Point(308, 260);
            this.btnAjouterRdv.Name = "btnAjouterRdv";
            this.btnAjouterRdv.Size = new System.Drawing.Size(129, 31);
            this.btnAjouterRdv.TabIndex = 2;
            this.btnAjouterRdv.Text = "Nouveau";
            this.btnAjouterRdv.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code du Patient";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(282, 139);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(250, 20);
            this.txtCode.TabIndex = 3;
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnAjouterRdv);
            this.Name = "ConnexionForm";
            this.Text = "ConnexionForm";
            this.Load += new System.EventHandler(this.ConnexionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterRdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
    }
}