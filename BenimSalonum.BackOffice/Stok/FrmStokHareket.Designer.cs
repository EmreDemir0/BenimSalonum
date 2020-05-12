namespace BenimSalonum.BackOffice.Stok
{
    partial class FrmStokHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokHareket));
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridcontDepoStok = new DevExpress.XtraGrid.GridControl();
            this.gridDepoStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDepolarDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridcontGenelStok = new DevExpress.XtraGrid.GridControl();
            this.gridGenelStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGenelBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelKayitSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridcontStokHareket = new DevExpress.XtraGrid.GridControl();
            this.gridStokHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontGenelStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.UnboundExpression = "[BirimFiyati] * [Miktar] - [BirimFiyati] * [Miktar] * [IndirimOrani] / 100";
            this.colToplamTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 8;
            this.colToplamTutar.Width = 125;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "Depo.DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Seri No";
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.GroupFormat.FormatString = "d";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 9;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.GroupFormat.FormatString = "t";
            this.colSaat.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 10;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 11;
            this.colAciklama.Width = 297;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainer2.Size = new System.Drawing.Size(1364, 339);
            this.splitContainer2.SplitterDistance = 682;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridcontDepoStok);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(682, 339);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Depo Bazında Stok Miktarları ";
            // 
            // gridcontDepoStok
            // 
            this.gridcontDepoStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontDepoStok.Location = new System.Drawing.Point(2, 23);
            this.gridcontDepoStok.MainView = this.gridDepoStok;
            this.gridcontDepoStok.Name = "gridcontDepoStok";
            this.gridcontDepoStok.Size = new System.Drawing.Size(678, 314);
            this.gridcontDepoStok.TabIndex = 5;
            this.gridcontDepoStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepoStok});
            // 
            // gridDepoStok
            // 
            this.gridDepoStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepolarDepoKodu,
            this.colDepolarDepoAdi,
            this.colDepolarStokGiris,
            this.colDepolarStokCikis,
            this.colDepolarMevcutStok});
            this.gridDepoStok.GridControl = this.gridcontDepoStok;
            this.gridDepoStok.Name = "gridDepoStok";
            this.gridDepoStok.OptionsView.ColumnAutoWidth = false;
            this.gridDepoStok.OptionsView.ShowGroupPanel = false;
            // 
            // colDepolarDepoKodu
            // 
            this.colDepolarDepoKodu.Caption = "Depo Kodu";
            this.colDepolarDepoKodu.FieldName = "DepoKodu";
            this.colDepolarDepoKodu.Name = "colDepolarDepoKodu";
            this.colDepolarDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepolarDepoKodu.Visible = true;
            this.colDepolarDepoKodu.VisibleIndex = 0;
            this.colDepolarDepoKodu.Width = 125;
            // 
            // colDepolarDepoAdi
            // 
            this.colDepolarDepoAdi.Caption = "Depo Adı";
            this.colDepolarDepoAdi.FieldName = "DepoAdi";
            this.colDepolarDepoAdi.Name = "colDepolarDepoAdi";
            this.colDepolarDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepolarDepoAdi.Visible = true;
            this.colDepolarDepoAdi.VisibleIndex = 1;
            this.colDepolarDepoAdi.Width = 125;
            // 
            // colDepolarStokGiris
            // 
            this.colDepolarStokGiris.Caption = "Stok Giriş";
            this.colDepolarStokGiris.FieldName = "StokGiris";
            this.colDepolarStokGiris.Name = "colDepolarStokGiris";
            this.colDepolarStokGiris.OptionsColumn.AllowEdit = false;
            this.colDepolarStokGiris.Visible = true;
            this.colDepolarStokGiris.VisibleIndex = 2;
            this.colDepolarStokGiris.Width = 125;
            // 
            // colDepolarStokCikis
            // 
            this.colDepolarStokCikis.Caption = "Stok Çıkış";
            this.colDepolarStokCikis.FieldName = "StokCikis";
            this.colDepolarStokCikis.Name = "colDepolarStokCikis";
            this.colDepolarStokCikis.OptionsColumn.AllowEdit = false;
            this.colDepolarStokCikis.Visible = true;
            this.colDepolarStokCikis.VisibleIndex = 3;
            this.colDepolarStokCikis.Width = 125;
            // 
            // colDepolarMevcutStok
            // 
            this.colDepolarMevcutStok.Caption = "Mevcut Stok";
            this.colDepolarMevcutStok.FieldName = "MevcutStok";
            this.colDepolarMevcutStok.Name = "colDepolarMevcutStok";
            this.colDepolarMevcutStok.OptionsColumn.AllowEdit = false;
            this.colDepolarMevcutStok.Visible = true;
            this.colDepolarMevcutStok.VisibleIndex = 4;
            this.colDepolarMevcutStok.Width = 160;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridcontGenelStok);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(678, 339);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Genel Stok Bilgisi";
            // 
            // gridcontGenelStok
            // 
            this.gridcontGenelStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontGenelStok.Location = new System.Drawing.Point(2, 23);
            this.gridcontGenelStok.MainView = this.gridGenelStok;
            this.gridcontGenelStok.Name = "gridcontGenelStok";
            this.gridcontGenelStok.Size = new System.Drawing.Size(674, 314);
            this.gridcontGenelStok.TabIndex = 5;
            this.gridcontGenelStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGenelStok});
            // 
            // gridGenelStok
            // 
            this.gridGenelStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGenelBilgi,
            this.colGenelKayitSayisi,
            this.colGenelToplam});
            this.gridGenelStok.GridControl = this.gridcontGenelStok;
            this.gridGenelStok.Name = "gridGenelStok";
            this.gridGenelStok.OptionsView.ColumnAutoWidth = false;
            this.gridGenelStok.OptionsView.ShowGroupPanel = false;
            // 
            // colGenelBilgi
            // 
            this.colGenelBilgi.Caption = "Bilgi";
            this.colGenelBilgi.FieldName = "Bilgi";
            this.colGenelBilgi.Name = "colGenelBilgi";
            this.colGenelBilgi.OptionsColumn.AllowEdit = false;
            this.colGenelBilgi.Visible = true;
            this.colGenelBilgi.VisibleIndex = 0;
            this.colGenelBilgi.Width = 125;
            // 
            // colGenelKayitSayisi
            // 
            this.colGenelKayitSayisi.Caption = "Kayıt Sayısı";
            this.colGenelKayitSayisi.FieldName = "KayitSayisi";
            this.colGenelKayitSayisi.Name = "colGenelKayitSayisi";
            this.colGenelKayitSayisi.OptionsColumn.AllowEdit = false;
            this.colGenelKayitSayisi.Visible = true;
            this.colGenelKayitSayisi.VisibleIndex = 1;
            this.colGenelKayitSayisi.Width = 125;
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.Caption = "Toplam";
            this.colGenelToplam.FieldName = "Toplam";
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.OptionsColumn.AllowEdit = false;
            this.colGenelToplam.Visible = true;
            this.colGenelToplam.VisibleIndex = 2;
            this.colGenelToplam.Width = 399;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "Depo.DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "İndirim Tutarı";
            this.colIndirimTutari.DisplayFormat.FormatString = "C2";
            this.colIndirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colIndirimTutari.UnboundExpression = "[BirimFiyati] * [Miktar] * [IndirimOrani] / 100";
            this.colIndirimTutari.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 7;
            this.colIndirimTutari.Width = 125;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnAra);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 667);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1364, 69);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Buton Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1250, 25);
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
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "view.png");
            this.ımageList1.Images.SetKeyName(2, "replace2.png");
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 1;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(120, 25);
            this.btnAra.Name = "btnAra";
            this.btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAra.Size = new System.Drawing.Size(109, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 2;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(5, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.LblBaslik.Location = new System.Drawing.Point(0, 0);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(1364, 50);
            this.LblBaslik.TabIndex = 6;
            this.LblBaslik.Text = "STOK HAREKETLERİ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridcontStokHareket);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1364, 686);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 7;
            // 
            // gridcontStokHareket
            // 
            this.gridcontStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontStokHareket.Location = new System.Drawing.Point(0, 0);
            this.gridcontStokHareket.MainView = this.gridStokHareket;
            this.gridcontStokHareket.Name = "gridcontStokHareket";
            this.gridcontStokHareket.Size = new System.Drawing.Size(1364, 343);
            this.gridcontStokHareket.TabIndex = 4;
            this.gridcontStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokHareket});
            // 
            // gridStokHareket
            // 
            this.gridStokHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodTuru,
            this.colBarkod,
            this.colBirimi,
            this.colMiktar,
            this.colKdv,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colIndirimTutari,
            this.colToplamTutar,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colSeriNo,
            this.colTarih,
            this.colSaat,
            this.colAciklama});
            this.gridStokHareket.GridControl = this.gridcontStokHareket;
            this.gridStokHareket.Name = "gridStokHareket";
            this.gridStokHareket.OptionsView.ColumnAutoWidth = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            this.colHareket.Width = 125;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "Stok.StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "Stok.StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Türü";
            this.colBarkodTuru.FieldName = "Stok.BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            this.colBarkodTuru.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Stok.Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 2;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 3;
            // 
            // colKdv
            // 
            this.colKdv.Caption = "Kdv (%)";
            this.colKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 4;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "Birim Fiyatı";
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 5;
            this.colBirimFiyati.Width = 125;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd. Oranı (%)";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 6;
            this.colIndirimOrani.Width = 82;
            // 
            // FrmStokHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmStokHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri Dökümü";
            this.Load += new System.EventHandler(this.FrmStokHareket_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontGenelStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridcontDepoStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepoStok;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarStokGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarStokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarMevcutStok;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridcontGenelStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGenelStok;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelKayitSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridcontStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
    }
}