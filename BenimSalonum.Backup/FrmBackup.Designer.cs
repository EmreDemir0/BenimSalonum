namespace BenimSalonum.Backup
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.label1 = new System.Windows.Forms.Label();
            this.txtYedekKonum = new DevExpress.XtraEditors.ButtonEdit();
            this.btnGeriYukleme = new DevExpress.XtraEditors.SimpleButton();
            this.btnYedekleme = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtYedekKonum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Yedekleme Konumu :";
            // 
            // txtYedekKonum
            // 
            this.txtYedekKonum.Location = new System.Drawing.Point(124, 345);
            this.txtYedekKonum.Name = "txtYedekKonum";
            this.txtYedekKonum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYedekKonum.Size = new System.Drawing.Size(394, 20);
            this.txtYedekKonum.TabIndex = 58;
            this.txtYedekKonum.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtYedekKonum_ButtonClick);
            // 
            // btnGeriYukleme
            // 
            this.btnGeriYukleme.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeriYukleme.Appearance.Options.UseFont = true;
            this.btnGeriYukleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriYukleme.ImageOptions.Image")));
            this.btnGeriYukleme.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGeriYukleme.Location = new System.Drawing.Point(268, 89);
            this.btnGeriYukleme.Name = "btnGeriYukleme";
            this.btnGeriYukleme.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGeriYukleme.Size = new System.Drawing.Size(250, 250);
            this.btnGeriYukleme.TabIndex = 57;
            this.btnGeriYukleme.Text = "Geri Yükleme";
            this.btnGeriYukleme.Click += new System.EventHandler(this.btnGeriYukleme_Click);
            // 
            // btnYedekleme
            // 
            this.btnYedekleme.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnYedekleme.Appearance.Options.UseFont = true;
            this.btnYedekleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYedekleme.ImageOptions.Image")));
            this.btnYedekleme.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYedekleme.Location = new System.Drawing.Point(12, 89);
            this.btnYedekleme.Name = "btnYedekleme";
            this.btnYedekleme.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnYedekleme.Size = new System.Drawing.Size(250, 250);
            this.btnYedekleme.TabIndex = 56;
            this.btnYedekleme.Text = "Yedekleme";
            this.btnYedekleme.Click += new System.EventHandler(this.btnYedekleme_Click);
            // 
            // LblBaslik
            // 
            this.LblBaslik.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaslik.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("LblBaslik.Appearance.Image")));
            this.LblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBaslik.Appearance.Options.UseFont = true;
            this.LblBaslik.Appearance.Options.UseForeColor = true;
            this.LblBaslik.Appearance.Options.UseImage = true;
            this.LblBaslik.Appearance.Options.UseImageAlign = true;
            this.LblBaslik.Appearance.Options.UseTextOptions = true;
            this.LblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.LblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBaslik.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LblBaslik.ImageOptions.Image")));
            this.LblBaslik.Location = new System.Drawing.Point(0, 0);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(538, 60);
            this.LblBaslik.TabIndex = 55;
            this.LblBaslik.Text = "Yedekleme ve Geri Yükleme";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYedekKonum);
            this.Controls.Add(this.btnGeriYukleme);
            this.Controls.Add(this.btnYedekleme);
            this.Controls.Add(this.LblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Tabanı Yedekleme ve Geri Yükleme";
            ((System.ComponentModel.ISupportInitialize)(this.txtYedekKonum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit txtYedekKonum;
        private DevExpress.XtraEditors.SimpleButton btnGeriYukleme;
        private DevExpress.XtraEditors.SimpleButton btnYedekleme;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
    }
}

