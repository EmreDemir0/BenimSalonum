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
    public partial class FrmKullaniciIslem : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        private Kullanici _entity;
        public bool saved = false;
        private string parola, cevap;
        public FrmKullaniciIslem(Kullanici entity)
        {
            InitializeComponent();
            treeList1.ExpandAll();
            if (_entity != null)
            {
                parola = _entity.Parola;
                cevap = _entity.HatirlatmaCevap;

                _entity.HatirlatmaCevap = null;
                _entity.Parola = null;
            }
            _entity = entity;
            _entity.KullaniciID = entity.KullaniciID;

            labelKullaniciID.DataBindings.Add("Text", _entity, "KullaniciID");
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            toggleAktif.DataBindings.Add("EditValue", _entity, "Aktif");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtParola.DataBindings.Add("Text", _entity, "Parola", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _entity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtHatirlatma.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "HatirlatmaCevap", false, DataSourceUpdateMode.OnPropertyChanged);
            //_entity.KullaniciAdi = "Toprak";
            AyarYukle();
        }
        private void AyarYukle()
        {
            if (!string.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList())
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }
        private void Kaydet()
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++)
            {
                for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++)
                {
                    if (context.KullaniciRolleri.Count(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j) == 0)
                    {//!=0
                        context.KullaniciRolleri.Add(new KullaniciRol
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
                            KontrolAdi = treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
                            RootId = i,
                            ParentId = j,
                            Yetki = treeList1.Nodes[i].Nodes[j].Checked
                        });
                    }
                    else
                    {
                        context.KullaniciRolleri.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki = treeList1.Nodes[i].Nodes[j].Checked;
                    }
                }
            }
            context.SaveChanges();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPasifYap_Click(object sender, EventArgs e)
        { 
                context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == _entity.KullaniciAdi).Aktif = false;
            try
            {
                context.SaveChanges();
                toggleAktif.IsOn = false;
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_entity.Parola))
            {
                txtParola.Text = parola;
                txtParola.Text = parola;
            }
            if (string.IsNullOrEmpty(_entity.HatirlatmaCevap))
            {
                txtCevap.Text = cevap;

            }
            if (txtParola.Text != txtParolaTekrar.Text)
            {
                XtraMessageBox.Show("Parola ve Parola Tekrar Alanlarında Uyuşmazlık.");
            }
            else
            {
                if (_entity.KayitTarihi == null)
                {
                    _entity.KayitTarihi = DateTime.Now;
                }
                if (kullaniciDal.AddOrUpDate(context, _entity))
                {
                    Kaydet();
                    saved = true;
                    this.Close();
                }
            }
        }
    }
}