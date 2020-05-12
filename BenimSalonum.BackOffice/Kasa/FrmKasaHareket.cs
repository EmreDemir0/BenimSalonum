﻿using System;
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

namespace BenimSalonum.BackOffice.Kasa
{
    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        private int _kasaId;
        public FrmKasaHareket(int kasaId)
        {
            InitializeComponent();
            _kasaId = kasaId;
            var kasaBilgi = context.Kasalar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == kasaId);
            LblBaslik.Text = kasaBilgi.KasaKodu + " - " + kasaBilgi.KasaAdi + " Hareketleri";
        }
        public void Guncelle()
        {
            gridcontKasaHareket.DataSource = kasaHareketDal.GetALL(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == _kasaId);
            gridcontOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaId);
            gridcontGenelToplam.DataSource = kasaDal.GenelToplamListele(context, _kasaId);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}