namespace BenimSalonum.BackOffice.Hızlı_Satış
{
    partial class FrmHizliSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHizliSatis));
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.grpUrunMEnu = new DevExpress.XtraEditors.GroupControl();
            this.btnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.colHizliSatisGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewUrunEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlUrunEkle = new DevExpress.XtraGrid.GridControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.grpGrupMenu = new DevExpress.XtraEditors.GroupControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.grpGrupBilgi = new System.Windows.Forms.GroupBox();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewGrupEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlGrupEkle = new DevExpress.XtraGrid.GridControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpUrunMEnu)).BeginInit();
            this.grpUrunMEnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupMenu)).BeginInit();
            this.grpGrupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            this.grpGrupBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.ImageOptions.ImageIndex = 3;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEkle.Location = new System.Drawing.Point(5, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkle.Size = new System.Drawing.Size(99, 40);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "add.png");
            this.ımageList1.Images.SetKeyName(4, "floppy_disk_delete.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKapat.Location = new System.Drawing.Point(369, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // grpUrunMEnu
            // 
            this.grpUrunMEnu.Controls.Add(this.btnEkle);
            this.grpUrunMEnu.Controls.Add(this.btnUrunSil);
            this.grpUrunMEnu.Controls.Add(this.btnKapat);
            this.grpUrunMEnu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpUrunMEnu.Location = new System.Drawing.Point(0, 674);
            this.grpUrunMEnu.Name = "grpUrunMEnu";
            this.grpUrunMEnu.Size = new System.Drawing.Size(490, 69);
            this.grpUrunMEnu.TabIndex = 50;
            this.grpUrunMEnu.Text = " Menü";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunSil.ImageOptions.ImageIndex = 2;
            this.btnUrunSil.ImageOptions.ImageList = this.ımageList1;
            this.btnUrunSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUrunSil.Location = new System.Drawing.Point(110, 24);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUrunSil.Size = new System.Drawing.Size(99, 40);
            this.btnUrunSil.TabIndex = 0;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // colHizliSatisGrup
            // 
            this.colHizliSatisGrup.Caption = "GrupId";
            this.colHizliSatisGrup.FieldName = "GrupId";
            this.colHizliSatisGrup.Name = "colHizliSatisGrup";
            this.colHizliSatisGrup.Visible = true;
            this.colHizliSatisGrup.VisibleIndex = 2;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 0;
            // 
            // gridViewUrunEkle
            // 
            this.gridViewUrunEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkod,
            this.colUrunAdi,
            this.colHizliSatisGrup});
            this.gridViewUrunEkle.GridControl = this.gridControlUrunEkle;
            this.gridViewUrunEkle.Name = "gridViewUrunEkle";
            this.gridViewUrunEkle.OptionsBehavior.ReadOnly = true;
            this.gridViewUrunEkle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // gridControlUrunEkle
            // 
            this.gridControlUrunEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunEkle.Location = new System.Drawing.Point(0, 0);
            this.gridControlUrunEkle.MainView = this.gridViewUrunEkle;
            this.gridControlUrunEkle.Name = "gridControlUrunEkle";
            this.gridControlUrunEkle.Size = new System.Drawing.Size(490, 674);
            this.gridControlUrunEkle.TabIndex = 51;
            this.gridControlUrunEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUrunEkle});
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.ImageIndex = 2;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSil.Location = new System.Drawing.Point(108, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Enabled = false;
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(223, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKaydet.Size = new System.Drawing.Size(99, 40);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVazgec.Enabled = false;
            this.btnVazgec.ImageOptions.ImageIndex = 4;
            this.btnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.btnVazgec.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnVazgec.Location = new System.Drawing.Point(328, 24);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnVazgec.Size = new System.Drawing.Size(109, 40);
            this.btnVazgec.TabIndex = 2;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.ImageOptions.ImageIndex = 3;
            this.btnYeni.ImageOptions.ImageList = this.ımageList1;
            this.btnYeni.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnYeni.Location = new System.Drawing.Point(7, 25);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnYeni.Size = new System.Drawing.Size(99, 40);
            this.btnYeni.TabIndex = 3;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // grpGrupMenu
            // 
            this.grpGrupMenu.Controls.Add(this.btnYeni);
            this.grpGrupMenu.Controls.Add(this.btnSil);
            this.grpGrupMenu.Controls.Add(this.btnKaydet);
            this.grpGrupMenu.Controls.Add(this.btnVazgec);
            this.grpGrupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpGrupMenu.Location = new System.Drawing.Point(0, 674);
            this.grpGrupMenu.Name = "grpGrupMenu";
            this.grpGrupMenu.Size = new System.Drawing.Size(449, 69);
            this.grpGrupMenu.TabIndex = 50;
            this.grpGrupMenu.Text = " Menü";
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Options.UseTextOptions = true;
            this.labelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl28.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl28.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl28.Location = new System.Drawing.Point(12, 20);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(60, 20);
            this.labelControl28.TabIndex = 26;
            this.labelControl28.Text = "Grup Adı :";
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Enabled = false;
            this.txtGrupAdi.Location = new System.Drawing.Point(78, 20);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Size = new System.Drawing.Size(142, 20);
            this.txtGrupAdi.TabIndex = 25;
            // 
            // grpGrupBilgi
            // 
            this.grpGrupBilgi.Controls.Add(this.labelControl28);
            this.grpGrupBilgi.Controls.Add(this.txtGrupAdi);
            this.grpGrupBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrupBilgi.Location = new System.Drawing.Point(0, 0);
            this.grpGrupBilgi.Name = "grpGrupBilgi";
            this.grpGrupBilgi.Size = new System.Drawing.Size(449, 51);
            this.grpGrupBilgi.TabIndex = 51;
            this.grpGrupBilgi.TabStop = false;
            this.grpGrupBilgi.Text = "Grup Bilgileri";
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 1;
            this.colGrupAdi.Width = 212;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 84;
            // 
            // gridViewGrupEkle
            // 
            this.gridViewGrupEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGrupAdi});
            this.gridViewGrupEkle.GridControl = this.gridControlGrupEkle;
            this.gridViewGrupEkle.Name = "gridViewGrupEkle";
            this.gridViewGrupEkle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGrupEkle_FocusedRowChanged);
            // 
            // gridControlGrupEkle
            // 
            this.gridControlGrupEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGrupEkle.Location = new System.Drawing.Point(0, 51);
            this.gridControlGrupEkle.MainView = this.gridViewGrupEkle;
            this.gridControlGrupEkle.Name = "gridControlGrupEkle";
            this.gridControlGrupEkle.Size = new System.Drawing.Size(449, 623);
            this.gridControlGrupEkle.TabIndex = 52;
            this.gridControlGrupEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGrupEkle});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControlGrupEkle);
            this.splitContainer1.Panel1.Controls.Add(this.grpGrupBilgi);
            this.splitContainer1.Panel1.Controls.Add(this.grpGrupMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlUrunEkle);
            this.splitContainer1.Panel2.Controls.Add(this.grpUrunMEnu);
            this.splitContainer1.Size = new System.Drawing.Size(943, 743);
            this.splitContainer1.SplitterDistance = 449;
            this.splitContainer1.TabIndex = 52;
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
            this.LblBaslik.Size = new System.Drawing.Size(943, 60);
            this.LblBaslik.TabIndex = 51;
            this.LblBaslik.Text = "HIZLI SATIŞ ÜRÜN VE GRUP TANIMLAMA";
            // 
            // FrmHizliSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 803);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.LblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHizliSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Satış Ürün ve Grup Tanımlama";
            ((System.ComponentModel.ISupportInitialize)(this.grpUrunMEnu)).EndInit();
            this.grpUrunMEnu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupMenu)).EndInit();
            this.grpGrupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            this.grpGrupBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGrupEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrupEkle)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl grpUrunMEnu;
        private DevExpress.XtraEditors.SimpleButton btnUrunSil;
        private DevExpress.XtraGrid.Columns.GridColumn colHizliSatisGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunEkle;
        private DevExpress.XtraGrid.GridControl gridControlUrunEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.GroupControl grpGrupMenu;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private System.Windows.Forms.GroupBox grpGrupBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGrupEkle;
        private DevExpress.XtraGrid.GridControl gridControlGrupEkle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
    }
}