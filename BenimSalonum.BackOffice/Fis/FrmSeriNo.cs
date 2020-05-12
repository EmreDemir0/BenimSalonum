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

namespace BenimSalonum.BackOffice.Fis
{
    public partial class FrmSeriNo : DevExpress.XtraEditors.XtraForm
    {
        public string veriSeriNo;
        public FrmSeriNo(string veri, bool kilitli = true)
        {
            InitializeComponent();
            if (veri != null)
            {
                string[] veriListesi = veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in veriListesi)
                {
                    listSeriNo.Items.Add(item);
                }
            }
            if (kilitli)
            {
                //groupControl2.Enabled = false;
                btnEkle.Enabled = false;
                btnSil.Enabled = false;
                btnKaydet.Enabled = false;
                btnVazgec.Enabled = false;
            }
        }
        void KayitAc()
        {
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            groupBox1.Enabled = true;
            txtSeriNo.Focus();
        }
        void KayitKapat()
        {
            btnEkle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            groupBox1.Enabled = false;
            txtSeriNo.Text = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitAc();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Remove(listSeriNo.SelectedItem);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Add(txtSeriNo.Text);
            KayitKapat();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();

        }

        private void FrmSeriNo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listSeriNo.Items.Count != 0)
            {
                foreach (var item in listSeriNo.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine; ;
                }
            }
        }
    }
}