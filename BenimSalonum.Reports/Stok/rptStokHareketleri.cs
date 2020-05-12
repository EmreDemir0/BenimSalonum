using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Context;
using DevExpress.DataAccess.ObjectBinding;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Reports.Stok
{
    public partial class rptStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        
        public rptStokHareketleri()
        {
            InitializeComponent();
            BenimSalonumContext context = new BenimSalonumContext();

            StokHareketDAL stokHareketDal = new StokHareketDAL();

            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetALL(context) };
            this.DataSource = stokDataSource;

            colFisKodu.DataBindings.Add("Text", this.DataAdapter, "FisKodu");
            colHareket.DataBindings.Add("Text", this.DataAdapter, "Hareket");
            colStokKodu.DataBindings.Add("Text", this.DataAdapter, "StokKodu");
            colBarkod.DataBindings.Add("Text", this.DataAdapter, "Barkod");
            colStokAdi.DataBindings.Add("Text", this.DataAdapter, "StokAdi");
            colBirimFiyat.DataBindings.Add("Text", this.DataAdapter, "BirimFiyati");
            colMiktar.DataBindings.Add("Text", this.DataAdapter, "Miktar");
            colKdv.DataBindings.Add("Text", this.DataAdapter, "Kdv");
            colIndirim.DataBindings.Add("Text", this.DataAdapter, "IndirimOrani");
            KullaniciAdi.Text = RoleTool.kullaniciEntity.KullaniciAdi;
        }

    }
}
