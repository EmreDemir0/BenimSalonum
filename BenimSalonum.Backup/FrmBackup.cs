using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BenimSalonum.Backup
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        public FrmBackup()
        {
            InitializeComponent();

            txtYedekKonum.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);

        }
        //BURADA SETTİNGS TOOLA AYRI AYRI KAYDETTİĞİMİZ DB ADINI KULLAN.
        //HERKESTE ARI TEPKİ VERMESİ İÇİN DB ADINI VERİTABANINDA TUTARAKTA OKUTABİLİRİZ.
        private void btnGeriYukleme_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "BenimSalonum *.nsy|*.nsy";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string sqlCumle =
                    $"USE master;ALTER DATABASE NetSatis SET SINGLE USER WITH ROLLBACK IMMEDIATE;ALTER DATABASE NetSatis SET READ ONLY;RESTORE DATABASE NetSatis FROM DISK='{dialog.FileName}';ALTER DATABASE NetSatis SET MILTI_USER";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
            }
        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtYedekKonum.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu, txtYedekKonum.Text);
                SettingsTool.Kaydet();
            }
        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            string sqlcumle = $"USE NetSatis;BACKUP DATABASE NetSatis TO DISK ='{txtYedekKonum.Text + "\\" + DateTime.Now.ToShortDateString() + " NetSatisBackup.bak"}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlcumle);
        }
    }
}
