namespace BenimSalonum.BackOffice.Depo
{
    partial class FrmDepoAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoAnasayfa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageListDepo = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepoHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnCariFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.DepoFilterControl = new DevExpress.XtraEditors.FilterControl();
            this.DepoGridControl = new DevExpress.XtraGrid.GridControl();
            this.DepoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnCariFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.picBoxAcik = new System.Windows.Forms.PictureBox();
            this.contextMenuDepo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHareket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).BeginInit();
            this.contextMenuDepo.SuspendLayout();
            this.SuspendLayout();
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
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDuzenle);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnAra);
            this.groupControl2.Controls.Add(this.btnDepoHareket);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1360, 69);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Buton Menü";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 3;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageListDepo;
            this.btnDuzenle.Location = new System.Drawing.Point(117, 26);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDuzenle.Size = new System.Drawing.Size(99, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // ımageListDepo
            // 
            this.ımageListDepo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListDepo.ImageStream")));
            this.ımageListDepo.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListDepo.Images.SetKeyName(0, "add.png");
            this.ımageListDepo.Images.SetKeyName(1, "bilgi.png");
            this.ımageListDepo.Images.SetKeyName(2, "delete.png");
            this.ımageListDepo.Images.SetKeyName(3, "düzenle.png");
            this.ımageListDepo.Images.SetKeyName(4, "ekle.png");
            this.ımageListDepo.Images.SetKeyName(5, "factory.png");
            this.ımageListDepo.Images.SetKeyName(6, "folder_out.png");
            this.ımageListDepo.Images.SetKeyName(7, "funnel.png");
            this.ımageListDepo.Images.SetKeyName(8, "funnel_delete.png");
            this.ımageListDepo.Images.SetKeyName(9, "hareket.png");
            this.ımageListDepo.Images.SetKeyName(10, "information.png");
            this.ımageListDepo.Images.SetKeyName(11, "pencil.png");
            this.ımageListDepo.Images.SetKeyName(12, "refresh.png");
            this.ımageListDepo.Images.SetKeyName(13, "replace2.png");
            this.ımageListDepo.Images.SetKeyName(14, "sil.png");
            this.ımageListDepo.Images.SetKeyName(15, "view.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 4;
            this.btnEkle.ImageOptions.ImageList = this.ımageListDepo;
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
            this.btnKapat.ImageOptions.ImageIndex = 6;
            this.btnKapat.ImageOptions.ImageList = this.ımageListDepo;
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
            this.btnAra.ImageOptions.ImageIndex = 15;
            this.btnAra.ImageOptions.ImageList = this.ımageListDepo;
            this.btnAra.Location = new System.Drawing.Point(567, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAra.Size = new System.Drawing.Size(109, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnDepoHareket
            // 
            this.btnDepoHareket.ImageOptions.ImageIndex = 9;
            this.btnDepoHareket.ImageOptions.ImageList = this.ımageListDepo;
            this.btnDepoHareket.Location = new System.Drawing.Point(337, 26);
            this.btnDepoHareket.Name = "btnDepoHareket";
            this.btnDepoHareket.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDepoHareket.Size = new System.Drawing.Size(109, 40);
            this.btnDepoHareket.TabIndex = 2;
            this.btnDepoHareket.Text = "Depo\r\nHareket";
            this.btnDepoHareket.Click += new System.EventHandler(this.btnDepoHareket_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 13;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageListDepo;
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
            this.btnSil.ImageOptions.ImageIndex = 14;
            this.btnSil.ImageOptions.ImageList = this.ımageListDepo;
            this.btnSil.Location = new System.Drawing.Point(222, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.LblBaslik.TabIndex = 31;
            this.LblBaslik.Text = "DEPOLAR";
            // 
            // btnCariFiltre
            // 
            this.btnCariFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltre.ImageOptions.ImageIndex = 7;
            this.btnCariFiltre.ImageOptions.ImageList = this.ımageListDepo;
            this.btnCariFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltre.Location = new System.Drawing.Point(1281, 3);
            this.btnCariFiltre.Name = "btnCariFiltre";
            this.btnCariFiltre.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltre.TabIndex = 10;
            this.btnCariFiltre.Click += new System.EventHandler(this.btnCariFiltre_Click);
            // 
            // DepoFilterControl
            // 
            this.DepoFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DepoFilterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepoFilterControl.Location = new System.Drawing.Point(0, 0);
            this.DepoFilterControl.Name = "DepoFilterControl";
            this.DepoFilterControl.Size = new System.Drawing.Size(1364, 138);
            this.DepoFilterControl.SourceControl = this.DepoGridControl;
            this.DepoFilterControl.TabIndex = 2;
            this.DepoFilterControl.Text = "DepoFilterControl";
            this.DepoFilterControl.FilterChanged += new DevExpress.XtraEditors.FilterChangedEventHandler(this.DepoFilterControl_FilterChanged);
            // 
            // DepoGridControl
            // 
            this.DepoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepoGridControl.Location = new System.Drawing.Point(0, 0);
            this.DepoGridControl.MainView = this.DepoGridView;
            this.DepoGridControl.Name = "DepoGridControl";
            this.DepoGridControl.Size = new System.Drawing.Size(1364, 538);
            this.DepoGridControl.TabIndex = 3;
            this.DepoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DepoGridView});
            // 
            // DepoGridView
            // 
            this.DepoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colTelefon,
            this.colAciklama});
            this.DepoGridView.GridControl = this.DepoGridControl;
            this.DepoGridView.Name = "DepoGridView";
            this.DepoGridView.RowCountChanged += new System.EventHandler(this.DepoGridView_RowCountChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 0;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 1;
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.Visible = true;
            this.colYetkiliKodu.VisibleIndex = 2;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 3;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 4;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 5;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 6;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 7;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 8;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.DepoFilterControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dropDownButton1);
            this.splitContainerControl1.Panel2.Controls.Add(this.DepoGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1364, 686);
            this.splitContainerControl1.SplitterPosition = 138;
            this.splitContainerControl1.TabIndex = 33;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnCariFiltreIptal
            // 
            this.btnCariFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltreIptal.ImageOptions.ImageIndex = 8;
            this.btnCariFiltreIptal.ImageOptions.ImageList = this.ımageListDepo;
            this.btnCariFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltreIptal.Location = new System.Drawing.Point(1324, 3);
            this.btnCariFiltreIptal.Name = "btnCariFiltreIptal";
            this.btnCariFiltreIptal.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltreIptal.TabIndex = 9;
            this.btnCariFiltreIptal.Click += new System.EventHandler(this.btnCariFiltreIptal_Click);
            // 
            // picBoxAcik
            // 
            this.picBoxAcik.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAcik.Image")));
            this.picBoxAcik.Location = new System.Drawing.Point(56, 4);
            this.picBoxAcik.Name = "picBoxAcik";
            this.picBoxAcik.Size = new System.Drawing.Size(40, 40);
            this.picBoxAcik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAcik.TabIndex = 34;
            this.picBoxAcik.TabStop = false;
            this.picBoxAcik.Click += new System.EventHandler(this.picBoxAcik_Click);
            // 
            // contextMenuDepo
            // 
            this.contextMenuDepo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEkle,
            this.toolStripMenuItemDuzenle,
            this.toolStripMenuItemSil,
            this.toolStripMenuItemHareket,
            this.toolStripMenuItemGuncelle});
            this.contextMenuDepo.Name = "contextMenuStrip1";
            this.contextMenuDepo.Size = new System.Drawing.Size(152, 114);
            // 
            // toolStripMenuItemEkle
            // 
            this.toolStripMenuItemEkle.Name = "toolStripMenuItemEkle";
            this.toolStripMenuItemEkle.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemEkle.Text = "Yeni Depo Ekle";
            this.toolStripMenuItemEkle.Click += new System.EventHandler(this.toolStripMenuItemEkle_Click);
            // 
            // toolStripMenuItemDuzenle
            // 
            this.toolStripMenuItemDuzenle.Name = "toolStripMenuItemDuzenle";
            this.toolStripMenuItemDuzenle.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemDuzenle.Text = "Düzenle";
            this.toolStripMenuItemDuzenle.Click += new System.EventHandler(this.toolStripMenuItemDuzenle_Click);
            // 
            // toolStripMenuItemSil
            // 
            this.toolStripMenuItemSil.Name = "toolStripMenuItemSil";
            this.toolStripMenuItemSil.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemSil.Text = "Sil";
            this.toolStripMenuItemSil.Click += new System.EventHandler(this.toolStripMenuItemSil_Click);
            // 
            // toolStripMenuItemHareket
            // 
            this.toolStripMenuItemHareket.Name = "toolStripMenuItemHareket";
            this.toolStripMenuItemHareket.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemHareket.Text = "Depo Hareket";
            this.toolStripMenuItemHareket.Click += new System.EventHandler(this.toolStripMenuItemHareket_Click);
            // 
            // toolStripMenuItemGuncelle
            // 
            this.toolStripMenuItemGuncelle.Name = "toolStripMenuItemGuncelle";
            this.toolStripMenuItemGuncelle.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemGuncelle.Text = "Güncelle";
            this.toolStripMenuItemGuncelle.Click += new System.EventHandler(this.toolStripMenuItemGuncelle_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dropDownButton1.ImageOptions.SvgImage")));
            this.dropDownButton1.Location = new System.Drawing.Point(1281, 2);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.dropDownButton1.Size = new System.Drawing.Size(54, 30);
            this.dropDownButton1.TabIndex = 31;
            // 
            // FrmDepoAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.ContextMenuStrip = this.contextMenuDepo;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.picBoxAcik);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmDepoAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo İşlemleri Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDepoAnasayfa_FormClosing);
            this.Load += new System.EventHandler(this.FrmDepoAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DepoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).EndInit();
            this.contextMenuDepo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private System.Windows.Forms.ImageList ımageListDepo;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnDepoHareket;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltre;
        private DevExpress.XtraEditors.FilterControl DepoFilterControl;
        private DevExpress.XtraGrid.GridControl DepoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DepoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltreIptal;
        private System.Windows.Forms.PictureBox picBoxAcik;
        private System.Windows.Forms.ContextMenuStrip contextMenuDepo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDuzenle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHareket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuncelle;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}