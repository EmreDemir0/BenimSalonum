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
using System.Net;
using System.IO;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Döviz_Kurları
{
    public partial class FrmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public FrmDovizKurlari()
        {
            InitializeComponent();
            FileInfo info = new FileInfo(Application.StartupPath + "\\Kurlar.xml");
            lblUyari2.Text = "Son Güncelleme Tarihi : " + info.LastWriteTime.ToString();
            Guncelle(false);
        }

        private void Guncelle(bool indir = true)
        {
            if (indir)
            {
                using (WebClient kurDownload = new WebClient())
                {
                    kurDownload.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                }
                lblUyari2.Text = "Son Güncelleme Tarihi : " + DateTime.Now.ToString();
            }
            ExchangeTool doviz = new ExchangeTool();
            gridControDoviz.DataSource = doviz.DovizKuruCek();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}