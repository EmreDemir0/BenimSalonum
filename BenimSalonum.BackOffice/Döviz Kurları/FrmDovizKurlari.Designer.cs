namespace BenimSalonum.BackOffice.Döviz_Kurları
{
    partial class FrmDovizKurlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDovizKurlari));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblUyari2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.gridControDoviz = new DevExpress.XtraGrid.GridControl();
            this.gridViewDoviz = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanknotBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanknotSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timerDoviz = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControDoviz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoviz)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblUyari2);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 647);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(846, 70);
            this.groupControl2.TabIndex = 49;
            this.groupControl2.Text = " Menü";
            // 
            // lblUyari2
            // 
            this.lblUyari2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblUyari2.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyari2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblUyari2.ImageOptions.Image")));
            this.lblUyari2.Location = new System.Drawing.Point(0, 21);
            this.lblUyari2.Name = "lblUyari2";
            this.lblUyari2.Size = new System.Drawing.Size(53, 52);
            this.lblUyari2.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(636, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncelle.Size = new System.Drawing.Size(99, 45);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKapat.Location = new System.Drawing.Point(735, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 45);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.LblBaslik.Size = new System.Drawing.Size(846, 73);
            this.LblBaslik.TabIndex = 48;
            this.LblBaslik.Text = "DÖVİZ KURLARI";
            // 
            // gridControDoviz
            // 
            this.gridControDoviz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControDoviz.Location = new System.Drawing.Point(0, 73);
            this.gridControDoviz.MainView = this.gridViewDoviz;
            this.gridControDoviz.Name = "gridControDoviz";
            this.gridControDoviz.Size = new System.Drawing.Size(846, 644);
            this.gridControDoviz.TabIndex = 50;
            this.gridControDoviz.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDoviz});
            // 
            // gridViewDoviz
            // 
            this.gridViewDoviz.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurrencyCode,
            this.colIsim,
            this.colForexBuying,
            this.colForexSelling,
            this.colBanknotBuying,
            this.colBanknotSelling});
            this.gridViewDoviz.GridControl = this.gridControDoviz;
            this.gridViewDoviz.Name = "gridViewDoviz";
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "Döviz Adı";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 0;
            this.colCurrencyCode.Width = 90;
            // 
            // colIsim
            // 
            this.colIsim.Caption = "Döviz Sembolü";
            this.colIsim.FieldName = "Isim";
            this.colIsim.Name = "colIsim";
            this.colIsim.Visible = true;
            this.colIsim.VisibleIndex = 1;
            this.colIsim.Width = 108;
            // 
            // colForexBuying
            // 
            this.colForexBuying.Caption = "Forex Buying";
            this.colForexBuying.FieldName = "ForexBuying";
            this.colForexBuying.Name = "colForexBuying";
            this.colForexBuying.Visible = true;
            this.colForexBuying.VisibleIndex = 2;
            this.colForexBuying.Width = 156;
            // 
            // colForexSelling
            // 
            this.colForexSelling.Caption = "Forex Selling";
            this.colForexSelling.FieldName = "ForexSelling";
            this.colForexSelling.Name = "colForexSelling";
            this.colForexSelling.Visible = true;
            this.colForexSelling.VisibleIndex = 3;
            this.colForexSelling.Width = 93;
            // 
            // colBanknotBuying
            // 
            this.colBanknotBuying.Caption = "Banknot Buying";
            this.colBanknotBuying.FieldName = "BanknoteBuying";
            this.colBanknotBuying.Name = "colBanknotBuying";
            this.colBanknotBuying.Visible = true;
            this.colBanknotBuying.VisibleIndex = 4;
            this.colBanknotBuying.Width = 103;
            // 
            // colBanknotSelling
            // 
            this.colBanknotSelling.Caption = "Banknot Selling";
            this.colBanknotSelling.FieldName = "BanknoteSelling";
            this.colBanknotSelling.Name = "colBanknotSelling";
            this.colBanknotSelling.Visible = true;
            this.colBanknotSelling.VisibleIndex = 5;
            this.colBanknotSelling.Width = 278;
            // 
            // timerDoviz
            // 
            this.timerDoviz.Interval = 50000;
            this.timerDoviz.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 717);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControDoviz);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmDovizKurlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TC Merkez Bankası Döviz Kurları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControDoviz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoviz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblUyari2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraGrid.GridControl gridControDoviz;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDoviz;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colForexBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colForexSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colBanknotBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colBanknotSelling;
        public System.Windows.Forms.Timer timerDoviz;
    }
}