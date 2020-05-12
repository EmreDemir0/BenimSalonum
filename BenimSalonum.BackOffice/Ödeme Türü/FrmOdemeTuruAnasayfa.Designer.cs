namespace BenimSalonum.BackOffice.Ödeme_Türü
{
    partial class FrmOdemeTuruAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuruAnasayfa));
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageListOdemeTuru = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeTuruHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeTurleriGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeTurleriGridControl = new DevExpress.XtraGrid.GridControl();
            this.btnOdemeTuruFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.OdemeTuruFilterControl = new DevExpress.XtraEditors.FilterControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnOdemeTuruFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.picBoxAcik = new System.Windows.Forms.PictureBox();
            this.contextMenuOdemeTuru = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHareket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeTurleriGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeTurleriGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).BeginInit();
            this.contextMenuOdemeTuru.SuspendLayout();
            this.SuspendLayout();
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
            this.LblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LblBaslik.ImageOptions.Image")));
            this.LblBaslik.Location = new System.Drawing.Point(0, 0);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(1364, 50);
            this.LblBaslik.TabIndex = 35;
            this.LblBaslik.Text = "ÖDEME TÜRLERİ";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 5;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnDuzenle.Location = new System.Drawing.Point(117, 26);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDuzenle.Size = new System.Drawing.Size(99, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // ımageListOdemeTuru
            // 
            this.ımageListOdemeTuru.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListOdemeTuru.ImageStream")));
            this.ımageListOdemeTuru.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListOdemeTuru.Images.SetKeyName(0, "Hareketler.png");
            this.ımageListOdemeTuru.Images.SetKeyName(1, "replace2.png");
            this.ımageListOdemeTuru.Images.SetKeyName(2, "wallet_closed.png");
            this.ımageListOdemeTuru.Images.SetKeyName(3, "wallet_closed_add.png");
            this.ımageListOdemeTuru.Images.SetKeyName(4, "wallet_closed_delete.png");
            this.ımageListOdemeTuru.Images.SetKeyName(5, "wallet_closed_edit.png");
            this.ımageListOdemeTuru.Images.SetKeyName(6, "funnel.png");
            this.ımageListOdemeTuru.Images.SetKeyName(7, "funnel_delete.png");
            this.ımageListOdemeTuru.Images.SetKeyName(8, "view.png");
            this.ımageListOdemeTuru.Images.SetKeyName(9, "folder_out.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 3;
            this.btnEkle.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnEkle.Location = new System.Drawing.Point(12, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkle.Size = new System.Drawing.Size(99, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 9;
            this.btnKapat.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnKapat.Location = new System.Drawing.Point(1246, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 8;
            this.btnAra.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnAra.Location = new System.Drawing.Point(567, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAra.Size = new System.Drawing.Size(109, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // btnOdemeTuruHareket
            // 
            this.btnOdemeTuruHareket.ImageOptions.ImageIndex = 0;
            this.btnOdemeTuruHareket.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnOdemeTuruHareket.Location = new System.Drawing.Point(337, 26);
            this.btnOdemeTuruHareket.Name = "btnOdemeTuruHareket";
            this.btnOdemeTuruHareket.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOdemeTuruHareket.Size = new System.Drawing.Size(109, 40);
            this.btnOdemeTuruHareket.TabIndex = 2;
            this.btnOdemeTuruHareket.Text = "Ödeme Türleri \nHareket";
            this.btnOdemeTuruHareket.Click += new System.EventHandler(this.BtnOdemeTuruHareket_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnGuncelle.Location = new System.Drawing.Point(452, 26);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnSil.Location = new System.Drawing.Point(222, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDuzenle);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnAra);
            this.groupControl2.Controls.Add(this.btnOdemeTuruHareket);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1360, 69);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Buton Menü";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(292, 23);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 40);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Kopyala";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(102, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(84, 40);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Düzenle";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 40);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Ekle";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(192, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(94, 40);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Sil";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 665);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1364, 71);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = "groupControl1";
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 5;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 3;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü Adı";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.Caption = "Ödeme Türü Kodu";
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // OdemeTurleriGridView
            // 
            this.OdemeTurleriGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colAciklama,
            this.colBakiye,
            this.colKasaGiris,
            this.colKasaCikis});
            this.OdemeTurleriGridView.GridControl = this.OdemeTurleriGridControl;
            this.OdemeTurleriGridView.Name = "OdemeTurleriGridView";
            this.OdemeTurleriGridView.RowCountChanged += new System.EventHandler(this.OdemeTuruGridView_RowCountChanged);
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 4;
            // 
            // OdemeTurleriGridControl
            // 
            this.OdemeTurleriGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OdemeTurleriGridControl.Location = new System.Drawing.Point(0, 0);
            this.OdemeTurleriGridControl.MainView = this.OdemeTurleriGridView;
            this.OdemeTurleriGridControl.Name = "OdemeTurleriGridControl";
            this.OdemeTurleriGridControl.Size = new System.Drawing.Size(1364, 557);
            this.OdemeTurleriGridControl.TabIndex = 3;
            this.OdemeTurleriGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OdemeTurleriGridView});
            // 
            // btnOdemeTuruFiltre
            // 
            this.btnOdemeTuruFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeTuruFiltre.ImageOptions.ImageIndex = 6;
            this.btnOdemeTuruFiltre.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnOdemeTuruFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOdemeTuruFiltre.Location = new System.Drawing.Point(1277, 3);
            this.btnOdemeTuruFiltre.Name = "btnOdemeTuruFiltre";
            this.btnOdemeTuruFiltre.Size = new System.Drawing.Size(37, 36);
            this.btnOdemeTuruFiltre.TabIndex = 10;
            this.btnOdemeTuruFiltre.Click += new System.EventHandler(this.btnOdemeTuruFiltre_Click);
            // 
            // OdemeTuruFilterControl
            // 
            this.OdemeTuruFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OdemeTuruFilterControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.OdemeTuruFilterControl.Location = new System.Drawing.Point(0, 0);
            this.OdemeTuruFilterControl.Name = "OdemeTuruFilterControl";
            this.OdemeTuruFilterControl.Size = new System.Drawing.Size(1364, 119);
            this.OdemeTuruFilterControl.SortFilterColumns = false;
            this.OdemeTuruFilterControl.SourceControl = this.OdemeTurleriGridControl;
            this.OdemeTuruFilterControl.TabIndex = 2;
            this.OdemeTuruFilterControl.Text = "OdemeTuruFilterControl";
            this.OdemeTuruFilterControl.FilterChanged += new DevExpress.XtraEditors.FilterChangedEventHandler(this.OdemeTuruFilterControl_FilterChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnOdemeTuruFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnOdemeTuruFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.OdemeTuruFilterControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.OdemeTurleriGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1364, 686);
            this.splitContainerControl1.SplitterPosition = 119;
            this.splitContainerControl1.TabIndex = 37;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnOdemeTuruFiltreIptal
            // 
            this.btnOdemeTuruFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeTuruFiltreIptal.ImageOptions.ImageIndex = 7;
            this.btnOdemeTuruFiltreIptal.ImageOptions.ImageList = this.ımageListOdemeTuru;
            this.btnOdemeTuruFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOdemeTuruFiltreIptal.Location = new System.Drawing.Point(1320, 3);
            this.btnOdemeTuruFiltreIptal.Name = "btnOdemeTuruFiltreIptal";
            this.btnOdemeTuruFiltreIptal.Size = new System.Drawing.Size(37, 36);
            this.btnOdemeTuruFiltreIptal.TabIndex = 9;
            this.btnOdemeTuruFiltreIptal.Click += new System.EventHandler(this.btnOdemeTuruFiltreIptal_Click);
            // 
            // picBoxAcik
            // 
            this.picBoxAcik.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAcik.Image")));
            this.picBoxAcik.Location = new System.Drawing.Point(56, 4);
            this.picBoxAcik.Name = "picBoxAcik";
            this.picBoxAcik.Size = new System.Drawing.Size(40, 40);
            this.picBoxAcik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAcik.TabIndex = 38;
            this.picBoxAcik.TabStop = false;
            this.picBoxAcik.Click += new System.EventHandler(this.PicBoxAcik_Click);
            // 
            // contextMenuOdemeTuru
            // 
            this.contextMenuOdemeTuru.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEkle,
            this.toolStripMenuItemDuzenle,
            this.toolStripMenuItemSil,
            this.toolStripMenuItemHareket,
            this.toolStripMenuItemGuncelle});
            this.contextMenuOdemeTuru.Name = "contextMenuStrip1";
            this.contextMenuOdemeTuru.Size = new System.Drawing.Size(191, 136);
            // 
            // toolStripMenuItemEkle
            // 
            this.toolStripMenuItemEkle.Name = "toolStripMenuItemEkle";
            this.toolStripMenuItemEkle.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemEkle.Text = "Yeni Ödeme Türü Ekle";
            this.toolStripMenuItemEkle.Click += new System.EventHandler(this.toolStripMenuItemEkle_Click);
            // 
            // toolStripMenuItemDuzenle
            // 
            this.toolStripMenuItemDuzenle.Name = "toolStripMenuItemDuzenle";
            this.toolStripMenuItemDuzenle.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemDuzenle.Text = "Düzenle";
            this.toolStripMenuItemDuzenle.Click += new System.EventHandler(this.toolStripMenuItemDuzenle_Click);
            // 
            // toolStripMenuItemSil
            // 
            this.toolStripMenuItemSil.Name = "toolStripMenuItemSil";
            this.toolStripMenuItemSil.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemSil.Text = "Sil";
            this.toolStripMenuItemSil.Click += new System.EventHandler(this.toolStripMenuItemSil_Click);
            // 
            // toolStripMenuItemHareket
            // 
            this.toolStripMenuItemHareket.Name = "toolStripMenuItemHareket";
            this.toolStripMenuItemHareket.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemHareket.Text = "Ödeme Türü Hareket";
            this.toolStripMenuItemHareket.Click += new System.EventHandler(this.toolStripMenuItemHareket_Click);
            // 
            // toolStripMenuItemGuncelle
            // 
            this.toolStripMenuItemGuncelle.Name = "toolStripMenuItemGuncelle";
            this.toolStripMenuItemGuncelle.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemGuncelle.Text = "Güncelle";
            this.toolStripMenuItemGuncelle.Click += new System.EventHandler(this.toolStripMenuItemGuncelle_Click);
            // 
            // FrmOdemeTuruAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.ContextMenuStrip = this.contextMenuOdemeTuru;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.picBoxAcik);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmOdemeTuruAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Türleri Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOdemeTuruAnasayfa_FormClosing);
            this.Load += new System.EventHandler(this.FrmOdemeTuruAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OdemeTurleriGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeTurleriGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).EndInit();
            this.contextMenuOdemeTuru.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private System.Windows.Forms.ImageList ımageListOdemeTuru;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnOdemeTuruHareket;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Views.Grid.GridView OdemeTurleriGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.GridControl OdemeTurleriGridControl;
        private DevExpress.XtraEditors.SimpleButton btnOdemeTuruFiltre;
        private DevExpress.XtraEditors.FilterControl OdemeTuruFilterControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnOdemeTuruFiltreIptal;
        private System.Windows.Forms.PictureBox picBoxAcik;
        private System.Windows.Forms.ContextMenuStrip contextMenuOdemeTuru;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDuzenle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHareket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuncelle;
    }
}