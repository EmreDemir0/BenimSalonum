namespace BenimSalonum.BackOffice.İndirim
{
    partial class FrmIndirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndirim));
            this.btnDurumu = new DevExpress.XtraEditors.SimpleButton();
            this.ımageListIndirim = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.picBoxAcik = new System.Windows.Forms.PictureBox();
            this.btnCariFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnCariFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.IndirimFilterControl = new DevExpress.XtraEditors.FilterControl();
            this.IndirimGridControl = new DevExpress.XtraGrid.GridControl();
            this.IndirimGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIndirimAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBaslangic = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBitis = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuIndirim = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPasif = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndirimGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndirimGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBaslangic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBaslangic.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis.CalendarTimeProperties)).BeginInit();
            this.contextMenuIndirim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDurumu
            // 
            this.btnDurumu.ImageOptions.ImageIndex = 24;
            this.btnDurumu.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnDurumu.Location = new System.Drawing.Point(232, 24);
            this.btnDurumu.Name = "btnDurumu";
            this.btnDurumu.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDurumu.Size = new System.Drawing.Size(99, 40);
            this.btnDurumu.TabIndex = 1;
            this.btnDurumu.Text = "Pasif Yap";
            this.btnDurumu.Click += new System.EventHandler(this.btnDurumu_Click);
            // 
            // ımageListIndirim
            // 
            this.ımageListIndirim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListIndirim.ImageStream")));
            this.ımageListIndirim.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListIndirim.Images.SetKeyName(0, "add.png");
            this.ımageListIndirim.Images.SetKeyName(1, "delete.png");
            this.ımageListIndirim.Images.SetKeyName(2, "folder_out.png");
            this.ımageListIndirim.Images.SetKeyName(3, "funnel.png");
            this.ımageListIndirim.Images.SetKeyName(4, "funnel_delete.png");
            this.ımageListIndirim.Images.SetKeyName(5, "information.png");
            this.ımageListIndirim.Images.SetKeyName(6, "pencil.png");
            this.ımageListIndirim.Images.SetKeyName(7, "refresh.png");
            this.ımageListIndirim.Images.SetKeyName(8, "replace2.png");
            this.ımageListIndirim.Images.SetKeyName(9, "view.png");
            this.ımageListIndirim.Images.SetKeyName(10, "add.png");
            this.ımageListIndirim.Images.SetKeyName(11, "clock_run.png");
            this.ımageListIndirim.Images.SetKeyName(12, "delete.png");
            this.ımageListIndirim.Images.SetKeyName(13, "düzenle.png");
            this.ımageListIndirim.Images.SetKeyName(14, "ekle.png");
            this.ımageListIndirim.Images.SetKeyName(15, "folder_out.png");
            this.ımageListIndirim.Images.SetKeyName(16, "pencil.png");
            this.ımageListIndirim.Images.SetKeyName(17, "remotecontrol2.png");
            this.ımageListIndirim.Images.SetKeyName(18, "replace2.png");
            this.ımageListIndirim.Images.SetKeyName(19, "sil.png");
            this.ımageListIndirim.Images.SetKeyName(20, "sort_descending.png");
            this.ımageListIndirim.Images.SetKeyName(21, "stopwatch_run.png");
            this.ımageListIndirim.Images.SetKeyName(22, "view.png");
            this.ımageListIndirim.Images.SetKeyName(23, "checkbox.png");
            this.ımageListIndirim.Images.SetKeyName(24, "kapaligoz.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 14;
            this.btnEkle.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnEkle.Location = new System.Drawing.Point(12, 24);
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
            this.btnKapat.ImageOptions.ImageIndex = 2;
            this.btnKapat.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnKapat.Location = new System.Drawing.Point(1250, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 9;
            this.btnAra.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnAra.Location = new System.Drawing.Point(452, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAra.Size = new System.Drawing.Size(109, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 19;
            this.btnSil.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnSil.Location = new System.Drawing.Point(117, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDurumu);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnAra);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 667);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1364, 69);
            this.groupControl2.TabIndex = 39;
            this.groupControl2.Text = "Buton Menü";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 7;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnGuncelle.Location = new System.Drawing.Point(337, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.picBoxAcik.Click += new System.EventHandler(this.picBoxAcik_Click);
            // 
            // btnCariFiltreIptal
            // 
            this.btnCariFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltreIptal.ImageOptions.ImageIndex = 4;
            this.btnCariFiltreIptal.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnCariFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltreIptal.Location = new System.Drawing.Point(1312, 3);
            this.btnCariFiltreIptal.Name = "btnCariFiltreIptal";
            this.btnCariFiltreIptal.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltreIptal.TabIndex = 9;
            this.btnCariFiltreIptal.Click += new System.EventHandler(this.btnCariFiltreIptal_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.IndirimFilterControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.IndirimGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1356, 611);
            this.splitContainerControl1.SplitterPosition = 98;
            this.splitContainerControl1.TabIndex = 37;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnCariFiltre
            // 
            this.btnCariFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltre.ImageOptions.ImageIndex = 3;
            this.btnCariFiltre.ImageOptions.ImageList = this.ımageListIndirim;
            this.btnCariFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltre.Location = new System.Drawing.Point(1269, 3);
            this.btnCariFiltre.Name = "btnCariFiltre";
            this.btnCariFiltre.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltre.TabIndex = 10;
            this.btnCariFiltre.Click += new System.EventHandler(this.btnCariFiltre_Click);
            // 
            // IndirimFilterControl
            // 
            this.IndirimFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IndirimFilterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndirimFilterControl.Location = new System.Drawing.Point(0, 0);
            this.IndirimFilterControl.Name = "IndirimFilterControl";
            this.IndirimFilterControl.Size = new System.Drawing.Size(1356, 98);
            this.IndirimFilterControl.SourceControl = this.IndirimGridControl;
            this.IndirimFilterControl.TabIndex = 2;
            this.IndirimFilterControl.Text = "DepoFilterControl";
            // 
            // IndirimGridControl
            // 
            this.IndirimGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndirimGridControl.Location = new System.Drawing.Point(0, 0);
            this.IndirimGridControl.MainView = this.IndirimGridView;
            this.IndirimGridControl.Name = "IndirimGridControl";
            this.IndirimGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBaslangic,
            this.repoBitis});
            this.IndirimGridControl.Size = new System.Drawing.Size(1356, 503);
            this.IndirimGridControl.TabIndex = 3;
            this.IndirimGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.IndirimGridView});
            // 
            // IndirimGridView
            // 
            this.IndirimGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIndirimAktif,
            this.colId,
            this.colDurumu,
            this.colStokKodu,
            this.colBarkod,
            this.colStokAdi,
            this.colIndirimTuru,
            this.colBaslangicTarihi,
            this.colBitisTarihi,
            this.colIndirimOrani,
            this.colAciklama});
            this.IndirimGridView.GridControl = this.IndirimGridControl;
            this.IndirimGridView.Name = "IndirimGridView";
            this.IndirimGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.IndirimGridView_FocusedRowChanged);
            // 
            // colIndirimAktif
            // 
            this.colIndirimAktif.Caption = "İndirim Aktif Mi ?";
            this.colIndirimAktif.FieldName = "IndirimAktif";
            this.colIndirimAktif.Name = "colIndirimAktif";
            this.colIndirimAktif.Visible = true;
            this.colIndirimAktif.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Width = 38;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 1;
            this.colDurumu.Width = 143;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 2;
            this.colStokKodu.Width = 143;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 3;
            this.colBarkod.Width = 143;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 4;
            this.colStokAdi.Width = 143;
            // 
            // colIndirimTuru
            // 
            this.colIndirimTuru.Caption = "İndirim Türü";
            this.colIndirimTuru.FieldName = "IndirimTuru";
            this.colIndirimTuru.Name = "colIndirimTuru";
            this.colIndirimTuru.OptionsColumn.AllowEdit = false;
            this.colIndirimTuru.Visible = true;
            this.colIndirimTuru.VisibleIndex = 5;
            this.colIndirimTuru.Width = 143;
            // 
            // colBaslangicTarihi
            // 
            this.colBaslangicTarihi.Caption = "Başlangıç Tarihi";
            this.colBaslangicTarihi.ColumnEdit = this.repoBaslangic;
            this.colBaslangicTarihi.FieldName = "BaslangicTarihi";
            this.colBaslangicTarihi.Name = "colBaslangicTarihi";
            this.colBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslangicTarihi.Visible = true;
            this.colBaslangicTarihi.VisibleIndex = 6;
            this.colBaslangicTarihi.Width = 143;
            // 
            // repoBaslangic
            // 
            this.repoBaslangic.AutoHeight = false;
            this.repoBaslangic.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBaslangic.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBaslangic.Name = "repoBaslangic";
            this.repoBaslangic.NullText = "Tarih Bilgisi Yok";
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.Caption = "Bitiş Tarihi";
            this.colBitisTarihi.ColumnEdit = this.repoBitis;
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 7;
            this.colBitisTarihi.Width = 143;
            // 
            // repoBitis
            // 
            this.repoBitis.AutoHeight = false;
            this.repoBitis.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBitis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBitis.Name = "repoBitis";
            this.repoBitis.NullText = "Tarih Bilgisi Yok";
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İndirim Oranı";
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 8;
            this.colIndirimOrani.Width = 143;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama ";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            this.colAciklama.Width = 156;
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
            this.LblBaslik.TabIndex = 36;
            this.LblBaslik.Text = "İNDİRİMLER";
            // 
            // contextMenuIndirim
            // 
            this.contextMenuIndirim.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEkle,
            this.toolStripMenuItemSil,
            this.toolStripMenuItemPasif,
            this.toolStripMenuItemGuncelle});
            this.contextMenuIndirim.Name = "contextMenuStrip1";
            this.contextMenuIndirim.Size = new System.Drawing.Size(162, 92);
            // 
            // toolStripMenuItemEkle
            // 
            this.toolStripMenuItemEkle.Name = "toolStripMenuItemEkle";
            this.toolStripMenuItemEkle.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEkle.Text = "Yeni İndirim Ekle";
            this.toolStripMenuItemEkle.Click += new System.EventHandler(this.toolStripMenuItemEkle_Click);
            // 
            // toolStripMenuItemSil
            // 
            this.toolStripMenuItemSil.Name = "toolStripMenuItemSil";
            this.toolStripMenuItemSil.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSil.Text = "Sil";
            this.toolStripMenuItemSil.Click += new System.EventHandler(this.toolStripMenuItemSil_Click);
            // 
            // toolStripMenuItemPasif
            // 
            this.toolStripMenuItemPasif.Name = "toolStripMenuItemPasif";
            this.toolStripMenuItemPasif.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemPasif.Text = "Pasif Yap";
            this.toolStripMenuItemPasif.Click += new System.EventHandler(this.toolStripMenuItemPasif_Click);
            // 
            // toolStripMenuItemGuncelle
            // 
            this.toolStripMenuItemGuncelle.Name = "toolStripMenuItemGuncelle";
            this.toolStripMenuItemGuncelle.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemGuncelle.Text = "Güncelle";
            this.toolStripMenuItemGuncelle.Click += new System.EventHandler(this.toolStripMenuItemGuncelle_Click);
            // 
            // FrmIndirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.ContextMenuStrip = this.contextMenuIndirim;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.picBoxAcik);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmIndirim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndirimler Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IndirimGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndirimGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBaslangic.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBaslangic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis)).EndInit();
            this.contextMenuIndirim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDurumu;
        private System.Windows.Forms.ImageList ımageListIndirim;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.PictureBox picBoxAcik;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltreIptal;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltre;
        private DevExpress.XtraEditors.FilterControl IndirimFilterControl;
        private DevExpress.XtraGrid.GridControl IndirimGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView IndirimGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimAktif;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslangicTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repoBaslangic;
        private DevExpress.XtraGrid.Columns.GridColumn colBitisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repoBitis;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private System.Windows.Forms.ContextMenuStrip contextMenuIndirim;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPasif;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuncelle;
    }
}