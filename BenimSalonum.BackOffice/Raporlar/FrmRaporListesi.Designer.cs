namespace BenimSalonum.BackOffice.Raporlar
{
    partial class FrmRaporListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporListesi));
            this.txtRaporGrubu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRaporAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtRaporAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageListRaporlar = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.Link_rptStokDurumu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.Link_rptStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.filterEditorControl1 = new DevExpress.DataAccess.UI.FilterEditorControl();
            this.filterEditorControl2 = new DevExpress.DataAccess.UI.FilterEditorControl();
            this.Link_rptUrunBazliStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRaporGrubu
            // 
            this.txtRaporGrubu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporGrubu.Location = new System.Drawing.Point(108, 53);
            this.txtRaporGrubu.Name = "txtRaporGrubu";
            this.txtRaporGrubu.Properties.ReadOnly = true;
            this.txtRaporGrubu.Size = new System.Drawing.Size(1020, 20);
            this.txtRaporGrubu.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(20, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Rapor Grubu :";
            // 
            // txtRaporAdi
            // 
            this.txtRaporAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporAdi.Location = new System.Drawing.Point(108, 27);
            this.txtRaporAdi.Name = "txtRaporAdi";
            this.txtRaporAdi.Properties.ReadOnly = true;
            this.txtRaporAdi.Size = new System.Drawing.Size(1020, 20);
            this.txtRaporAdi.TabIndex = 23;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl12.Location = new System.Drawing.Point(20, 27);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(82, 20);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Rapor Adı :";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl13.Location = new System.Drawing.Point(20, 78);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(82, 67);
            this.labelControl13.TabIndex = 22;
            this.labelControl13.Text = "Açıklama :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtRaporGrubu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtRaporAdi);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.txtRaporAciklama);
            this.groupControl1.Location = new System.Drawing.Point(216, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1140, 154);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Rapor Bilgileri";
            // 
            // txtRaporAciklama
            // 
            this.txtRaporAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporAciklama.Location = new System.Drawing.Point(108, 78);
            this.txtRaporAciklama.Name = "txtRaporAciklama";
            this.txtRaporAciklama.Properties.ReadOnly = true;
            this.txtRaporAciklama.Size = new System.Drawing.Size(1020, 67);
            this.txtRaporAciklama.TabIndex = 24;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 12;
            this.btnKapat.ImageOptions.ImageList = this.ımageListRaporlar;
            this.btnKapat.Location = new System.Drawing.Point(1250, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageListRaporlar
            // 
            this.ımageListRaporlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListRaporlar.ImageStream")));
            this.ımageListRaporlar.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListRaporlar.Images.SetKeyName(0, "add.png");
            this.ımageListRaporlar.Images.SetKeyName(1, "chart_area.png");
            this.ımageListRaporlar.Images.SetKeyName(2, "delete.png");
            this.ımageListRaporlar.Images.SetKeyName(3, "Düzenle.png");
            this.ımageListRaporlar.Images.SetKeyName(4, "funnel.png");
            this.ımageListRaporlar.Images.SetKeyName(5, "görüntüle.png");
            this.ımageListRaporlar.Images.SetKeyName(6, "Kriter.png");
            this.ımageListRaporlar.Images.SetKeyName(7, "note_pinned.png");
            this.ımageListRaporlar.Images.SetKeyName(8, "pencil.png");
            this.ımageListRaporlar.Images.SetKeyName(9, "Sil.png");
            this.ımageListRaporlar.Images.SetKeyName(10, "Süz.png");
            this.ımageListRaporlar.Images.SetKeyName(11, "view.png");
            this.ımageListRaporlar.Images.SetKeyName(12, "folder_out.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 5;
            this.btnEkle.ImageOptions.ImageList = this.ımageListRaporlar;
            this.btnEkle.Location = new System.Drawing.Point(12, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkle.Size = new System.Drawing.Size(184, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Rapor Görüntüle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 667);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1364, 69);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "Buton Menü";
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
            this.LblBaslik.TabIndex = 32;
            this.LblBaslik.Text = "RAPORLAR";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.Link_rptStokDurumu,
            this.navBarItem2,
            this.Link_rptStokHareketleri,
            this.navBarItem4,
            this.Link_rptUrunBazliStokHareketleri});
            this.navBarControl1.Location = new System.Drawing.Point(0, 50);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 216;
            this.navBarControl1.Size = new System.Drawing.Size(216, 617);
            this.navBarControl1.TabIndex = 35;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stok Raporları";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Link_rptStokDurumu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // Link_rptStokDurumu
            // 
            this.Link_rptStokDurumu.Caption = "Genel Stok Durumu Raporu";
            this.Link_rptStokDurumu.Name = "Link_rptStokDurumu";
            this.Link_rptStokDurumu.Tag = "Bu rapor stok giriş ve çıkış bilgilerini göstermektedir.";
            this.Link_rptStokDurumu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Click);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Stok Listesi Raporu";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Click);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Cari Raporları";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Genel Cari Bakiye Raporu";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Click);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Stok Hareket Raporları";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Link_rptStokHareketleri),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Link_rptUrunBazliStokHareketleri)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // Link_rptStokHareketleri
            // 
            this.Link_rptStokHareketleri.Caption = "Stok Hareket Raporu";
            this.Link_rptStokHareketleri.Name = "Link_rptStokHareketleri";
            this.Link_rptStokHareketleri.Tag = "Bu rapor stok hareketlerini listelemektedir.";
            this.Link_rptStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Click);
            // 
            // filterEditorControl1
            // 
            this.filterEditorControl1.ActiveView = DevExpress.XtraFilterEditor.FilterEditorActiveView.Visual;
            this.filterEditorControl1.AppearanceEmptyValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceFieldNameColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceGroupOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.filterEditorControl1.Name = "filterEditorControl1";
            this.filterEditorControl1.Size = new System.Drawing.Size(1364, 736);
            this.filterEditorControl1.TabIndex = 36;
            this.filterEditorControl1.Text = "filterEditorControl1";
            this.filterEditorControl1.UseMenuForOperandsAndOperators = false;
            // 
            // filterEditorControl2
            // 
            this.filterEditorControl2.ActiveView = DevExpress.XtraFilterEditor.FilterEditorActiveView.Visual;
            this.filterEditorControl2.AppearanceEmptyValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl2.AppearanceFieldNameColor = System.Drawing.Color.Empty;
            this.filterEditorControl2.AppearanceGroupOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl2.AppearanceOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl2.AppearanceValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl2.Location = new System.Drawing.Point(216, 201);
            this.filterEditorControl2.Name = "filterEditorControl2";
            this.filterEditorControl2.Size = new System.Drawing.Size(1140, 466);
            this.filterEditorControl2.TabIndex = 37;
            this.filterEditorControl2.Text = "filterEditorControl2";
            this.filterEditorControl2.UseMenuForOperandsAndOperators = false;
            // 
            // Link_rptUrunBazliStokHareketleri
            // 
            this.Link_rptUrunBazliStokHareketleri.Caption = "Ürün Bazlı Stok Hareketleri";
            this.Link_rptUrunBazliStokHareketleri.Name = "Link_rptUrunBazliStokHareketleri";
            this.Link_rptUrunBazliStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Click);
            // 
            // FrmRaporListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.filterEditorControl2);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.LblBaslik);
            this.Controls.Add(this.filterEditorControl1);
            this.Name = "FrmRaporListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktif Rapor Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRaporGrubu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRaporAdi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtRaporAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageListRaporlar;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem Link_rptStokDurumu;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem Link_rptStokHareketleri;
        private DevExpress.DataAccess.UI.FilterEditorControl filterEditorControl1;
        private DevExpress.DataAccess.UI.FilterEditorControl filterEditorControl2;
        private DevExpress.XtraNavBar.NavBarItem Link_rptUrunBazliStokHareketleri;
    }
}