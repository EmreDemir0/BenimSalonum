namespace BenimSalonum.BackOffice
{
    partial class FrmRehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRehber));
            this.RehberGridControl = new DevExpress.XtraGrid.GridControl();
            this.RehberGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuRehber = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.RehberGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RehberGridView)).BeginInit();
            this.contextMenuRehber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RehberGridControl
            // 
            this.RehberGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RehberGridControl.Location = new System.Drawing.Point(0, 0);
            this.RehberGridControl.MainView = this.RehberGridView;
            this.RehberGridControl.Name = "RehberGridControl";
            this.RehberGridControl.Size = new System.Drawing.Size(1364, 667);
            this.RehberGridControl.TabIndex = 4;
            this.RehberGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RehberGridView});
            // 
            // RehberGridView
            // 
            this.RehberGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colCariKodu,
            this.colCariAdi,
            this.colFaturaUnvani,
            this.colCepTelefonu,
            this.colEMail});
            this.RehberGridView.GridControl = this.RehberGridControl;
            this.RehberGridView.Name = "RehberGridView";
            this.RehberGridView.OptionsView.ColumnAutoWidth = false;
            this.RehberGridView.RowCountChanged += new System.EventHandler(this.RehberGridView_RowCountChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            // 
            // colCariKodu
            // 
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 1;
            this.colCariKodu.Width = 103;
            // 
            // colCariAdi
            // 
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 2;
            this.colCariAdi.Width = 272;
            // 
            // colFaturaUnvani
            // 
            this.colFaturaUnvani.FieldName = "FaturaUnvani";
            this.colFaturaUnvani.Name = "colFaturaUnvani";
            this.colFaturaUnvani.OptionsColumn.AllowEdit = false;
            this.colFaturaUnvani.Visible = true;
            this.colFaturaUnvani.VisibleIndex = 3;
            this.colFaturaUnvani.Width = 401;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            // 
            // colEMail
            // 
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.OptionsColumn.AllowEdit = false;
            this.colEMail.Visible = true;
            this.colEMail.VisibleIndex = 4;
            this.colEMail.Width = 588;
            // 
            // contextMenuRehber
            // 
            this.contextMenuRehber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEkle,
            this.toolStripMenuItemGuncelle});
            this.contextMenuRehber.Name = "contextMenuStrip1";
            this.contextMenuRehber.Size = new System.Drawing.Size(157, 48);
            // 
            // toolStripMenuItemEkle
            // 
            this.toolStripMenuItemEkle.Name = "toolStripMenuItemEkle";
            this.toolStripMenuItemEkle.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemEkle.Text = "E-Posta Gönder";
            this.toolStripMenuItemEkle.Click += new System.EventHandler(this.toolStripMenuItemEkle_Click);
            // 
            // toolStripMenuItemGuncelle
            // 
            this.toolStripMenuItemGuncelle.Name = "toolStripMenuItemGuncelle";
            this.toolStripMenuItemGuncelle.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemGuncelle.Text = "Güncelle";
            this.toolStripMenuItemGuncelle.Click += new System.EventHandler(this.toolStripMenuItemGuncelle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblUyari);
            this.groupControl2.Controls.Add(this.btnGonder);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 667);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1364, 69);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Menü";
            // 
            // lblUyari
            // 
            this.lblUyari.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUyari.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblUyari.Appearance.Image")));
            this.lblUyari.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyari.Appearance.Options.UseFont = true;
            this.lblUyari.Appearance.Options.UseImage = true;
            this.lblUyari.Appearance.Options.UseImageAlign = true;
            this.lblUyari.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUyari.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblUyari.Location = new System.Drawing.Point(4, 19);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(510, 48);
            this.lblUyari.TabIndex = 4;
            this.lblUyari.Text = "Çoklu Seçim Yapabilmek İçin Ctrl Tuşunu Basılı Tutarak Seçiminizi Yapabilirsiniz." +
    "";
            this.lblUyari.Visible = false;
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGonder.ImageOptions.ImageIndex = 0;
            this.btnGonder.Location = new System.Drawing.Point(1135, 25);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGonder.Size = new System.Drawing.Size(109, 40);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.Location = new System.Drawing.Point(1250, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.ContextMenuStrip = this.contextMenuRehber;
            this.Controls.Add(this.RehberGridControl);
            this.Controls.Add(this.groupControl2);
            this.Name = "FrmRehber";
            this.Text = "FrmRehber";
            ((System.ComponentModel.ISupportInitialize)(this.RehberGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RehberGridView)).EndInit();
            this.contextMenuRehber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl RehberGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView RehberGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private System.Windows.Forms.ContextMenuStrip contextMenuRehber;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuncelle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblUyari;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}