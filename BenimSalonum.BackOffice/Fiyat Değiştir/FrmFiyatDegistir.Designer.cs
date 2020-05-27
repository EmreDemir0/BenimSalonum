namespace BenimSalonum.BackOffice.Fiyat_Değiştir
{
    partial class FrmFiyatDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiyatDegistir));
            this.repositoryDegisimTutari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryDegisimYonu = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegisimYonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegisimTuru = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegisimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegistir = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.colDegistir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFiyatDegistir = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiyatTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FiyatDegistirGridControl = new DevExpress.XtraGrid.GridControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTutari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiyatDegistir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiyatDegistirGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryDegisimTutari
            // 
            this.repositoryDegisimTutari.AutoHeight = false;
            this.repositoryDegisimTutari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimTutari.Name = "repositoryDegisimTutari";
            // 
            // repositoryDegisimYonu
            // 
            this.repositoryDegisimYonu.AutoHeight = false;
            this.repositoryDegisimYonu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimYonu.Items.AddRange(new object[] {
            "Arttır (+)",
            "Azalt (-)"});
            this.repositoryDegisimYonu.Name = "repositoryDegisimYonu";
            this.repositoryDegisimYonu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegisimYonu
            // 
            this.colDegisimYonu.Caption = "Değişim Yönü";
            this.colDegisimYonu.ColumnEdit = this.repositoryDegisimYonu;
            this.colDegisimYonu.FieldName = "DegisimYonu";
            this.colDegisimYonu.Name = "colDegisimYonu";
            this.colDegisimYonu.Visible = true;
            this.colDegisimYonu.VisibleIndex = 3;
            // 
            // repositoryDegisimTuru
            // 
            this.repositoryDegisimTuru.AutoHeight = false;
            this.repositoryDegisimTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimTuru.Items.AddRange(new object[] {
            "Yüzde (%)",
            "Tutar (TL)",
            "Degisim (TL)"});
            this.repositoryDegisimTuru.Name = "repositoryDegisimTuru";
            this.repositoryDegisimTuru.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegisimTuru
            // 
            this.colDegisimTuru.Caption = "Değişim Türü";
            this.colDegisimTuru.ColumnEdit = this.repositoryDegisimTuru;
            this.colDegisimTuru.DisplayFormat.FormatString = "N2";
            this.colDegisimTuru.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDegisimTuru.FieldName = "DegisimTuru";
            this.colDegisimTuru.Name = "colDegisimTuru";
            this.colDegisimTuru.Visible = true;
            this.colDegisimTuru.VisibleIndex = 2;
            // 
            // repositoryDegistir
            // 
            this.repositoryDegistir.AutoHeight = false;
            this.repositoryDegistir.Name = "repositoryDegistir";
            this.repositoryDegistir.OffText = "Off";
            this.repositoryDegistir.OnText = "On";
            // 
            // colDegistir
            // 
            this.colDegistir.Caption = "Fiyat Değiştirilecek Mi ?";
            this.colDegistir.ColumnEdit = this.repositoryDegistir;
            this.colDegistir.FieldName = "Degistir";
            this.colDegistir.Name = "colDegistir";
            this.colDegistir.Visible = true;
            this.colDegistir.VisibleIndex = 1;
            // 
            // colDegeri
            // 
            this.colDegeri.Caption = "Değişim Tutarı";
            this.colDegeri.ColumnEdit = this.repositoryDegisimTutari;
            this.colDegeri.FieldName = "Degeri";
            this.colDegeri.Name = "colDegeri";
            this.colDegeri.Visible = true;
            this.colDegeri.VisibleIndex = 4;
            // 
            // colKolonAdi
            // 
            this.colKolonAdi.Caption = "Kolon Adı";
            this.colKolonAdi.FieldName = "KolonAdi";
            this.colKolonAdi.Name = "colKolonAdi";
            this.colKolonAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridFiyatDegistir
            // 
            this.gridFiyatDegistir.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFiyatTuru,
            this.colKolonAdi,
            this.colDegistir,
            this.colDegisimTuru,
            this.colDegisimYonu,
            this.colDegeri});
            this.gridFiyatDegistir.GridControl = this.FiyatDegistirGridControl;
            this.gridFiyatDegistir.Name = "gridFiyatDegistir";
            this.gridFiyatDegistir.OptionsView.ColumnAutoWidth = false;
            this.gridFiyatDegistir.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDegistir, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colFiyatTuru
            // 
            this.colFiyatTuru.Caption = "Fiyat Türü";
            this.colFiyatTuru.FieldName = "FiyatTuru";
            this.colFiyatTuru.Name = "colFiyatTuru";
            this.colFiyatTuru.Visible = true;
            this.colFiyatTuru.VisibleIndex = 0;
            // 
            // FiyatDegistirGridControl
            // 
            this.FiyatDegistirGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiyatDegistirGridControl.Location = new System.Drawing.Point(0, 50);
            this.FiyatDegistirGridControl.MainView = this.gridFiyatDegistir;
            this.FiyatDegistirGridControl.Name = "FiyatDegistirGridControl";
            this.FiyatDegistirGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDegistir,
            this.repositoryDegisimTuru,
            this.repositoryDegisimYonu,
            this.repositoryDegisimTutari});
            this.FiyatDegistirGridControl.Size = new System.Drawing.Size(648, 229);
            this.FiyatDegistirGridControl.TabIndex = 25;
            this.FiyatDegistirGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFiyatDegistir});
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 0;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(529, 25);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnKapat.Size = new System.Drawing.Size(109, 40);
            this.BtnKapat.TabIndex = 2;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "floppy_disk.png");
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKaydet.ImageOptions.ImageIndex = 1;
            this.BtnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.BtnKaydet.Location = new System.Drawing.Point(414, 24);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnKaydet.Size = new System.Drawing.Size(109, 40);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnKaydet);
            this.groupControl2.Controls.Add(this.BtnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 279);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(648, 69);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "Menü";
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
            this.LblBaslik.Size = new System.Drawing.Size(648, 50);
            this.LblBaslik.TabIndex = 23;
            this.LblBaslik.Text = "TOPLU FİYAT DEĞİŞTİR";
            // 
            // FrmFiyatDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 348);
            this.Controls.Add(this.FiyatDegistirGridControl);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.LblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiyatDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Fiyat Değişim Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTutari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiyatDegistir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiyatDegistirGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDegisimTutari;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimYonu;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimYonu;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colDegeri;
        private DevExpress.XtraGrid.Columns.GridColumn colKolonAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFiyatDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyatTuru;
        private DevExpress.XtraGrid.GridControl FiyatDegistirGridControl;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
    }
}