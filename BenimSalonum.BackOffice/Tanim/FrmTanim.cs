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
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Tanim
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        public Entities.Tables.Tanim _entitiy;
        TanimDAL tanimDal = new TanimDAL();
        private TanimTuru _tanimTuru;
        public bool Secildi = false;
        public FrmTanim(TanimTuru tanimTuru)
        {
            InitializeComponent();
            _tanimTuru = tanimTuru;
        }
        void KayitAc()
        {
            btnSec.Enabled = false;
            btnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage1;
            txtTanim.DataBindings.Add("Text", _entitiy, "Tanimi");
            txtAciklama.DataBindings.Add("Text", _entitiy, "Aciklama");
        }
        void KayitKapat()
        {
            btnSec.Enabled = true;
            btnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage2;
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
        }
        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            CariOzelKod1,
            CariOzelKod2,
            CariOzelKod3,
            CariOzelKod4,
            Birimi,
            StokGrubu,
            StokAltGrubu,
            Marka,
            Model,
            StokOzelKod1,
            StokOzelKod2,
            StokOzelKod3,
            StokOzelKod4,
            PersonelUnvani
        }
        void Listele()
        {
            gridControlTanim.DataSource = tanimDal.GetALL(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Turu == _tanimTuru.ToString());
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTanim_Load(object sender, EventArgs e)
        {
            Listele();
            if (gridTanim.RowCount == 0)
            {
                btnSec.Enabled = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _entitiy = new Entities.Tables.Tanim();
            KayitAc();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridTanim.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenlenecek Kayıt Bulunamadı.");
            }
            else
            {
                int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                _entitiy = context.Tanimlar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen).SingleOrDefault();
                KayitAc();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridTanim.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Silinecek Kayıt Bulunamadı.");
            }
            else
            {
                if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                    tanimDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                    tanimDal.Save(context);
                    Listele();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _entitiy.Turu = _tanimTuru.ToString();
            _entitiy.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
            if (tanimDal.AddOrUpDate(context, _entitiy))
            {
                tanimDal.Save(context);
                KayitKapat();
                Listele();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridTanim.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Seçilecek Kayıt Bulunamadı.");
            }
            else
            {
                int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                _entitiy = context.Tanimlar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen).SingleOrDefault();
                Secildi = true;
                this.Close();
            }
        }

        private void FrmTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void gridTanim_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = gridTanim.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Tanım Sayısı : " + satirsayisi;
        }
    }
}