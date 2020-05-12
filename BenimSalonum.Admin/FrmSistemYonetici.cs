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

namespace BenimSalonum.Admin
{
    public partial class FrmSistemYonetici : DevExpress.XtraEditors.XtraForm
    {
        public FrmSistemYonetici()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtSistemParola.Text == "Emre")
            {
                FrmBaglantiAyarlari form = new FrmBaglantiAyarlari();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Bu Alana Sadece Sistem Yöneticisi Erişim İzni Vardır.");
                this.Close();
            }
        }
    }
}