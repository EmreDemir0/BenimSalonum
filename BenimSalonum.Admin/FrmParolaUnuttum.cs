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
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Admin
{
    public partial class FrmParolaUnuttum : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        Kullanici _entity;
        public FrmParolaUnuttum(string kullaniciAdi)
        {
            InitializeComponent();
            _entity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == kullaniciAdi);
            txtHatirlatma.Text = _entity.HatirlatmaSorusu;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_entity.HatirlatmaCevap == txtCevap.Text)
            {
                if (txtParola.Text == txtParolaTekrar.Text)
                {
                    _entity.Parola = txtParola.Text;
                    kullaniciDal.AddOrUpDate(context, _entity);
                    context.SaveChanges();
                    XtraMessageBox.Show("Parolanız Başarıyla Değiştirildi.");
                }
                else
                {
                    XtraMessageBox.Show("Girilen Parolalar Uyuşmuyor");
                    txtParola.Text = null;
                    txtParolaTekrar.Text = null;
                }
            }
            else
            {
                XtraMessageBox.Show("Hatırlatma Sorusu Cevabı Yanlış");
            }
            //Hata verirse tek if olabilir.
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}