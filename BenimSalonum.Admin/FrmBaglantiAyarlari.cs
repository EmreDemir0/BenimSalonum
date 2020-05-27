using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Admin
{
    public partial class FrmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        public bool kayitedildi = false;
        public FrmBaglantiAyarlari()
        {
            InitializeComponent();
            txtServerAdi.Text = "DESKTOP-KESCC\\SQLEXPRESS";
            txtKullaniciAdi.Text = "sa";
            txtParola.Text = "Emre1502.";
            checkSql.Checked = true;
        }
        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.DataSource = txtServerAdi.Text;
            connectionStringBuilder.InitialCatalog = "master";
            if (checkWindows.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionStringBuilder.UserID = txtKullaniciAdi.Text;
                connectionStringBuilder.Password = txtParola.Text;
                connectionStringBuilder.IntegratedSecurity = false;
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";

            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
                labelControl6.Text = "Durum : Sunucu ile Bağlantı Başarılı.";
                btnKaydet.Visible = true;
            }
            else
            {
                labelControl6.Text = "Durum : Sunucu ile Bağlantı Başarısız.";
            }
        }

        private void FrmBaglantiAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kayitedildi)
            {
                XtraMessageBox.Show("Uygulamada bağlantı cümlesi olmadığından kapatılacaktır.");
                Application.Exit();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";

            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
                labelControl6.Text = "Durum : Sunucu ile Bağlantı Başarılı.";
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DataBaseAyarlari_BaglantiCumlesi, connectionStringBuilder.ConnectionString);
                SettingsTool.Kaydet();
                kayitedildi = true;
                this.Close();
            }
            else
            {
                labelControl6.Text = "Durum : Sunucu ile Bağlantı Başarısız.";
            }
        }

        private void checkWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSql.Checked)
            {
                txtParola.Enabled = true;
                txtKullaniciAdi.Enabled = true;
            }
            else
            {
                txtParola.Enabled = false;
                txtKullaniciAdi.Enabled = false;
            }
        }

        private void btnDevir_Click(object sender, EventArgs e)
        {
            FrmDevir frmDevir = new FrmDevir();
            frmDevir.ShowDialog();        }
    }
}