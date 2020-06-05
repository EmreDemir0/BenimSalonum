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
using BenimSalonum.Entities.Tools;
using BenimSalonum.Reports.Fatura_ve_Fiş;
using BenimSalonum.Entities.Context;
using BenimSalonum.BackOffice.Rehber;
using DevExpress.XtraCharts.Designer.Native;
using BenimSalonum.BackOffice.Cari;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.DataAccess;

namespace BenimSalonum.BackOffice.Fis
{
    public partial class FrmTahsilat : DevExpress.XtraEditors.XtraForm
    {
        public FrmTahsilat()
        {
            InitializeComponent();
            dateEdit1.EditValue = DateTime.Now;
        }
        string hedefPosta;
        private decimal toplamTutar = 0;


        private void calcNakit_ValueChanged(object sender, EventArgs e)
        {
            toplamTutar = calcNakit.Value + calcCek.Value + calcKrediK.Value + calcSenet.Value;
            calcToplamUst.Value = toplamTutar;
        }

        private void calcCek_ValueChanged(object sender, EventArgs e)
        {
            toplamTutar = calcNakit.Value + calcCek.Value + calcKrediK.Value + calcSenet.Value;
            calcToplamUst.Value = toplamTutar;
        }

        private void calcSenet_ValueChanged(object sender, EventArgs e)
        {
            toplamTutar = calcNakit.Value + calcCek.Value + calcKrediK.Value + calcSenet.Value;
            calcToplamUst.Value = toplamTutar;
        }

        private void calcKrediK_ValueChanged(object sender, EventArgs e)
        {
            toplamTutar = calcNakit.Value + calcCek.Value + calcKrediK.Value + calcSenet.Value;
            calcToplamUst.Value = toplamTutar;
        }

        private void calcToplamUst_ValueChanged(object sender, EventArgs e)
        {
            calcToplamAlt.Value = calcToplamUst.Value;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BenimSalonumContext context = new BenimSalonumContext();
        ReportsPrintTool yazdir = new ReportsPrintTool();
        rptTahsilat fatura = new rptTahsilat();
        CariBakiye _entityBakiye = new CariBakiye();
        CariDAL cariDal = new CariDAL();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string path = @"D:\makbuz\" + txtMakbuzNo.Text+".pdf";
            fatura.ExportToPdf(path);
            FrmMailGonder frmMailGonder = new FrmMailGonder(true);

            if (!string.IsNullOrEmpty(hedefPosta))
            {
                frmMailGonder.mailGonder(path, hedefPosta);
            }
            else
            {
                //gönderilecek posta bulunmadı de ve tekrar dene ufak bi formdan veri alıp.
            }


            //mail atarken cari seçerse o carinin epostası gelsin otomatik yoksa elle eposta girmek zorunda kalır.

            //PARAMETRE OLARAK FİŞ KODU GÖNDERKİ REPORTTA ÇEKSİN VERİLERİ
            // CONTEXE KAYDET ÖDEME FİŞİ GİRMEKLE AYNI SADECE ŞUNU KONTROL ET EĞER CARİ SEÇERSE ÖDEME FİŞİ SEÇMEZSE 
            //TAHSİLAT DİYE BİRŞEY Mİ OLUSTURURZ NAPARIZ BİLMİYORUM.
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            //tahsilat makbuuz için yazıcı ayarı yap.
            yazdir.RaporYazdir(fatura, ReportsPrintTool.Belge.Fatura, context.KullaniciAyarlari.FirstOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID));
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.Secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                _entityBakiye = this.cariDal.CariBakiyesi(context, entity.Id);
                txtFirma.Text = entity.CariKodu + " / " + entity.FaturaUnvani;
                calcBorc.Text = _entityBakiye.Borc.ToString("C2")+"-"+calcToplamAlt.Text;
                hedefPosta = entity.EMail;
            }
        }
    }
}