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
using BenimSalonum.Entities.Tools;
using BenimSalonum.BackOffice.Tanim;

namespace BenimSalonum.BackOffice.Stok
{
    public partial class FrmStokIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private BenimSalonumContext context = new BenimSalonumContext();
        public bool stokkayitedildi = false;
        CodeTool kodOlustur;
        public FrmStokIslem(Entities.Tables.Stok entity, bool kopyala = false)
        {
            InitializeComponent();

            kodOlustur = new CodeTool(this, CodeTool.Table.Stok);
            kodOlustur.barButonOlustur();

            if (kopyala)
            {
                _entity = new Entities.Tables.Stok();
                _entity.KullaniciID = entity.KullaniciID;
                _entity.Id = -1;
                _entity.Durumu = entity.Durumu;
                _entity.StokKodu = entity.StokKodu;
                _entity.StokAdi = entity.StokAdi;
                _entity.Barkod = entity.Barkod;
                _entity.BarkodTuru = entity.BarkodTuru;
                _entity.Birimi = entity.Birimi;
                _entity.StokGrubu = entity.StokGrubu;
                _entity.StokAltGrubu = entity.StokAltGrubu;
                _entity.Marka = entity.Marka;
                _entity.Modeli = entity.Modeli;
                _entity.OzelKod1 = entity.OzelKod1;
                _entity.OzelKod2 = entity.OzelKod2;
                _entity.OzelKod3 = entity.OzelKod3;
                _entity.OzelKod4 = entity.OzelKod4;
                _entity.GarantiSuresi = entity.GarantiSuresi;
                _entity.UreticiKodu = entity.UreticiKodu;
                _entity.AlisKdv = entity.AlisKdv;
                _entity.SatisKdv = entity.SatisKdv;
                _entity.AlisFiyati1 = entity.AlisFiyati1;
                _entity.AlisFiyati2 = entity.AlisFiyati2;
                _entity.AlisFiyati3 = entity.AlisFiyati3;
                _entity.SatisFiyati1 = entity.SatisFiyati1;
                _entity.SatisFiyati2 = entity.SatisFiyati2;
                _entity.SatisFiyati3 = entity.SatisFiyati3;
                _entity.MinStokMiktari = entity.MinStokMiktari;
                _entity.MaxStokMiktari = entity.MaxStokMiktari;
                _entity.Aciklama = entity.Aciklama;
                txtKod.Text = null;

            }
            else
            {
                _entity = entity;
                _entity.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
            }

            labelKullaniciID.DataBindings.Add("Text", _entity, "KullaniciID");
            txtDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtKod.DataBindings.Add("Text", _entity, "StokKodu");
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod");
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi");
            txtBirimi.DataBindings.Add("Text", _entity, "Birimi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu");
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi");
            calcMaxStok.DataBindings.Add("Text", _entity, "MaxStokMiktari");
            calcMaxStok.DataBindings[0].FormattingEnabled = true;
            calcMaxStok.DataBindings[0].FormatString = "N3";
            calcMinStok.DataBindings.Add("Text", _entity, "MinStokMiktari");
            calcMinStok.DataBindings[0].FormattingEnabled = true;
            calcMinStok.DataBindings[0].FormatString = "N3";
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            txtStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            txtMarka.DataBindings.Add("Text", _entity, "Marka");
            txtModel.DataBindings.Add("Text", _entity, "Modeli");
            txtOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            txtOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            txtOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            txtOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");
            calcAlisKdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcAlisKdv.DataBindings[0].FormattingEnabled = true;
            calcAlisKdv.DataBindings[0].FormatString = "'%'0";
            calcAlisKdv.DataBindings[0].DataSourceNullValue = "0";
            calcSatisKdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcSatisKdv.DataBindings[0].FormattingEnabled = true;
            calcSatisKdv.DataBindings[0].FormatString = "'%'0";
            calcSatisKdv.DataBindings[0].DataSourceNullValue = "0";
            calcAlisFiyat1.DataBindings.Add("Text", _entity, "AlisFiyati1");
            calcAlisFiyat1.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyat1.DataBindings[0].FormatString = "C2";
            calcAlisFiyat2.DataBindings.Add("Text", _entity, "AlisFiyati2");
            calcAlisFiyat2.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyat2.DataBindings[0].FormatString = "C2";
            calcAlisFiyat3.DataBindings.Add("Text", _entity, "AlisFiyati3");
            calcAlisFiyat3.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyat3.DataBindings[0].FormatString = "C2";
            calcSatisFiyat1.DataBindings.Add("Text", _entity, "SatisFiyati1");
            calcSatisFiyat1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat1.DataBindings[0].FormatString = "C2";
            calcSatisFiyat2.DataBindings.Add("Text", _entity, "SatisFiyati2");
            calcSatisFiyat2.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat2.DataBindings[0].FormatString = "C2";
            calcSatisFiyat3.DataBindings.Add("Text", _entity, "SatisFiyati3");
            calcSatisFiyat3.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat3.DataBindings[0].FormatString = "C2";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (stokDal.AddOrUpDate(context, _entity))
            {
                kodOlustur.KodArttirma();
                stokDal.Save(context);
                stokkayitedildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBirimi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.Birimi);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtBirimi.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtBirimi.Text = null;
                    break;
            }
        }

        private void txtStokGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokGrubu);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtStokGrubu.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtStokGrubu.Text = null;
                    break;
            }
        }

        private void txtStokAltGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokAltGrubu);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtStokAltGrubu.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtStokAltGrubu.Text = null;
                    break;
            }
        }

        private void txtMarka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.Marka);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtMarka.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtMarka.Text = null;
                    break;
            }
        }

        private void txtModel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.Model);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtModel.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtModel.Text = null;
                    break;
            }
        }

        private void txtOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod1);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod1.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod1.Text = null;
                    break;
            }
        }

        private void txtOzelKod2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod2);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod2.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod2.Text = null;
                    break;
            }
        }

        private void txtOzelKod3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod3);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod3.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod3.Text = null;
                    break;
            }
        }

        private void txtOzelKod4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod4);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod4.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod4.Text = null;
                    break;
            }
        }

        private void txtGarantiSuresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}