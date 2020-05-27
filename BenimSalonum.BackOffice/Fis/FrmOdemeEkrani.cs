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
using BenimSalonum.Entities.Tables;
using BenimSalonum.BackOffice.Kasa;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Fis
{
    public partial class FrmOdemeEkrani : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        public KasaHareket entity;
        private Nullable<decimal> gelenTutar;
        private Nullable<decimal> odenecekgelenTutar;
        Entities.Tables.Kasa _kasabilgi;
        OdemeTuru _odemeTuruBilgi;
        public FrmOdemeEkrani(int odemeTuruId, Nullable<decimal> odenmesiGereken = null, Nullable<decimal> odenecekTutar = null)
        {
            InitializeComponent();
            int kasaId = Convert.ToInt32(context.KullaniciAyarlari.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).SatisAyarlari_VarsayilanKasa);


            _kasabilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);
            _odemeTuruBilgi = context.OdemeTurleri.SingleOrDefault(c => c.Id == odemeTuruId);

            txtOdemeTuru.Text = _odemeTuruBilgi.OdemeTuruAdi;
            txtKasaKodu.Text = _kasabilgi.KasaKodu;
            txtKasaAdi.Text = _kasabilgi.KasaAdi;

            if (odenmesiGereken != null)
            {
                gelenTutar = odenmesiGereken.Value;
                odenecekgelenTutar = odenecekTutar.Value;
            }
            else
            {
                txtTutar.Properties.Buttons[1].Visible = false;
            }
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                _kasabilgi = context.Kasalar.SingleOrDefault(c => c.Id == form.entity.Id);
                txtKasaKodu.Text = form.entity.KasaKodu;
                txtKasaAdi.Text = form.entity.KasaAdi;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string mesaj = null;
            int hata = 0;

            if (txtKasaAdi.Text == "" || txtKasaAdi.Text == null)
            {
                mesaj += "Kasa Bilgileri Boş Bırakılamaz." + System.Environment.NewLine;
                hata++;
            }
            if (txtTutar.Text == "" || txtTutar.Text == null)
            {
                mesaj += "Tutar Bilgileri Boş Bırakılamaz." + System.Environment.NewLine;
                hata++;
            }
            if (txtTutar.Value <= 0)
            {
                mesaj += "Tutar 0 ve 0 ' dan Küçük Olamaz." + System.Environment.NewLine;
                hata++;
            }

            if (txtTutar.Value > gelenTutar && gelenTutar != null)
            {
                mesaj += "Eklenen tutar ödenmesi gereken tutardan daha büyük olamaz." + System.Environment.NewLine;
                hata++;
            }

            if (hata != 0)
            {
                XtraMessageBox.Show(mesaj);
                return;
            }

            entity = new KasaHareket();
            entity.OdemeTuruId = _odemeTuruBilgi.Id;
            entity.KasaId = _kasabilgi.Id;
            entity.Tutar = txtTutar.Value;
            entity.Aciklama = txtAciklama.Text;
            this.Close();
        }

        private void txtTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                // txtTutar.Value = gelenTutar.Value; 
                txtTutar.Value = odenecekgelenTutar.Value;
            }
        }
    }
}