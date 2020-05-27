namespace BenimSalonum.BackOffice.Tanim
{
    partial class FrmTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTanim));
            this.txtTanimTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTanim = new DevExpress.XtraEditors.TextEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlTanim = new DevExpress.XtraGrid.GridControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageListTanim = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanimTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).BeginInit();
            this.navigationPage2.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTanimTuru
            // 
            this.txtTanimTuru.Location = new System.Drawing.Point(94, 46);
            this.txtTanimTuru.Name = "txtTanimTuru";
            this.txtTanimTuru.Size = new System.Drawing.Size(690, 20);
            this.txtTanimTuru.TabIndex = 34;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(6, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Tanım Türü :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(6, 72);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(82, 47);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Açıklama :";
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(94, 20);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(690, 20);
            this.txtTanim.TabIndex = 30;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(94, 72);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(690, 328);
            this.txtAciklama.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTanimTuru);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.txtTanim);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tanımlar";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(6, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 20);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Tanım :";
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 655;
            // 
            // colTanim
            // 
            this.colTanim.Caption = "Tanım";
            this.colTanim.FieldName = "Tanimi";
            this.colTanim.Name = "colTanim";
            this.colTanim.OptionsColumn.AllowEdit = false;
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 0;
            this.colTanim.Width = 123;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridTanim
            // 
            this.gridTanim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTanim,
            this.colAciklama});
            this.gridTanim.GridControl = this.gridControlTanim;
            this.gridTanim.Name = "gridTanim";
            this.gridTanim.OptionsView.ShowGroupPanel = false;
            this.gridTanim.RowCountChanged += new System.EventHandler(this.gridTanim_RowCountChanged);
            // 
            // gridControlTanim
            // 
            this.gridControlTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTanim.Location = new System.Drawing.Point(0, 0);
            this.gridControlTanim.MainView = this.gridTanim;
            this.gridControlTanim.Name = "gridControlTanim";
            this.gridControlTanim.Size = new System.Drawing.Size(801, 409);
            this.gridControlTanim.TabIndex = 27;
            this.gridControlTanim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTanim});
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.gridControlTanim);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(801, 409);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 0;
            this.btnEkle.ImageOptions.ImageList = this.ımageListTanim;
            this.btnEkle.Location = new System.Drawing.Point(127, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkle.Size = new System.Drawing.Size(99, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageListTanim
            // 
            this.ımageListTanim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListTanim.ImageStream")));
            this.ımageListTanim.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListTanim.Images.SetKeyName(0, "add.png");
            this.ımageListTanim.Images.SetKeyName(1, "books_blue.png");
            this.ımageListTanim.Images.SetKeyName(2, "checkbox.png");
            this.ımageListTanim.Images.SetKeyName(3, "delete.png");
            this.ımageListTanim.Images.SetKeyName(4, "floppy_disk.png");
            this.ımageListTanim.Images.SetKeyName(5, "floppy_disk_delete.png");
            this.ımageListTanim.Images.SetKeyName(6, "folder_out.png");
            this.ımageListTanim.Images.SetKeyName(7, "pencil.png");
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.ImageIndex = 6;
            this.btnKapat.ImageOptions.ImageList = this.ımageListTanim;
            this.btnKapat.Location = new System.Drawing.Point(682, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(109, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.ImageIndex = 4;
            this.btnKaydet.ImageOptions.ImageList = this.ımageListTanim;
            this.btnKaydet.Location = new System.Drawing.Point(452, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKaydet.Size = new System.Drawing.Size(109, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.ImageOptions.ImageIndex = 5;
            this.btnVazgec.ImageOptions.ImageList = this.ımageListTanim;
            this.btnVazgec.Location = new System.Drawing.Point(567, 24);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnVazgec.Size = new System.Drawing.Size(109, 40);
            this.btnVazgec.TabIndex = 2;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 3;
            this.btnSil.ImageOptions.ImageList = this.ımageListTanim;
            this.btnSil.Location = new System.Drawing.Point(337, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.groupBox1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(801, 409);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 7;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageListTanim;
            this.btnDuzenle.Location = new System.Drawing.Point(232, 24);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDuzenle.Size = new System.Drawing.Size(99, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSec
            // 
            this.btnSec.ImageOptions.ImageIndex = 2;
            this.btnSec.ImageOptions.ImageList = this.ımageListTanim;
            this.btnSec.Location = new System.Drawing.Point(12, 24);
            this.btnSec.Name = "btnSec";
            this.btnSec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSec.Size = new System.Drawing.Size(109, 40);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 50);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage1});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.Size = new System.Drawing.Size(801, 409);
            this.navigationFrame1.TabIndex = 29;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSec);
            this.groupControl2.Controls.Add(this.btnDuzenle);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Controls.Add(this.btnVazgec);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 459);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(801, 69);
            this.groupControl2.TabIndex = 28;
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
            this.LblBaslik.Size = new System.Drawing.Size(801, 50);
            this.LblBaslik.TabIndex = 27;
            this.LblBaslik.Text = "TANIMLAR";
            // 
            // FrmTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 528);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.LblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Tanım Ekle & Düzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTanim_FormClosing);
            this.Load += new System.EventHandler(this.FrmTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTanimTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTanimTuru;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTanim;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTanim;
        private DevExpress.XtraGrid.GridControl gridControlTanim;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.ImageList ımageListTanim;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl LblBaslik;
    }
}