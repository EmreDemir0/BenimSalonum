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
using System.Reflection;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;

namespace BenimSalonum.BackOffice.Raporlar
{
    public partial class FrmRaporListesi : DevExpress.XtraEditors.XtraForm
    {
        XtraReport rapor;
        public FrmRaporListesi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmRaporGoruntule form = new FrmRaporGoruntule(rapor);
            rapor.FilterString = filterEditorControl2.FilterString;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        //YENİ OLUŞTURUDUGUMU SEKMENİN ADINI LİNK _ YAPIP ADINI RAPORUN FRM ADINI YAZIYORUZ
        //İTEMLİNK ÖZELLİĞİNEDE ALTTAKİ CLİCK METODUNU YÖNLENDİRİYİROUZ.
        private void navBarLink_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            filterEditorControl2.FilterString = null;

            var buton = sender as NavBarItem;

            Type tip = Assembly.Load("BenimSalonum.Reports").GetTypes()
                .SingleOrDefault(c => c.Name == buton.Name.Replace("Link_", ""));

            rapor = (XtraReport)Activator.CreateInstance(tip);

            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtRaporAciklama.Text = buton.Tag.ToString() == null ? txtRaporAciklama.Text = null : txtRaporAciklama.Text = buton.Tag.ToString();

            filterEditorControl2.SourceControl = rapor.DataSource;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}