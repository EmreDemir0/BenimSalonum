namespace BenimSalonum.Admin
{
    partial class FrmDonemSec
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
            this.btnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.spinDonem = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinDonem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(12, 108);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(128, 108);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // spinDonem
            // 
            this.spinDonem.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDonem.Location = new System.Drawing.Point(12, 12);
            this.spinDonem.Name = "spinDonem";
            this.spinDonem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.spinDonem.Properties.Appearance.Options.UseFont = true;
            this.spinDonem.Properties.Appearance.Options.UseTextOptions = true;
            this.spinDonem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.spinDonem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDonem.Properties.IsFloatValue = false;
            this.spinDonem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinDonem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinDonem.Size = new System.Drawing.Size(192, 46);
            this.spinDonem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen Oluşturmak \r\nİstediğiniz Dönemi Seçiniz.";
            // 
            // FrmDonemSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 139);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinDonem);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnOlustur);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDonemSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.spinDonem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOlustur;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SpinEdit spinDonem;
        private System.Windows.Forms.Label label1;
    }
}