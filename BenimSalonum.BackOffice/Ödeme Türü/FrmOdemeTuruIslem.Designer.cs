namespace BenimSalonum.BackOffice.Ödeme_Türü
{
    partial class FrmOdemeTuruIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuruIslem));
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupDiger2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.groupGenel = new DevExpress.XtraEditors.GroupControl();
            this.labelKullaniciID = new System.Windows.Forms.Label();
            this.txtOdemeTuruAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtOdemeTuruKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupDiger2)).BeginInit();
            this.groupDiger2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGenel)).BeginInit();
            this.groupGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
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
            this.LblBaslik.Size = new System.Drawing.Size(508, 60);
            this.LblBaslik.TabIndex = 47;
            this.LblBaslik.Text = "ÖDEME TÜRÜ İŞLEMLERİ";
            // 
            // groupDiger2
            // 
            this.groupDiger2.Controls.Add(this.labelControl21);
            this.groupDiger2.Controls.Add(this.txtAciklama);
            this.groupDiger2.Location = new System.Drawing.Point(5, 172);
            this.groupDiger2.Name = "groupDiger2";
            this.groupDiger2.Size = new System.Drawing.Size(500, 100);
            this.groupDiger2.TabIndex = 50;
            this.groupDiger2.Text = "Diğer Bilgiler - 1";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Options.UseTextOptions = true;
            this.labelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl21.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl21.Location = new System.Drawing.Point(7, 23);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(82, 72);
            this.labelControl21.TabIndex = 6;
            this.labelControl21.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(96, 26);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(396, 69);
            this.txtAciklama.TabIndex = 13;
            // 
            // groupGenel
            // 
            this.groupGenel.Controls.Add(this.labelKullaniciID);
            this.groupGenel.Controls.Add(this.txtOdemeTuruAdi);
            this.groupGenel.Controls.Add(this.txtOdemeTuruKodu);
            this.groupGenel.Controls.Add(this.labelControl7);
            this.groupGenel.Controls.Add(this.labelControl6);
            this.groupGenel.Location = new System.Drawing.Point(5, 66);
            this.groupGenel.Name = "groupGenel";
            this.groupGenel.Size = new System.Drawing.Size(500, 100);
            this.groupGenel.TabIndex = 48;
            this.groupGenel.Text = "Ödeme Bilgisi";
            this.groupGenel.Paint += new System.Windows.Forms.PaintEventHandler(this.groupGenel_Paint);
            // 
            // labelKullaniciID
            // 
            this.labelKullaniciID.AutoSize = true;
            this.labelKullaniciID.Location = new System.Drawing.Point(328, 41);
            this.labelKullaniciID.Name = "labelKullaniciID";
            this.labelKullaniciID.Size = new System.Drawing.Size(0, 13);
            this.labelKullaniciID.TabIndex = 25;
            this.labelKullaniciID.Visible = false;
            // 
            // txtOdemeTuruAdi
            // 
            this.txtOdemeTuruAdi.Location = new System.Drawing.Point(96, 63);
            this.txtOdemeTuruAdi.Name = "txtOdemeTuruAdi";
            this.txtOdemeTuruAdi.Size = new System.Drawing.Size(354, 20);
            this.txtOdemeTuruAdi.TabIndex = 19;
            // 
            // txtOdemeTuruKodu
            // 
            this.txtOdemeTuruKodu.Location = new System.Drawing.Point(96, 37);
            this.txtOdemeTuruKodu.Name = "txtOdemeTuruKodu";
            this.txtOdemeTuruKodu.Size = new System.Drawing.Size(200, 20);
            this.txtOdemeTuruKodu.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(8, 62);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 20);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Ödeme Adı :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(8, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 20);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Ödeme Kodu :";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKapat.Location = new System.Drawing.Point(387, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(282, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKaydet.Size = new System.Drawing.Size(99, 40);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 279);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(508, 69);
            this.groupControl2.TabIndex = 49;
            this.groupControl2.Text = " Menü";
            // 
            // FrmOdemeTuruIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 348);
            this.Controls.Add(this.LblBaslik);
            this.Controls.Add(this.groupDiger2);
            this.Controls.Add(this.groupGenel);
            this.Controls.Add(this.groupControl2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeTuruIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Türü Kayıt & Güncelleme";
            ((System.ComponentModel.ISupportInitialize)(this.groupDiger2)).EndInit();
            this.groupDiger2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGenel)).EndInit();
            this.groupGenel.ResumeLayout(false);
            this.groupGenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraEditors.GroupControl groupDiger2;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.GroupControl groupGenel;
        private DevExpress.XtraEditors.TextEdit txtOdemeTuruAdi;
        private DevExpress.XtraEditors.TextEdit txtOdemeTuruKodu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label labelKullaniciID;
    }
}