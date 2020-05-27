namespace BenimSalonum.Admin
{
    partial class FrmAdminMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMenu));
            this.btnKullanicilar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDonemOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevir = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.ImageOptions.ImageIndex = 0;
            this.btnKullanicilar.ImageOptions.ImageList = this.ımageList1;
            this.btnKullanicilar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKullanicilar.Location = new System.Drawing.Point(14, 12);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(200, 200);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Kullanıcılar";
            // 
            // btnDonemOlustur
            // 
            this.btnDonemOlustur.ImageOptions.ImageIndex = 1;
            this.btnDonemOlustur.ImageOptions.ImageList = this.ımageList1;
            this.btnDonemOlustur.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDonemOlustur.Location = new System.Drawing.Point(218, 12);
            this.btnDonemOlustur.Name = "btnDonemOlustur";
            this.btnDonemOlustur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDonemOlustur.Size = new System.Drawing.Size(200, 200);
            this.btnDonemOlustur.TabIndex = 1;
            this.btnDonemOlustur.Text = "Dönem Oluştur";
            // 
            // btnDevir
            // 
            this.btnDevir.ImageOptions.ImageIndex = 2;
            this.btnDevir.ImageOptions.ImageList = this.ımageList1;
            this.btnDevir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDevir.Location = new System.Drawing.Point(424, 12);
            this.btnDevir.Name = "btnDevir";
            this.btnDevir.Size = new System.Drawing.Size(200, 200);
            this.btnDevir.TabIndex = 2;
            this.btnDevir.Text = "Devir Sihirbazı";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "alagavatbahri.jpg");
            this.ımageList1.Images.SetKeyName(1, "hourglass.png");
            this.ımageList1.Images.SetKeyName(2, "Yedekleme.ico");
            // 
            // FrmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 228);
            this.Controls.Add(this.btnDevir);
            this.Controls.Add(this.btnDonemOlustur);
            this.Controls.Add(this.btnKullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKullanicilar;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnDonemOlustur;
        private DevExpress.XtraEditors.SimpleButton btnDevir;
    }
}