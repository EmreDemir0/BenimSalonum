namespace BenimSalonum.BackOffice.Fis
{
    partial class FrmTahsilat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTahsilat));
            this.LblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtFirma = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.calcNakit = new DevExpress.XtraEditors.CalcEdit();
            this.calcCek = new DevExpress.XtraEditors.CalcEdit();
            this.calcSenet = new DevExpress.XtraEditors.CalcEdit();
            this.calcKrediK = new DevExpress.XtraEditors.CalcEdit();
            this.calcToplamUst = new DevExpress.XtraEditors.CalcEdit();
            this.calcToplamAlt = new DevExpress.XtraEditors.CalcEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.txtMakbuzNo = new DevExpress.XtraEditors.TextEdit();
            this.btnCariSec = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.calcBorc = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcNakit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcCek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSenet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKrediK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcToplamUst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcToplamAlt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakbuzNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBorc.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.LblBaslik.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LblBaslik.ImageOptions.SvgImage")));
            this.LblBaslik.Location = new System.Drawing.Point(0, 0);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(990, 50);
            this.LblBaslik.TabIndex = 28;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(225, 247);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtFirma.Properties.Appearance.Options.UseFont = true;
            this.txtFirma.Size = new System.Drawing.Size(729, 30);
            this.txtFirma.TabIndex = 29;
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(269, 552);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPersonel.Properties.Appearance.Options.UseFont = true;
            this.txtPersonel.Size = new System.Drawing.Size(258, 30);
            this.txtPersonel.TabIndex = 30;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Enabled = false;
            this.dateEdit1.Location = new System.Drawing.Point(225, 207);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(195, 30);
            this.dateEdit1.TabIndex = 37;
            // 
            // calcNakit
            // 
            this.calcNakit.Location = new System.Drawing.Point(761, 57);
            this.calcNakit.Name = "calcNakit";
            this.calcNakit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.calcNakit.Properties.Appearance.Options.UseFont = true;
            this.calcNakit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcNakit.Properties.Mask.EditMask = "C2";
            this.calcNakit.Size = new System.Drawing.Size(193, 30);
            this.calcNakit.TabIndex = 38;
            this.calcNakit.ValueChanged += new System.EventHandler(this.calcNakit_ValueChanged);
            // 
            // calcCek
            // 
            this.calcCek.Location = new System.Drawing.Point(761, 95);
            this.calcCek.Name = "calcCek";
            this.calcCek.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.calcCek.Properties.Appearance.Options.UseFont = true;
            this.calcCek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcCek.Properties.Mask.EditMask = "C2";
            this.calcCek.Size = new System.Drawing.Size(193, 30);
            this.calcCek.TabIndex = 39;
            this.calcCek.ValueChanged += new System.EventHandler(this.calcCek_ValueChanged);
            // 
            // calcSenet
            // 
            this.calcSenet.Location = new System.Drawing.Point(761, 133);
            this.calcSenet.Name = "calcSenet";
            this.calcSenet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.calcSenet.Properties.Appearance.Options.UseFont = true;
            this.calcSenet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcSenet.Properties.Mask.EditMask = "C2";
            this.calcSenet.Size = new System.Drawing.Size(193, 30);
            this.calcSenet.TabIndex = 40;
            this.calcSenet.ValueChanged += new System.EventHandler(this.calcSenet_ValueChanged);
            // 
            // calcKrediK
            // 
            this.calcKrediK.Location = new System.Drawing.Point(761, 171);
            this.calcKrediK.Name = "calcKrediK";
            this.calcKrediK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.calcKrediK.Properties.Appearance.Options.UseFont = true;
            this.calcKrediK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcKrediK.Properties.Mask.EditMask = "C2";
            this.calcKrediK.Size = new System.Drawing.Size(193, 30);
            this.calcKrediK.TabIndex = 41;
            this.calcKrediK.ValueChanged += new System.EventHandler(this.calcKrediK_ValueChanged);
            // 
            // calcToplamUst
            // 
            this.calcToplamUst.Location = new System.Drawing.Point(761, 208);
            this.calcToplamUst.Name = "calcToplamUst";
            this.calcToplamUst.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.calcToplamUst.Properties.Appearance.Options.UseFont = true;
            this.calcToplamUst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcToplamUst.Properties.Mask.EditMask = "C2";
            this.calcToplamUst.Size = new System.Drawing.Size(193, 30);
            this.calcToplamUst.TabIndex = 42;
            this.calcToplamUst.ValueChanged += new System.EventHandler(this.calcToplamUst_ValueChanged);
            // 
            // calcToplamAlt
            // 
            this.calcToplamAlt.Enabled = false;
            this.calcToplamAlt.Location = new System.Drawing.Point(269, 588);
            this.calcToplamAlt.Name = "calcToplamAlt";
            this.calcToplamAlt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.calcToplamAlt.Properties.Appearance.Options.UseFont = true;
            this.calcToplamAlt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcToplamAlt.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.calcToplamAlt.Properties.Mask.EditMask = "C2";
            this.calcToplamAlt.Size = new System.Drawing.Size(686, 30);
            this.calcToplamAlt.TabIndex = 44;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(269, 552);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Muhasebe",
            "Halil Demir",
            "Hasan Çağlar",
            "Yakup Demir",
            "Yiğit Usta"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(258, 30);
            this.comboBoxEdit1.TabIndex = 45;
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(844, 624);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(111, 38);
            this.btnKapat.TabIndex = 46;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(550, 624);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKaydet.Size = new System.Drawing.Size(154, 38);
            this.btnKaydet.TabIndex = 46;
            this.btnKaydet.Text = "MAİL GÖNDER";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.ImageOptions.Image")));
            this.btnYazdir.Location = new System.Drawing.Point(710, 624);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnYazdir.Size = new System.Drawing.Size(128, 38);
            this.btnYazdir.TabIndex = 47;
            this.btnYazdir.Text = "ÖNİZLE & YAZDIR";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtMakbuzNo
            // 
            this.txtMakbuzNo.Location = new System.Drawing.Point(109, 161);
            this.txtMakbuzNo.Name = "txtMakbuzNo";
            this.txtMakbuzNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtMakbuzNo.Properties.Appearance.Options.UseFont = true;
            this.txtMakbuzNo.Size = new System.Drawing.Size(311, 40);
            this.txtMakbuzNo.TabIndex = 48;
            // 
            // btnCariSec
            // 
            this.btnCariSec.Appearance.ForeColor = System.Drawing.Color.Tomato;
            this.btnCariSec.Appearance.Options.UseForeColor = true;
            this.btnCariSec.Location = new System.Drawing.Point(109, 244);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(110, 37);
            this.btnCariSec.TabIndex = 49;
            this.btnCariSec.Text = "FİRMA ADI SEÇ";
            this.btnCariSec.Click += new System.EventHandler(this.btnCariSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(105, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "BORÇ :";
            // 
            // calcBorc
            // 
            this.calcBorc.Location = new System.Drawing.Point(191, 628);
            this.calcBorc.Name = "calcBorc";
            this.calcBorc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.calcBorc.Properties.Appearance.Options.UseFont = true;
            this.calcBorc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBorc.Properties.Mask.EditMask = "C2";
            this.calcBorc.Size = new System.Drawing.Size(193, 30);
            this.calcBorc.TabIndex = 51;
            // 
            // FrmTahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(990, 664);
            this.Controls.Add(this.calcBorc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariSec);
            this.Controls.Add(this.txtMakbuzNo);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.calcToplamAlt);
            this.Controls.Add(this.calcToplamUst);
            this.Controls.Add(this.calcKrediK);
            this.Controls.Add(this.calcSenet);
            this.Controls.Add(this.calcCek);
            this.Controls.Add(this.calcNakit);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.txtPersonel);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.LblBaslik);
            this.Name = "FrmTahsilat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahsilat";
            ((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcNakit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcCek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSenet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKrediK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcToplamUst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcToplamAlt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakbuzNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBorc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblBaslik;
        private DevExpress.XtraEditors.TextEdit txtFirma;
        private DevExpress.XtraEditors.TextEdit txtPersonel;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.CalcEdit calcNakit;
        private DevExpress.XtraEditors.CalcEdit calcCek;
        private DevExpress.XtraEditors.CalcEdit calcSenet;
        private DevExpress.XtraEditors.CalcEdit calcKrediK;
        private DevExpress.XtraEditors.CalcEdit calcToplamUst;
        private DevExpress.XtraEditors.CalcEdit calcToplamAlt;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
        private DevExpress.XtraEditors.TextEdit txtMakbuzNo;
        private DevExpress.XtraEditors.SimpleButton btnCariSec;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CalcEdit calcBorc;
    }
}