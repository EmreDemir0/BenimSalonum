namespace BenimSalonum.BackOffice.İndirim
{
    partial class FrmIndirimIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndirimIslem));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.groupControlTarih = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBitis = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.dateBaslangic = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.btnSinirli = new DevExpress.XtraEditors.CheckButton();
            this.btnSuresiz = new DevExpress.XtraEditors.CheckButton();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.IndirimlerGridControl = new DevExpress.XtraGrid.GridControl();
            this.IndirimlerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnCikar = new DevExpress.XtraEditors.SimpleButton();
            this.imgIndirim = new System.Windows.Forms.ImageList(this.components);
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTarih)).BeginInit();
            this.groupControlTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.CalendarTimeProperties)).BeginInit();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndirimlerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndirimlerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelText = "İptal";
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.FinishText = "&Bitir";
            this.wizardControl1.HelpText = "&Yardım";
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "&İleri >";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.PreviousText = "< &Geri";
            this.wizardControl1.Size = new System.Drawing.Size(945, 638);
            this.wizardControl1.Text = "İndirim Sihirbazı";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.groupControlTarih);
            this.welcomeWizardPage1.Controls.Add(this.btnSinirli);
            this.welcomeWizardPage1.Controls.Add(this.btnSuresiz);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(885, 471);
            this.welcomeWizardPage1.Text = "Sihirbaza Hoşgeldiniz , Lütfen İndirimin Geçerli Olacağı Zamanı Seçiniz.";
            // 
            // groupControlTarih
            // 
            this.groupControlTarih.Controls.Add(this.label3);
            this.groupControlTarih.Controls.Add(this.txtAciklama);
            this.groupControlTarih.Controls.Add(this.label2);
            this.groupControlTarih.Controls.Add(this.label1);
            this.groupControlTarih.Controls.Add(this.dateBitis);
            this.groupControlTarih.Controls.Add(this.dateBaslangic);
            this.groupControlTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlTarih.Location = new System.Drawing.Point(0, 168);
            this.groupControlTarih.Name = "groupControlTarih";
            this.groupControlTarih.Size = new System.Drawing.Size(885, 303);
            this.groupControlTarih.TabIndex = 6;
            this.groupControlTarih.Text = "Tarih Seçimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(467, 61);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(413, 235);
            this.txtAciklama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi ";
            // 
            // dateBitis
            // 
            this.dateBitis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBitis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitis.Location = new System.Drawing.Point(236, 61);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(232, 235);
            this.dateBitis.TabIndex = 0;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBaslangic.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslangic.Location = new System.Drawing.Point(5, 61);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(232, 235);
            this.dateBaslangic.TabIndex = 0;
            // 
            // btnSinirli
            // 
            this.btnSinirli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSinirli.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSinirli.Appearance.Options.UseFont = true;
            this.btnSinirli.GroupIndex = 1;
            this.btnSinirli.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinirli.ImageOptions.Image")));
            this.btnSinirli.Location = new System.Drawing.Point(248, 1);
            this.btnSinirli.Name = "btnSinirli";
            this.btnSinirli.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSinirli.Size = new System.Drawing.Size(196, 140);
            this.btnSinirli.TabIndex = 4;
            this.btnSinirli.TabStop = false;
            this.btnSinirli.Text = "Sınırlı";
            // 
            // btnSuresiz
            // 
            this.btnSuresiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSuresiz.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSuresiz.Appearance.Options.UseFont = true;
            this.btnSuresiz.GroupIndex = 1;
            this.btnSuresiz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuresiz.ImageOptions.Image")));
            this.btnSuresiz.Location = new System.Drawing.Point(450, 1);
            this.btnSuresiz.Name = "btnSuresiz";
            this.btnSuresiz.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSuresiz.Size = new System.Drawing.Size(220, 140);
            this.btnSuresiz.TabIndex = 5;
            this.btnSuresiz.TabStop = false;
            this.btnSuresiz.Text = "Süresiz";
            this.btnSuresiz.CheckedChanged += new System.EventHandler(this.btnSuresiz_CheckedChanged);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.IndirimlerGridControl);
            this.wizardPage1.Controls.Add(this.groupControl3);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(885, 471);
            // 
            // IndirimlerGridControl
            // 
            this.IndirimlerGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndirimlerGridControl.Location = new System.Drawing.Point(0, 0);
            this.IndirimlerGridControl.MainView = this.IndirimlerGridView;
            this.IndirimlerGridControl.Name = "IndirimlerGridControl";
            this.IndirimlerGridControl.Size = new System.Drawing.Size(885, 402);
            this.IndirimlerGridControl.TabIndex = 8;
            this.IndirimlerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.IndirimlerGridView});
            // 
            // IndirimlerGridView
            // 
            this.IndirimlerGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.IndirimlerGridView.GridControl = this.IndirimlerGridControl;
            this.IndirimlerGridView.Name = "IndirimlerGridView";
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
            this.colDurumu.Width = 143;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 143;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            this.colBarkod.Width = 143;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 143;
            // 
            // colIndirimTuru
            // 
            this.colIndirimTuru.FieldName = "IndirimTuru";
            this.colIndirimTuru.Name = "colIndirimTuru";
            this.colIndirimTuru.OptionsColumn.AllowEdit = false;
            this.colIndirimTuru.Width = 143;
            // 
            // colBaslangicTarihi
            // 
            this.colBaslangicTarihi.FieldName = "BaslangicTarihi";
            this.colBaslangicTarihi.Name = "colBaslangicTarihi";
            this.colBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslangicTarihi.Width = 143;
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.Width = 143;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 3;
            this.colIndirimOrani.Width = 143;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Width = 156;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnCikar);
            this.groupControl3.Controls.Add(this.BtnEkle);
            this.groupControl3.Controls.Add(this.BtnAra);
            this.groupControl3.Controls.Add(this.BtnGuncelle);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 402);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(885, 69);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Buton Menü";
            // 
            // BtnCikar
            // 
            this.BtnCikar.ImageOptions.ImageIndex = 9;
            this.BtnCikar.ImageOptions.ImageList = this.imgIndirim;
            this.BtnCikar.Location = new System.Drawing.Point(117, 26);
            this.BtnCikar.Name = "BtnCikar";
            this.BtnCikar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnCikar.Size = new System.Drawing.Size(99, 40);
            this.BtnCikar.TabIndex = 1;
            this.BtnCikar.Text = "Çıkar";
            this.BtnCikar.Click += new System.EventHandler(this.BtnCikar_Click);
            // 
            // imgIndirim
            // 
            this.imgIndirim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIndirim.ImageStream")));
            this.imgIndirim.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIndirim.Images.SetKeyName(0, "floppy_disk.png");
            this.imgIndirim.Images.SetKeyName(1, "navigate_minus.png");
            this.imgIndirim.Images.SetKeyName(2, "refresh.png");
            this.imgIndirim.Images.SetKeyName(3, "view.png");
            this.imgIndirim.Images.SetKeyName(4, "funnel.png");
            this.imgIndirim.Images.SetKeyName(5, "funnel_delete.png");
            this.imgIndirim.Images.SetKeyName(6, "add.png");
            this.imgIndirim.Images.SetKeyName(7, "clock_run.png");
            this.imgIndirim.Images.SetKeyName(8, "delete.png");
            this.imgIndirim.Images.SetKeyName(9, "düzenle.png");
            this.imgIndirim.Images.SetKeyName(10, "ekle.png");
            this.imgIndirim.Images.SetKeyName(11, "folder_out.png");
            this.imgIndirim.Images.SetKeyName(12, "pencil.png");
            this.imgIndirim.Images.SetKeyName(13, "remotecontrol2.png");
            this.imgIndirim.Images.SetKeyName(14, "replace2.png");
            this.imgIndirim.Images.SetKeyName(15, "sil.png");
            this.imgIndirim.Images.SetKeyName(16, "sort_descending.png");
            this.imgIndirim.Images.SetKeyName(17, "stopwatch_run.png");
            this.imgIndirim.Images.SetKeyName(18, "view.png");
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.ImageIndex = 10;
            this.BtnEkle.ImageOptions.ImageList = this.imgIndirim;
            this.BtnEkle.Location = new System.Drawing.Point(12, 26);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnEkle.Size = new System.Drawing.Size(99, 40);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.ImageOptions.ImageIndex = 3;
            this.BtnAra.ImageOptions.ImageList = this.imgIndirim;
            this.BtnAra.Location = new System.Drawing.Point(337, 26);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnAra.Size = new System.Drawing.Size(109, 40);
            this.BtnAra.TabIndex = 2;
            this.BtnAra.Text = "Ara";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.ImageIndex = 2;
            this.BtnGuncelle.ImageOptions.ImageList = this.imgIndirim;
            this.BtnGuncelle.Location = new System.Drawing.Point(222, 26);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(885, 471);
            this.completionWizardPage1.Text = "Seçilen Ürüne İndirim Tanımlama İşlemi Başarıyla Tamamlandı. ";
            // 
            // FrmIndirimIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 638);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmIndirimIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTarih)).EndInit();
            this.groupControlTarih.ResumeLayout(false);
            this.groupControlTarih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.CalendarTimeProperties)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IndirimlerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndirimlerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private System.Windows.Forms.ImageList imgIndirim;
        private DevExpress.XtraEditors.GroupControl groupControlTarih;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Controls.CalendarControl dateBitis;
        private DevExpress.XtraEditors.Controls.CalendarControl dateBaslangic;
        private DevExpress.XtraEditors.CheckButton btnSinirli;
        private DevExpress.XtraEditors.CheckButton btnSuresiz;
        private DevExpress.XtraGrid.GridControl IndirimlerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView IndirimlerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnCikar;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
    }
}