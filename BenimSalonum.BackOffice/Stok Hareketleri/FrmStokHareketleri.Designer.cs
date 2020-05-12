namespace BenimSalonum.BackOffice.Stok_Hareketleri
{
    partial class FrmStokHareketleri
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokHareketleri));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoSeriNo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgStokHareketleri = new System.Windows.Forms.ImageList(this.components);
            this.btnDetay = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.picBoxAcik = new System.Windows.Forms.PictureBox();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnCariFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.btnCariFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.StokHareketFilterControl = new DevExpress.XtraEditors.FilterControl();
            this.gridcontStokHareketGenel = new DevExpress.XtraGrid.GridControl();
            this.gridStokHareketGenel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStokHareketGenel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareketGenel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.colSaat.VisibleIndex = 15;
            this.colSaat.Width = 61;
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
            this.colBirimi.FieldName = "Stok.Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 6;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 7;
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
            this.colKdv.VisibleIndex = 9;
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
            this.colBirimFiyati.VisibleIndex = 10;
            this.colBirimFiyati.Width = 70;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "Stok.StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 146;
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
            this.colIndirimOrani.VisibleIndex = 11;
            this.colIndirimOrani.Width = 82;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "colToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.UnboundExpression = "[BirimFiyati] * [Miktar] - [BirimFiyati] * [Miktar] * [IndirimOrani] / 100";
            this.colToplamTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 13;
            this.colToplamTutar.Width = 125;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "Depo.DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 3;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "Depo.DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 4;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Seri No";
            this.colSeriNo.ColumnEdit = this.repoSeriNo;
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 8;
            this.colSeriNo.Width = 74;
            // 
            // repoSeriNo
            // 
            this.repoSeriNo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repoSeriNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoSeriNo.Name = "repoSeriNo";
            this.repoSeriNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoSeriNo_ButtonClick);
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
            this.colTarih.VisibleIndex = 14;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "İndirim Tutarı";
            this.colIndirimTutari.DisplayFormat.FormatString = "C2";
            this.colIndirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutari.FieldName = "colIndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colIndirimTutari.UnboundExpression = "[BirimFiyati] * [Miktar] * [IndirimOrani] / 100";
            this.colIndirimTutari.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 12;
            this.colIndirimTutari.Width = 85;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 16;
            this.colAciklama.Width = 90;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "Stok.StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            // 
            // imgStokHareketleri
            // 
            this.imgStokHareketleri.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStokHareketleri.ImageStream")));
            this.imgStokHareketleri.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStokHareketleri.Images.SetKeyName(0, "folder_out.png");
            this.imgStokHareketleri.Images.SetKeyName(1, "funnel.png");
            this.imgStokHareketleri.Images.SetKeyName(2, "funnel_delete.png");
            this.imgStokHareketleri.Images.SetKeyName(3, "refresh.png");
            this.imgStokHareketleri.Images.SetKeyName(4, "view.png");
            this.imgStokHareketleri.Images.SetKeyName(5, "note_information.png");
            // 
            // btnDetay
            // 
            this.btnDetay.ImageOptions.ImageIndex = 5;
            this.btnDetay.ImageOptions.ImageList = this.imgStokHareketleri;
            this.btnDetay.Location = new System.Drawing.Point(12, 25);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDetay.Size = new System.Drawing.Size(99, 40);
            this.btnDetay.TabIndex = 0;
            this.btnDetay.Text = "Detay Gir";
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.imgStokHareketleri;
            this.btnKapat.Location = new System.Drawing.Point(1250, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 4;
            this.btnAra.ImageOptions.ImageList = this.imgStokHareketleri;
            this.btnAra.Location = new System.Drawing.Point(232, 25);
            this.btnAra.Name = "btnAra";
            this.btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAra.Size = new System.Drawing.Size(109, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 3;
            this.btnGuncelle.ImageOptions.ImageList = this.imgStokHareketleri;
            this.btnGuncelle.Location = new System.Drawing.Point(117, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDetay);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnAra);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 667);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1364, 69);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Buton Menü";
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
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 5;
            this.colHareket.Width = 55;
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
            this.LblBaslik.TabIndex = 28;
            this.LblBaslik.Text = "STOK HAREKETLERİ";
            // 
            // btnCariFiltre
            // 
            this.btnCariFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltre.ImageOptions.ImageIndex = 1;
            this.btnCariFiltre.ImageOptions.ImageList = this.imgStokHareketleri;
            this.btnCariFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltre.Location = new System.Drawing.Point(1277, 4);
            this.btnCariFiltre.Name = "btnCariFiltre";
            this.btnCariFiltre.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltre.TabIndex = 10;
            this.btnCariFiltre.Click += new System.EventHandler(this.btnCariFiltre_Click);
            // 
            // btnCariFiltreIptal
            // 
            this.btnCariFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariFiltreIptal.ImageOptions.ImageIndex = 2;
            this.btnCariFiltreIptal.ImageOptions.ImageList = this.imgStokHareketleri;
            this.btnCariFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCariFiltreIptal.Location = new System.Drawing.Point(1320, 4);
            this.btnCariFiltreIptal.Name = "btnCariFiltreIptal";
            this.btnCariFiltreIptal.Size = new System.Drawing.Size(37, 36);
            this.btnCariFiltreIptal.TabIndex = 9;
            this.btnCariFiltreIptal.Click += new System.EventHandler(this.btnCariFiltreIptal_Click);
            // 
            // StokHareketFilterControl
            // 
            this.StokHareketFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StokHareketFilterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StokHareketFilterControl.Location = new System.Drawing.Point(0, 0);
            this.StokHareketFilterControl.Name = "StokHareketFilterControl";
            this.StokHareketFilterControl.Size = new System.Drawing.Size(1360, 98);
            this.StokHareketFilterControl.SortFilterColumns = false;
            this.StokHareketFilterControl.SourceControl = this.gridcontStokHareketGenel;
            this.StokHareketFilterControl.TabIndex = 2;
            this.StokHareketFilterControl.Text = "CariFilterControl";
            this.StokHareketFilterControl.FilterChanged += new DevExpress.XtraEditors.FilterChangedEventHandler(this.StokHareketFilterControl_FilterChanged);
            // 
            // gridcontStokHareketGenel
            // 
            this.gridcontStokHareketGenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontStokHareketGenel.Location = new System.Drawing.Point(0, 0);
            this.gridcontStokHareketGenel.MainView = this.gridStokHareketGenel;
            this.gridcontStokHareketGenel.Name = "gridcontStokHareketGenel";
            this.gridcontStokHareketGenel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoSeriNo});
            this.gridcontStokHareketGenel.Size = new System.Drawing.Size(1360, 574);
            this.gridcontStokHareketGenel.TabIndex = 5;
            this.gridcontStokHareketGenel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokHareketGenel});
            // 
            // gridStokHareketGenel
            // 
            this.gridStokHareketGenel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridStokHareketGenel.GridControl = this.gridcontStokHareketGenel;
            this.gridStokHareketGenel.Name = "gridStokHareketGenel";
            this.gridStokHareketGenel.OptionsView.ColumnAutoWidth = false;
            this.gridStokHareketGenel.RowCountChanged += new System.EventHandler(this.gridStokHareketGenel_RowCountChanged);
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnCariFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.StokHareketFilterControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridcontStokHareketGenel);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1364, 686);
            this.splitContainerControl1.SplitterPosition = 98;
            this.splitContainerControl1.TabIndex = 29;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // FrmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.picBoxAcik);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmStokHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStokHareketleri_FormClosing);
            this.Load += new System.EventHandler(this.FrmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAcik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStokHareketGenel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareketGenel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private System.Windows.Forms.ImageList imgStokHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnDetay;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.PictureBox picBoxAcik;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltre;
        private DevExpress.XtraEditors.SimpleButton btnCariFiltreIptal;
        private DevExpress.XtraEditors.FilterControl StokHareketFilterControl;
        private DevExpress.XtraGrid.GridControl gridcontStokHareketGenel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokHareketGenel;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}