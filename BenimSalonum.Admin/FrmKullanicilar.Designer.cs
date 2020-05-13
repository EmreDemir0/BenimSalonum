namespace BenimSalonum.Admin
{
    partial class FrmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanicilar));
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenuCari = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridControlKullanici = new DevExpress.XtraGrid.GridControl();
            this.GridViewKullanici = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHatirlatmaSorusu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHatirlatmaCevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 4;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenuCari;
            this.btnDuzenle.Location = new System.Drawing.Point(117, 25);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDuzenle.Size = new System.Drawing.Size(99, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // imgMenuCari
            // 
            this.imgMenuCari.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenuCari.ImageStream")));
            this.imgMenuCari.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenuCari.Images.SetKeyName(0, "folder_out.png");
            this.imgMenuCari.Images.SetKeyName(1, "id_card.png");
            this.imgMenuCari.Images.SetKeyName(2, "id_card_add.png");
            this.imgMenuCari.Images.SetKeyName(3, "id_card_delete.png");
            this.imgMenuCari.Images.SetKeyName(4, "id_card_edit.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 2;
            this.btnEkle.ImageOptions.ImageList = this.imgMenuCari;
            this.btnEkle.Location = new System.Drawing.Point(12, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkle.Size = new System.Drawing.Size(99, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.imgMenuCari;
            this.btnKapat.Location = new System.Drawing.Point(664, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 3;
            this.btnSil.ImageOptions.ImageList = this.imgMenuCari;
            this.btnSil.Location = new System.Drawing.Point(222, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDuzenle);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 439);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(778, 69);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Buton Menü";
            // 
            // LblBaslik
            // 
            this.LblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.LblBaslik.ImageOptions.ImageIndex = 1;
            this.LblBaslik.ImageOptions.Images = this.imgMenuCari;
            this.LblBaslik.Location = new System.Drawing.Point(0, 0);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(778, 50);
            this.LblBaslik.TabIndex = 25;
            this.LblBaslik.Text = "KULLANICI YETKİLENDİRME";
            // 
            // GridControlKullanici
            // 
            this.GridControlKullanici.DataSource = this.kullaniciBindingSource;
            this.GridControlKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlKullanici.Location = new System.Drawing.Point(0, 50);
            this.GridControlKullanici.MainView = this.GridViewKullanici;
            this.GridControlKullanici.Name = "GridControlKullanici";
            this.GridControlKullanici.Size = new System.Drawing.Size(778, 389);
            this.GridControlKullanici.TabIndex = 27;
            this.GridControlKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewKullanici});
            // 
            // GridViewKullanici
            // 
            this.GridViewKullanici.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAktif,
            this.colDurumu,
            this.colKullaniciAdi,
            this.colAdi,
            this.colSoyadi,
            this.colGorevi,
            this.colParola,
            this.colHatirlatmaSorusu,
            this.colHatirlatmaCevap,
            this.colKayitTarihi,
            this.colSonGirisTarihi});
            this.GridViewKullanici.GridControl = this.GridControlKullanici;
            this.GridViewKullanici.Name = "GridViewKullanici";
            this.GridViewKullanici.OptionsView.ColumnAutoWidth = false;
            // 
            // colId
            // 
            this.colId.FieldName = "KullaniciID";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colAktif
            // 
            this.colAktif.Caption = "Aktif";
            this.colAktif.FieldName = "Aktif";
            this.colAktif.Name = "colAktif";
            this.colAktif.Visible = true;
            this.colAktif.VisibleIndex = 1;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 2;
            // 
            // colAdi
            // 
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 3;
            // 
            // colSoyadi
            // 
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 4;
            // 
            // colGorevi
            // 
            this.colGorevi.FieldName = "Gorevi";
            this.colGorevi.Name = "colGorevi";
            this.colGorevi.OptionsColumn.AllowEdit = false;
            this.colGorevi.Visible = true;
            this.colGorevi.VisibleIndex = 5;
            // 
            // colParola
            // 
            this.colParola.FieldName = "Parola";
            this.colParola.Name = "colParola";
            this.colParola.OptionsColumn.AllowEdit = false;
            this.colParola.Visible = true;
            this.colParola.VisibleIndex = 6;
            // 
            // colHatirlatmaSorusu
            // 
            this.colHatirlatmaSorusu.FieldName = "HatirlatmaSorusu";
            this.colHatirlatmaSorusu.Name = "colHatirlatmaSorusu";
            this.colHatirlatmaSorusu.OptionsColumn.AllowEdit = false;
            this.colHatirlatmaSorusu.Visible = true;
            this.colHatirlatmaSorusu.VisibleIndex = 7;
            // 
            // colHatirlatmaCevap
            // 
            this.colHatirlatmaCevap.FieldName = "HatirlatmaCevap";
            this.colHatirlatmaCevap.Name = "colHatirlatmaCevap";
            this.colHatirlatmaCevap.OptionsColumn.AllowEdit = false;
            this.colHatirlatmaCevap.Visible = true;
            this.colHatirlatmaCevap.VisibleIndex = 8;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 9;
            // 
            // colSonGirisTarihi
            // 
            this.colSonGirisTarihi.FieldName = "SonGirisTarihi";
            this.colSonGirisTarihi.Name = "colSonGirisTarihi";
            this.colSonGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colSonGirisTarihi.Visible = true;
            this.colSonGirisTarihi.VisibleIndex = 10;
            this.colSonGirisTarihi.Width = 71;
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 508);
            this.Controls.Add(this.GridControlKullanici);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.LblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yetkilendirme Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private System.Windows.Forms.ImageList imgMenuCari;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        public DevExpress.XtraGrid.GridControl GridControlKullanici;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewKullanici;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colHatirlatmaSorusu;
        private DevExpress.XtraGrid.Columns.GridColumn colHatirlatmaCevap;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAktif;
    }
}