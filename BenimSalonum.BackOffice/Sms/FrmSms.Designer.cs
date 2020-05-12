namespace BenimSalonum.BackOffice.Sms
{
    partial class FrmSms
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSms));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colListeCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListeCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListeCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKarakterSayisi = new DevExpress.XtraEditors.LabelControl();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtMesaj = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKullaniciNo = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrjinator = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBakiye = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAyarlar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrjinator.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colListeCariKodu,
            this.colListeCariAdi,
            this.colListeCepTelefonu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colListeCariKodu
            // 
            this.colListeCariKodu.Caption = "Cari Kodu";
            this.colListeCariKodu.FieldName = "CariKodu";
            this.colListeCariKodu.Name = "colListeCariKodu";
            this.colListeCariKodu.OptionsColumn.AllowEdit = false;
            this.colListeCariKodu.Visible = true;
            this.colListeCariKodu.VisibleIndex = 0;
            // 
            // colListeCariAdi
            // 
            this.colListeCariAdi.Caption = "Cari Adı";
            this.colListeCariAdi.FieldName = "CariAdi";
            this.colListeCariAdi.Name = "colListeCariAdi";
            this.colListeCariAdi.OptionsColumn.AllowEdit = false;
            this.colListeCariAdi.Visible = true;
            this.colListeCariAdi.VisibleIndex = 1;
            // 
            // colListeCepTelefonu
            // 
            this.colListeCepTelefonu.Caption = "Cep Telefonu";
            this.colListeCepTelefonu.FieldName = "CepTelefonu";
            this.colListeCepTelefonu.Name = "colListeCepTelefonu";
            this.colListeCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colListeCepTelefonu.Visible = true;
            this.colListeCepTelefonu.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(354, 486);
            this.gridControl1.TabIndex = 53;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(354, 60);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(660, 304);
            this.groupControl1.TabIndex = 54;
            this.groupControl1.Text = "Seçilen Numaralar";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 23);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl2.Size = new System.Drawing.Size(656, 279);
            this.gridControl2.TabIndex = 48;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSil,
            this.colCariKodu,
            this.colCariAdi,
            this.colCepTelefonu});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colSil
            // 
            this.colSil.Caption = "Sil";
            this.colSil.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colSil.Name = "colSil";
            this.colSil.Visible = true;
            this.colSil.VisibleIndex = 0;
            this.colSil.Width = 42;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions7.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions7, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject25, serializableAppearanceObject26, serializableAppearanceObject27, serializableAppearanceObject28, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 1;
            this.colCariKodu.Width = 199;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 2;
            this.colCariAdi.Width = 199;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "Cep Telefonu";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 3;
            this.colCepTelefonu.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblKarakterSayisi);
            this.groupBox1.Controls.Add(this.checkButton2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(354, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 52);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // checkButton1
            // 
            this.checkButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton1.Location = new System.Drawing.Point(494, 12);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.checkButton1.Size = new System.Drawing.Size(75, 31);
            this.checkButton1.TabIndex = 2;
            this.checkButton1.Text = "Normal SMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblKarakterSayisi
            // 
            this.lblKarakterSayisi.Location = new System.Drawing.Point(23, 30);
            this.lblKarakterSayisi.Name = "lblKarakterSayisi";
            this.lblKarakterSayisi.Size = new System.Drawing.Size(78, 13);
            this.lblKarakterSayisi.TabIndex = 1;
            this.lblKarakterSayisi.Text = "Karakter Sayısı :";
            // 
            // checkButton2
            // 
            this.checkButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton2.Location = new System.Drawing.Point(575, 12);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.checkButton2.Size = new System.Drawing.Size(75, 31);
            this.checkButton2.TabIndex = 3;
            this.checkButton2.Text = "Türkçe SMS";
            // 
            // groupControl4
            // 
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl4.Controls.Add(this.txtMesaj);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(354, 60);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(660, 486);
            this.groupControl4.TabIndex = 55;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMesaj.Location = new System.Drawing.Point(0, 362);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(660, 124);
            this.txtMesaj.TabIndex = 0;
            this.txtMesaj.EditValueChanged += new System.EventHandler(this.txtMesaj_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupBox2);
            this.groupControl2.Controls.Add(this.btnBakiye);
            this.groupControl2.Controls.Add(this.btnAyarlar);
            this.groupControl2.Controls.Add(this.btnGonder);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 546);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1014, 80);
            this.groupControl2.TabIndex = 52;
            this.groupControl2.Text = " Menü";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKullaniciNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKullaniciAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOrjinator);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(212, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // txtKullaniciNo
            // 
            this.txtKullaniciNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKullaniciNo.Location = new System.Drawing.Point(76, 10);
            this.txtKullaniciNo.Name = "txtKullaniciNo";
            this.txtKullaniciNo.Size = new System.Drawing.Size(125, 20);
            this.txtKullaniciNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Başlık :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(76, 31);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(125, 20);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSifre.Location = new System.Drawing.Point(282, 10);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(125, 20);
            this.txtSifre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // txtOrjinator
            // 
            this.txtOrjinator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOrjinator.Location = new System.Drawing.Point(282, 31);
            this.txtOrjinator.Name = "txtOrjinator";
            this.txtOrjinator.Size = new System.Drawing.Size(125, 20);
            this.txtOrjinator.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kullanıcı No :";
            // 
            // btnBakiye
            // 
            this.btnBakiye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBakiye.ImageOptions.ImageIndex = 3;
            this.btnBakiye.ImageOptions.ImageList = this.ımageList1;
            this.btnBakiye.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBakiye.Location = new System.Drawing.Point(5, 28);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnBakiye.Size = new System.Drawing.Size(112, 40);
            this.btnBakiye.TabIndex = 4;
            this.btnBakiye.Text = "Bakiye Sorgula";
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Gonder.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "Ayar.png");
            this.ımageList1.Images.SetKeyName(3, "Bakiye.png");
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyarlar.ImageOptions.ImageIndex = 2;
            this.btnAyarlar.ImageOptions.ImageList = this.ımageList1;
            this.btnAyarlar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAyarlar.Location = new System.Drawing.Point(123, 29);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAyarlar.Size = new System.Drawing.Size(83, 40);
            this.btnAyarlar.TabIndex = 3;
            this.btnAyarlar.Text = "Ayarları\r\nKaydet";
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGonder.ImageOptions.ImageIndex = 0;
            this.btnGonder.ImageOptions.ImageList = this.ımageList1;
            this.btnGonder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGonder.Location = new System.Drawing.Point(788, 34);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGonder.Size = new System.Drawing.Size(99, 40);
            this.btnGonder.TabIndex = 0;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKapat.Location = new System.Drawing.Point(893, 34);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.LblBaslik.Size = new System.Drawing.Size(1014, 60);
            this.LblBaslik.TabIndex = 51;
            this.LblBaslik.Text = "SMS GÖNDERME PANELİ";
            // 
            // FrmSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.LblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sms Gönderme Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSms_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrjinator.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colListeCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colListeCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colListeCepTelefonu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lblKarakterSayisi;
        private DevExpress.XtraEditors.CheckButton checkButton2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.MemoEdit txtMesaj;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciNo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtOrjinator;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnBakiye;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnAyarlar;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
    }
}