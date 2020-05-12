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
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        private string secilen;
        public FrmKullanicilar()
        {
            InitializeComponent();
            Guncelle();
        }
        public void Guncelle()
        {
            GridControlKullanici.DataSource = kullaniciDal.GetALL(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslem form = new FrmKullaniciIslem(new Kullanici());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (GridViewKullanici.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenlenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = GridViewKullanici.GetFocusedRowCellValue(colKullaniciAdi).ToString();
                FrmKullaniciIslem form = new FrmKullaniciIslem(kullaniciDal.GetByFilter(context, c => c.KullaniciAdi == secilen));
                form.ShowDialog();
                if (form.saved)
                {
                    Guncelle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (GridViewKullanici.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Silinecek Kayıt Bulunamadı.");
            }
            else
            {
                if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    secilen = Convert.ToInt32(GridViewKullanici.GetFocusedRowCellValue(colId)).ToString();
                    if (secilen.ToString()=="1")
                    {
                        XtraMessageBox.Show("Yönetici Kullanıcısını Silemezsiniz.");
                    }
                    else
                    {
                        kullaniciDal.Delete(context, c => c.KullaniciID.ToString() == secilen);
                        kullaniciDal.Save(context);
                        Guncelle();
                    }                  
                }
            }
        }
    }
}