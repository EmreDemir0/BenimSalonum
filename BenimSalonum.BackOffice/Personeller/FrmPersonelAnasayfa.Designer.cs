namespace BenimSalonum.BackOffice.Personeller
{
    partial class FrmPersonelAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelAnasayfa));
            this.btnCariFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.ımageListPersoneller = new System.Windows.Forms.ImageList(this.components);
            this.colPersonelTc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAylikMaas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnCariFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.PersonellerFilterControl = new DevExpress.XtraEditors.FilterControl();
            this.PersonellerGridControl = new DevExpress.XtraGrid.GridControl();
            this.PersonellerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.picBoxAcik = new System.Windows.Forms.PictureBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnHakedis = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuPersonel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHareket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.contextMenuPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCariFiltreIptal
            // 
            this.btnCariFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltreIptal.ImageOptions.ImageIndex = 2;
            this.btnCariFiltreIptal.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnCariFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltreIptal.Location = new System.Drawing.Point(1320, 3);
            this.btnCariFiltreIptal.Name = "btnCariFiltreIptal";
            this.btnCariFiltreIptal.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltreIptal.TabIndex = 9;
            this.btnCariFiltreIptal.Click += new System.EventHandler(this.btnCariFiltreIptal_Click);
            // 
            // ımageListPersoneller
            // 
            this.ımageListPersoneller.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListPersoneller.ImageStream")));
            this.ımageListPersoneller.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListPersoneller.Images.SetKeyName(0, "folder_out.png");
            this.ımageListPersoneller.Images.SetKeyName(1, "funnel.png");
            this.ımageListPersoneller.Images.SetKeyName(2, "funnel_delete.png");
            this.ımageListPersoneller.Images.SetKeyName(3, "refresh.png");
            this.ımageListPersoneller.Images.SetKeyName(4, "view.png");
            this.ımageListPersoneller.Images.SetKeyName(5, "add.png");
            this.ımageListPersoneller.Images.SetKeyName(6, "delete.png");
            this.ımageListPersoneller.Images.SetKeyName(7, "düzenle.png");
            this.ımageListPersoneller.Images.SetKeyName(8, "Ekle.png");
            this.ımageListPersoneller.Images.SetKeyName(9, "folder_out.png");
            this.ımageListPersoneller.Images.SetKeyName(10, "funnel.png");
            this.ımageListPersoneller.Images.SetKeyName(11, "funnel_delete.png");
            this.ımageListPersoneller.Images.SetKeyName(12, "hakediş.png");
            this.ımageListPersoneller.Images.SetKeyName(13, "hareket.png");
            this.ımageListPersoneller.Images.SetKeyName(14, "money.png");
            this.ımageListPersoneller.Images.SetKeyName(15, "pencil.png");
            this.ımageListPersoneller.Images.SetKeyName(16, "refresh.png");
            this.ımageListPersoneller.Images.SetKeyName(17, "replace2.png");
            this.ımageListPersoneller.Images.SetKeyName(18, "sil.png");
            this.ımageListPersoneller.Images.SetKeyName(19, "user_headset.png");
            this.ımageListPersoneller.Images.SetKeyName(20, "view.png");
            // 
            // colPersonelTc
            // 
            this.colPersonelTc.Caption = "Tc No";
            this.colPersonelTc.FieldName = "PersonelTc";
            this.colPersonelTc.Name = "colPersonelTc";
            this.colPersonelTc.OptionsColumn.AllowEdit = false;
            this.colPersonelTc.Visible = true;
            this.colPersonelTc.VisibleIndex = 4;
            this.colPersonelTc.Width = 108;
            // 
            // colPersonelGiris
            // 
            this.colPersonelGiris.Caption = "Giriş Tarihi";
            this.colPersonelGiris.FieldName = "PersonelGiris";
            this.colPersonelGiris.Name = "colPersonelGiris";
            this.colPersonelGiris.OptionsColumn.AllowEdit = false;
            this.colPersonelGiris.Visible = true;
            this.colPersonelGiris.VisibleIndex = 5;
            this.colPersonelGiris.Width = 108;
            // 
            // colPersonelCikis
            // 
            this.colPersonelCikis.Caption = "Çıkış Tarihi";
            this.colPersonelCikis.FieldName = "PersonelCikis";
            this.colPersonelCikis.Name = "colPersonelCikis";
            this.colPersonelCikis.OptionsColumn.AllowEdit = false;
            this.colPersonelCikis.Visible = true;
            this.colPersonelCikis.VisibleIndex = 6;
            this.colPersonelCikis.Width = 108;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "Cep Telefonu";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 7;
            this.colCepTelefonu.Width = 108;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            // 
            // colEMail
            // 
            this.colEMail.Caption = "E-Mail";
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.OptionsColumn.AllowEdit = false;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            // 
            // colAylikMaas
            // 
            this.colAylikMaas.Caption = "Aylık Maaş";
            this.colAylikMaas.DisplayFormat.FormatString = "C2";
            this.colAylikMaas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAylikMaas.FieldName = "AylikMaas";
            this.colAylikMaas.Name = "colAylikMaas";
            this.colAylikMaas.OptionsColumn.AllowEdit = false;
            this.colAylikMaas.Visible = true;
            this.colAylikMaas.VisibleIndex = 8;
            this.colAylikMaas.Width = 108;
            // 
            // colPrimOrani
            // 
            this.colPrimOrani.Caption = "Prim Oranı(%)";
            this.colPrimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colPrimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimOrani.FieldName = "PrimOrani";
            this.colPrimOrani.Name = "colPrimOrani";
            this.colPrimOrani.OptionsColumn.AllowEdit = false;
            this.colPrimOrani.Visible = true;
            this.colPrimOrani.VisibleIndex = 9;
            this.colPrimOrani.Width = 108;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 12;
            this.colAciklama.Width = 108;
            // 
            // colToplamSatis
            // 
            this.colToplamSatis.Caption = "Toplam Satış";
            this.colToplamSatis.DisplayFormat.FormatString = "C2";
            this.colToplamSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamSatis.FieldName = "ToplamSatis";
            this.colToplamSatis.Name = "colToplamSatis";
            this.colToplamSatis.OptionsColumn.AllowEdit = false;
            this.colToplamSatis.Visible = true;
            this.colToplamSatis.VisibleIndex = 11;
            this.colToplamSatis.Width = 108;
            // 
            // colPrimTutar
            // 
            this.colPrimTutar.Caption = "Prim Tutarı";
            this.colPrimTutar.DisplayFormat.FormatString = "C2";
            this.colPrimTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimTutar.FieldName = "PrimTutar";
            this.colPrimTutar.Name = "colPrimTutar";
            this.colPrimTutar.OptionsColumn.AllowEdit = false;
            this.colPrimTutar.Visible = true;
            this.colPrimTutar.VisibleIndex = 10;
            this.colPrimTutar.Width = 142;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.PersonellerFilterControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.PersonellerGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1364, 615);
            this.splitContainerControl1.SplitterPosition = 119;
            this.splitContainerControl1.TabIndex = 41;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnCariFiltre
            // 
            this.btnCariFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltre.ImageOptions.ImageIndex = 1;
            this.btnCariFiltre.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnCariFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltre.Location = new System.Drawing.Point(1277, 3);
            this.btnCariFiltre.Name = "btnCariFiltre";
            this.btnCariFiltre.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltre.TabIndex = 10;
            this.btnCariFiltre.Click += new System.EventHandler(this.btnCariFiltre_Click);
            // 
            // PersonellerFilterControl
            // 
            this.PersonellerFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PersonellerFilterControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonellerFilterControl.Location = new System.Drawing.Point(0, 0);
            this.PersonellerFilterControl.Name = "PersonellerFilterControl";
            this.PersonellerFilterControl.Size = new System.Drawing.Size(1364, 119);
            this.PersonellerFilterControl.SortFilterColumns = false;
            this.PersonellerFilterControl.SourceControl = this.PersonellerGridControl;
            this.PersonellerFilterControl.TabIndex = 2;
            this.PersonellerFilterControl.Text = "OdemeTuruFilterControl";
            this.PersonellerFilterControl.FilterChanged += new DevExpress.XtraEditors.FilterChangedEventHandler(this.PersonellerFilterControl_FilterChanged);
            // 
            // PersonellerGridControl
            // 
            this.PersonellerGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonellerGridControl.Location = new System.Drawing.Point(0, 0);
            this.PersonellerGridControl.MainView = this.PersonellerGridView;
            this.PersonellerGridControl.Name = "PersonellerGridControl";
            this.PersonellerGridControl.Size = new System.Drawing.Size(1364, 486);
            this.PersonellerGridControl.TabIndex = 3;
            this.PersonellerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PersonellerGridView});
            // 
            // PersonellerGridView
            // 
            this.PersonellerGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colPersonelUnvani,
            this.colPersonelKodu,
            this.colPersonelAdi,
            this.colPersonelTc,
            this.colPersonelGiris,
            this.colPersonelCikis,
            this.colCepTelefonu,
            this.colTelefon,
            this.colFax,
            this.colEMail,
            this.colWeb,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colAylikMaas,
            this.colPrimOrani,
            this.colAciklama,
            this.colToplamSatis,
            this.colPrimTutar});
            this.PersonellerGridView.GridControl = this.PersonellerGridControl;
            this.PersonellerGridView.Name = "PersonellerGridView";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durumu";
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            this.colDurumu.Width = 30;
            // 
            // colPersonelUnvani
            // 
            this.colPersonelUnvani.Caption = "Personel Ünvanı";
            this.colPersonelUnvani.FieldName = "PersonelUnvani";
            this.colPersonelUnvani.Name = "colPersonelUnvani";
            this.colPersonelUnvani.OptionsColumn.AllowEdit = false;
            this.colPersonelUnvani.Visible = true;
            this.colPersonelUnvani.VisibleIndex = 1;
            this.colPersonelUnvani.Width = 86;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            this.colPersonelKodu.Visible = true;
            this.colPersonelKodu.VisibleIndex = 2;
            this.colPersonelKodu.Width = 108;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adı";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 3;
            this.colPersonelAdi.Width = 108;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dropDownButton1.ImageOptions.SvgImage")));
            this.dropDownButton1.Location = new System.Drawing.Point(1314, 4);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.dropDownButton1.Size = new System.Drawing.Size(50, 40);
            this.dropDownButton1.TabIndex = 43;
            // 
            // picBoxAcik
            // 
            this.picBoxAcik.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAcik.Image")));
            this.picBoxAcik.Location = new System.Drawing.Point(56, 4);
            this.picBoxAcik.Name = "picBoxAcik";
            this.picBoxAcik.Size = new System.Drawing.Size(40, 40);
            this.picBoxAcik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAcik.TabIndex = 42;
            this.picBoxAcik.TabStop = false;
            this.picBoxAcik.Click += new System.EventHandler(this.picBoxAcik_Click);
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
            this.groupControl1.TabIndex = 40;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnHakedis);
            this.groupControl2.Controls.Add(this.btnDuzenle);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnAra);
            this.groupControl2.Controls.Add(this.btnPersonelHareket);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1360, 69);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Buton Menü";
            // 
            // btnHakedis
            // 
            this.btnHakedis.ImageOptions.ImageIndex = 16;
            this.btnHakedis.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnHakedis.Location = new System.Drawing.Point(652, 26);
            this.btnHakedis.Name = "btnHakedis";
            this.btnHakedis.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnHakedis.Size = new System.Drawing.Size(149, 40);
            this.btnHakedis.TabIndex = 3;
            this.btnHakedis.Text = "Hakediş Hesaplama";
            this.btnHakedis.Click += new System.EventHandler(this.btnHakedis_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 7;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnDuzenle.Location = new System.Drawing.Point(117, 25);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDuzenle.Size = new System.Drawing.Size(99, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 8;
            this.btnEkle.ImageOptions.ImageList = this.ımageListPersoneller;
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
            this.btnKapat.ImageOptions.ImageIndex = 9;
            this.btnKapat.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnKapat.Location = new System.Drawing.Point(1246, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 20;
            this.btnAra.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnAra.Location = new System.Drawing.Point(557, 25);
            this.btnAra.Name = "btnAra";
            this.btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAra.Size = new System.Drawing.Size(109, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnPersonelHareket
            // 
            this.btnPersonelHareket.ImageOptions.ImageIndex = 13;
            this.btnPersonelHareket.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnPersonelHareket.Location = new System.Drawing.Point(327, 25);
            this.btnPersonelHareket.Name = "btnPersonelHareket";
            this.btnPersonelHareket.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPersonelHareket.Size = new System.Drawing.Size(109, 40);
            this.btnPersonelHareket.TabIndex = 2;
            this.btnPersonelHareket.Text = "Personel \r\nHareket";
            this.btnPersonelHareket.Click += new System.EventHandler(this.btnPersonelHareket_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 16;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnGuncelle.Location = new System.Drawing.Point(442, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 18;
            this.btnSil.ImageOptions.ImageList = this.ımageListPersoneller;
            this.btnSil.Location = new System.Drawing.Point(222, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(99, 40);
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
            this.LblBaslik.TabIndex = 39;
            this.LblBaslik.Text = "PERSONEL KARTLARI";
            // 
            // contextMenuPersonel
            // 
            this.contextMenuPersonel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEkle,
            this.toolStripMenuItemDuzenle,
            this.toolStripMenuItemSil,
            this.toolStripMenuItemHareket,
            this.toolStripMenuItemGuncelle});
            this.contextMenuPersonel.Name = "contextMenuStrip1";
            this.contextMenuPersonel.Size = new System.Drawing.Size(169, 114);
            // 
            // toolStripMenuItemEkle
            // 
            this.toolStripMenuItemEkle.Name = "toolStripMenuItemEkle";
            this.toolStripMenuItemEkle.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemEkle.Text = "Yeni Personel Ekle";
            this.toolStripMenuItemEkle.Click += new System.EventHandler(this.toolStripMenuItemEkle_Click);
            // 
            // toolStripMenuItemDuzenle
            // 
            this.toolStripMenuItemDuzenle.Name = "toolStripMenuItemDuzenle";
            this.toolStripMenuItemDuzenle.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemDuzenle.Text = "Düzenle";
            this.toolStripMenuItemDuzenle.Click += new System.EventHandler(this.toolStripMenuItemDuzenle_Click);
            // 
            // toolStripMenuItemSil
            // 
            this.toolStripMenuItemSil.Name = "toolStripMenuItemSil";
            this.toolStripMenuItemSil.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemSil.Text = "Sil";
            this.toolStripMenuItemSil.Click += new System.EventHandler(this.toolStripMenuItemSil_Click);
            // 
            // toolStripMenuItemHareket
            // 
            this.toolStripMenuItemHareket.Name = "toolStripMenuItemHareket";
            this.toolStripMenuItemHareket.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemHareket.Text = "Personel Hareket";
            this.toolStripMenuItemHareket.Click += new System.EventHandler(this.toolStripMenuItemHareket_Click);
            // 
            // toolStripMenuItemGuncelle
            // 
            this.toolStripMenuItemGuncelle.Name = "toolStripMenuItemGuncelle";
            this.toolStripMenuItemGuncelle.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemGuncelle.Text = "Güncelle";
            this.toolStripMenuItemGuncelle.Click += new System.EventHandler(this.toolStripMenuItemGuncelle_Click);
            // 
            // FrmPersonelAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.ContextMenuStrip = this.contextMenuPersonel;
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.picBoxAcik);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmPersonelAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPersonelAnasayfa_FormClosing);
            this.Load += new System.EventHandler(this.FrmPersonelAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.contextMenuPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCariFiltreIptal;
        private System.Windows.Forms.ImageList ımageListPersoneller;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelTc;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn colWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colAylikMaas;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimTutar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltre;
        private DevExpress.XtraEditors.FilterControl PersonellerFilterControl;
        private DevExpress.XtraGrid.GridControl PersonellerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PersonellerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private System.Windows.Forms.PictureBox picBoxAcik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnHakedis;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnPersonelHareket;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private System.Windows.Forms.ContextMenuStrip contextMenuPersonel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDuzenle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHareket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuncelle;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}