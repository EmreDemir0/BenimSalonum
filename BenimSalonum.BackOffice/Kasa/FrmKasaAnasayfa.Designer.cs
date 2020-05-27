namespace BenimSalonum.BackOffice.Kasa
{
    partial class FrmKasaAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaAnasayfa));
            this.picBoxAcik = new System.Windows.Forms.PictureBox();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KasaGridView = new DevExpress.XtraGrid.Views.Card.CardView();
            this.KasaGridControl = new DevExpress.XtraGrid.GridControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnCariFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.ımageListKasa = new System.Windows.Forms.ImageList(this.components);
            this.btnCariFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.KasaFilterControl = new DevExpress.XtraEditors.FilterControl();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasaHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.contextMenuKasa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHareket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.contextMenuKasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxAcik
            // 
            this.picBoxAcik.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAcik.Image")));
            this.picBoxAcik.Location = new System.Drawing.Point(56, 4);
            this.picBoxAcik.Name = "picBoxAcik";
            this.picBoxAcik.Size = new System.Drawing.Size(40, 40);
            this.picBoxAcik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAcik.TabIndex = 30;
            this.picBoxAcik.TabStop = false;
            this.picBoxAcik.Click += new System.EventHandler(this.picBoxAcik_Click);
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 8;
            this.colBakiye.Width = 113;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.DisplayFormat.FormatString = "C2";
            this.colKasaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 7;
            this.colKasaCikis.Width = 146;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 6;
            this.colKasaGiris.Width = 148;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 237;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 4;
            this.colYetkiliAdi.Width = 137;
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.Visible = true;
            this.colYetkiliKodu.VisibleIndex = 3;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.Visible = true;
            this.colKasaAdi.VisibleIndex = 2;
            this.colKasaAdi.Width = 156;
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.Caption = "Kasa Kodu";
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.Visible = true;
            this.colKasaKodu.VisibleIndex = 1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 45;
            // 
            // KasaGridView
            // 
            this.KasaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.KasaGridView.GridControl = this.KasaGridControl;
            this.KasaGridView.Name = "KasaGridView";
            this.KasaGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // KasaGridControl
            // 
            this.KasaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KasaGridControl.Location = new System.Drawing.Point(0, 0);
            this.KasaGridControl.MainView = this.KasaGridView;
            this.KasaGridControl.Name = "KasaGridControl";
            this.KasaGridControl.Size = new System.Drawing.Size(1364, 499);
            this.KasaGridControl.TabIndex = 3;
            this.KasaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KasaGridView});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.KasaFilterControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.KasaGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1364, 615);
            this.splitContainerControl1.SplitterPosition = 106;
            this.splitContainerControl1.TabIndex = 29;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnCariFiltreIptal
            // 
            this.btnCariFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltreIptal.ImageOptions.ImageIndex = 3;
            this.btnCariFiltreIptal.ImageOptions.ImageList = this.ımageListKasa;
            this.btnCariFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltreIptal.Location = new System.Drawing.Point(1320, 3);
            this.btnCariFiltreIptal.Name = "btnCariFiltreIptal";
            this.btnCariFiltreIptal.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltreIptal.TabIndex = 9;
            this.btnCariFiltreIptal.Click += new System.EventHandler(this.btnCariFiltreIptal_Click);
            // 
            // ımageListKasa
            // 
            this.ımageListKasa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKasa.ImageStream")));
            this.ımageListKasa.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListKasa.Images.SetKeyName(0, "add.png");
            this.ımageListKasa.Images.SetKeyName(1, "delete.png");
            this.ımageListKasa.Images.SetKeyName(2, "funnel.png");
            this.ımageListKasa.Images.SetKeyName(3, "funnel_delete.png");
            this.ımageListKasa.Images.SetKeyName(4, "KasaDuzenle.png");
            this.ımageListKasa.Images.SetKeyName(5, "KasaEkle.png");
            this.ımageListKasa.Images.SetKeyName(6, "KasaHareket.png");
            this.ımageListKasa.Images.SetKeyName(7, "KasaSil.png");
            this.ımageListKasa.Images.SetKeyName(8, "pencil.png");
            this.ımageListKasa.Images.SetKeyName(9, "refresh.png");
            this.ımageListKasa.Images.SetKeyName(10, "replace2.png");
            this.ımageListKasa.Images.SetKeyName(11, "safe.png");
            this.ımageListKasa.Images.SetKeyName(12, "view.png");
            this.ımageListKasa.Images.SetKeyName(13, "folder_out.png");
            // 
            // btnCariFiltre
            // 
            this.btnCariFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltre.ImageOptions.ImageIndex = 2;
            this.btnCariFiltre.ImageOptions.ImageList = this.ımageListKasa;
            this.btnCariFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltre.Location = new System.Drawing.Point(1277, 3);
            this.btnCariFiltre.Name = "btnCariFiltre";
            this.btnCariFiltre.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltre.TabIndex = 10;
            this.btnCariFiltre.Click += new System.EventHandler(this.btnCariFiltre_Click);
            // 
            // KasaFilterControl
            // 
            this.KasaFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.KasaFilterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KasaFilterControl.Location = new System.Drawing.Point(0, 0);
            this.KasaFilterControl.Name = "KasaFilterControl";
            this.KasaFilterControl.Size = new System.Drawing.Size(1364, 106);
            this.KasaFilterControl.SortFilterColumns = false;
            this.KasaFilterControl.SourceControl = this.KasaGridControl;
            this.KasaFilterControl.TabIndex = 2;
            this.KasaFilterControl.Text = "KasaFilterControl";
            this.KasaFilterControl.FilterChanged += new DevExpress.XtraEditors.FilterChangedEventHandler(this.KasaFilterControl_FilterChanged);
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
            this.LblBaslik.TabIndex = 27;
            this.LblBaslik.Text = "KASALAR";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 40);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Ekle";
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
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 5;
            this.btnEkle.ImageOptions.ImageList = this.ımageListKasa;
            this.btnEkle.Location = new System.Drawing.Point(12, 26);
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
            this.btnKapat.ImageOptions.ImageIndex = 13;
            this.btnKapat.ImageOptions.ImageList = this.ımageListKasa;
            this.btnKapat.Location = new System.Drawing.Point(1246, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 12;
            this.btnAra.ImageOptions.ImageList = this.ımageListKasa;
            this.btnAra.Location = new System.Drawing.Point(567, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAra.Size = new System.Drawing.Size(109, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKasaHareket
            // 
            this.btnKasaHareket.ImageOptions.ImageIndex = 6;
            this.btnKasaHareket.ImageOptions.ImageList = this.ımageListKasa;
            this.btnKasaHareket.Location = new System.Drawing.Point(337, 26);
            this.btnKasaHareket.Name = "btnKasaHareket";
            this.btnKasaHareket.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKasaHareket.Size = new System.Drawing.Size(109, 40);
            this.btnKasaHareket.TabIndex = 2;
            this.btnKasaHareket.Text = "Kasa\r\nHareket";
            this.btnKasaHareket.Click += new System.EventHandler(this.btnKasaHareket_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 9;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageListKasa;
            this.btnGuncelle.Location = new System.Drawing.Point(452, 26);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 7;
            this.btnSil.ImageOptions.ImageList = this.ımageListKasa;
            this.btnSil.Location = new System.Drawing.Point(222, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 4;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageListKasa;
            this.btnDuzenle.Location = new System.Drawing.Point(117, 26);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDuzenle.Size = new System.Drawing.Size(99, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDuzenle);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnAra);
            this.groupControl2.Controls.Add(this.btnKasaHareket);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1360, 69);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Buton Menü";
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
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "groupControl1";
            // 
            // contextMenuKasa
            // 
            this.contextMenuKasa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEkle,
            this.toolStripMenuItemDuzenle,
            this.toolStripMenuItemSil,
            this.toolStripMenuItemHareket,
            this.toolStripMenuItemGuncelle});
            this.contextMenuKasa.Name = "contextMenuStrip1";
            this.contextMenuKasa.Size = new System.Drawing.Size(148, 114);
            // 
            // toolStripMenuItemEkle
            // 
            this.toolStripMenuItemEkle.Name = "toolStripMenuItemEkle";
            this.toolStripMenuItemEkle.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemEkle.Text = "Yeni Kasa Ekle";
            this.toolStripMenuItemEkle.Click += new System.EventHandler(this.toolStripMenuItemEkle_Click);
            // 
            // toolStripMenuItemDuzenle
            // 
            this.toolStripMenuItemDuzenle.Name = "toolStripMenuItemDuzenle";
            this.toolStripMenuItemDuzenle.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemDuzenle.Text = "Düzenle";
            this.toolStripMenuItemDuzenle.Click += new System.EventHandler(this.toolStripMenuItemDuzenle_Click);
            // 
            // toolStripMenuItemSil
            // 
            this.toolStripMenuItemSil.Name = "toolStripMenuItemSil";
            this.toolStripMenuItemSil.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemSil.Text = "Sil";
            this.toolStripMenuItemSil.Click += new System.EventHandler(this.toolStripMenuItemSil_Click);
            // 
            // toolStripMenuItemHareket
            // 
            this.toolStripMenuItemHareket.Name = "toolStripMenuItemHareket";
            this.toolStripMenuItemHareket.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemHareket.Text = "Kasa Hareket";
            this.toolStripMenuItemHareket.Click += new System.EventHandler(this.toolStripMenuItemHareket_Click);
            // 
            // toolStripMenuItemGuncelle
            // 
            this.toolStripMenuItemGuncelle.Name = "toolStripMenuItemGuncelle";
            this.toolStripMenuItemGuncelle.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemGuncelle.Text = "Güncelle";
            this.toolStripMenuItemGuncelle.Click += new System.EventHandler(this.toolStripMenuItemGuncelle_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dropDownButton1.ImageOptions.SvgImage")));
            this.dropDownButton1.Location = new System.Drawing.Point(1314, 7);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.dropDownButton1.Size = new System.Drawing.Size(50, 40);
            this.dropDownButton1.TabIndex = 31;
            // 
            // FrmKasaAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.ContextMenuStrip = this.contextMenuKasa;
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.picBoxAcik);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.LblBaslik);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmKasaAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasalar Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKasaAnasayfa_FormClosing);
            this.Load += new System.EventHandler(this.FrmKasaAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.contextMenuKasa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAcik;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Views.Card.CardView KasaGridView;
        private DevExpress.XtraGrid.GridControl KasaGridControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltreIptal;
        private System.Windows.Forms.ImageList ımageListKasa;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltre;
        private DevExpress.XtraEditors.FilterControl KasaFilterControl;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnKasaHareket;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuKasa;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDuzenle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHareket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuncelle;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}