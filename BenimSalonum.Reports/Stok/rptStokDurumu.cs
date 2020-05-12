using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Reports.Stok
{
    public partial class rptStokDurumu : DevExpress.XtraReports.UI.XtraReport
    {

        public rptStokDurumu()
        {
            InitializeComponent();

            BenimSalonumContext context = new BenimSalonumContext();

            StokDAL stokDal = new StokDAL();

            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokDal.StokListele(context) };
            this.DataSource = stokDataSource;

            colStokKodu.DataBindings.Add("Text", this.DataAdapter, "StokKodu");
            colStokAdi.DataBindings.Add("Text", this.DataAdapter, "StokAdi");
            colBarkod.DataBindings.Add("Text", this.DataAdapter, "Barkod");
            colBirimi.DataBindings.Add("Text", this.DataAdapter, "Birimi");
            colStokKdv.DataBindings.Add("Text", this.DataAdapter, "SatisKdv");
            colStokGiris.DataBindings.Add("Text", this.DataAdapter, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataAdapter, "StokCikis");
            colMevcutStok.DataBindings.Add("Text", this.DataAdapter, "MevcutStok");

            KullaniciAdi.Text = RoleTool.kullaniciEntity.KullaniciAdi;
        }
    }
}
