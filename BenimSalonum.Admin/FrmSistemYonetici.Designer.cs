namespace BenimSalonum.Admin
{
    partial class FrmSistemYonetici
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
            this.brnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtSistemParola = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSistemParola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // brnCikis
            // 
            this.brnCikis.Location = new System.Drawing.Point(32, 63);
            this.brnCikis.Name = "brnCikis";
            this.brnCikis.Size = new System.Drawing.Size(75, 23);
            this.brnCikis.TabIndex = 2;
            this.brnCikis.Text = "Çıkış";
            this.brnCikis.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(32, 34);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş ";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSistemParola
            // 
            this.txtSistemParola.Location = new System.Drawing.Point(18, 8);
            this.txtSistemParola.Name = "txtSistemParola";
            this.txtSistemParola.Size = new System.Drawing.Size(100, 20);
            this.txtSistemParola.TabIndex = 0;
            // 
            // FrmSistemYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 98);
            this.ControlBox = false;
            this.Controls.Add(this.brnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSistemParola);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSistemYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtSistemParola.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton brnCikis;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.TextEdit txtSistemParola;
    }
}