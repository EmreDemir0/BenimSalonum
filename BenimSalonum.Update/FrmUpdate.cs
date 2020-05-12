using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BenimSalonum.Update
{
    public partial class FrmUpdate : DevExpress.XtraEditors.XtraForm
    {
        WebClient indir = new WebClient();
        public static bool IsRunning(string ProgramAdi)
        {//döndürülen değer 0 dan büyükse program çalısıyor demektir.
            return Process.GetProcessesByName(ProgramAdi).Length > 0;
        }
        public FrmUpdate()
        {
            InitializeComponent();
            if (IsRunning("BenimSalonum.BackOffice"))
            {
                if (MessageBox.Show("Güncelleme işleminden önce açık olan uygulamaların kapatılması gerekiyor. Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("BenimSalonum.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }

                }
                else
                {
                    foreach (var process in Process.GetProcessesByName("BenimSalonum.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                    foreach (var process in Process.GetProcessesByName("BenimSalonum.Admin"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                    foreach (var process in Process.GetProcessesByName("BenimSalonum.Update"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\temp"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            }
            indir.DownloadProgressChanged += (DownloadProgressChangedEventHandler)IndirmeDurumu;
            indir.DownloadFileCompleted += (AsyncCompletedEventHandler)IndirmeBitti;
            indir.DownloadFileAsync(new Uri("http:localhost/Update.zip"), Application.StartupPath + "\\temp\\Update.zip");
            btnGuncelle.Enabled = false;
        }

        private void IndirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            label1.Text = "İndirme Tamamlandı.";
            btnGuncelle.Enabled = true;
            ZipFile.ExtractToDirectory(Application.StartupPath + "\\temp\\Update.zip", Application.StartupPath + "\\temp");
            XElement Dosyalar = XElement.Load(Application.StartupPath + "\\temp\\Liste.xml");
            foreach (var veriler in Dosyalar.Elements().ToList())
            {
                if (File.Exists(Application.StartupPath + "\\temp\\" + veriler.Element("YuklenecegiKonum").Value))
                {
                    File.Delete(Application.StartupPath + "\\temp\\" + veriler.Element("YuklenecegiKonum").Value);
                }
                File.Copy(Application.StartupPath + "\\temp\\" + veriler.Element("DosyaAdi").Value,
                    Application.StartupPath + veriler.Element("YuklenecegiKonum").Value);
            }
            Directory.Delete(Application.StartupPath + "\\temp", true);
            MessageBox.Show("Güncelleme Tamamlandı.");
            this.Close();
        }

        public void IndirmeDurumu(object sender, DownloadProgressChangedEventArgs e)
        {
            decimal bayt = 0.00000095367432M;
            decimal filesize = progressFile.Properties.Maximum = (int)e.TotalBytesToReceive;
            decimal downloadfilesize = (int)e.BytesReceived;
            downloadfilesize = downloadfilesize * bayt;
            filesize = filesize * bayt;
            label1.Text = "İndirilen Dosya : " + Math.Round(downloadfilesize, 2) + " / " + Math.Round(filesize, 2) + " MB";
            progressFile.Text = Convert.ToString(e.BytesReceived);
        }
    }
}
