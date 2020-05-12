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
using System.Net;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Sms
{
    public partial class FrmSms : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        CariDAL cariDal = new CariDAL();
        List<Entities.Tables.Cari> cariList = new List<Entities.Tables.Cari>();

        public FrmSms()
        {
            InitializeComponent();
            gridControl1.DataSource = cariDal.CariTelefonlari(context);
            gridControl2.DataSource = cariList.Where(c=>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID);
            checkButton1.Checked = false;
            checkButton2.Checked = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colListeCepTelefonu) != null)
            {
                cariList.Add(new Entities.Tables.Cari
                {
                    CariKodu = gridView1.GetFocusedRowCellValue(colListeCariKodu).ToString(),
                    CariAdi = gridView1.GetFocusedRowCellValue(colListeCariAdi).ToString(),
                    CepTelefonu = gridView1.GetFocusedRowCellValue(colListeCepTelefonu).ToString()
                });
                gridView2.RefreshData();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        private void txtMesaj_EditValueChanged(object sender, EventArgs e)
        {
            lblKarakterSayisi.Text = "Karakter Sayısı :" + txtMesaj.Text.Length + " \\ " + "Mesaj Adeti :" +
                         (txtMesaj.Text.Length / 160 + 1);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string tur = "Normal";

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string gonderilecekNumaralar = null;
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gonderilecekNumaralar += (gridView2.GetRowCellValue(i, colCepTelefonu) + ",").ToString();
            }

            try
            {
                gonderilecekNumaralar += gonderilecekNumaralar.Substring(0, gonderilecekNumaralar.Length - 1);
            }
            catch (Exception)
            {
            }

            if (checkButton2.Checked == true)
            {
                tur = "Turkce";
            }

            if (checkButton1.Checked == true)
            {
                tur = "Normal";
            }

            if (checkButton1.Checked == true || checkButton2.Checked == true)
            {
                string GonderilecekVeri = "data=<sms><kno>" + txtKullaniciNo.Text + "</kno>" +
                                          "<kulad>" + txtKullaniciAdi.Text + "</kulad>" +
                                          "<sifre>" + txtSifre.Text + "</sifre>" +
                                          "<gonderen>" + txtOrjinator.Text + "</gonderen>" +
                                          "<mesaj>" + txtMesaj.Text + "</mesaj>" +
                                          "<numaralar>" + gonderilecekNumaralar + "</numaralar>" +
                                          "<tur>" + tur + "</tur></sms>";
                label1.Text = XmlPost("http://panel.vatansms.com/panel/smsgonder1Npost.php", GonderilecekVeri);
            }
            else
            {
                MessageBox.Show("Gönderilecek Mesaj Türünü Seçiniz Normal/Türkçe");
            }
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            string smsozet = "data=<smsrapor><kulad>" + txtKullaniciAdi.Text + "</kulad>" +
                  "<sifre>" + txtSifre.Text + "</sifre></smsrapor>";
            MessageBox.Show(XmlPost("http://panel.vatansms.com/panel/smstakippost.php", smsozet));
        }
        private string XmlPost(string PostAddress, string xmlData)
        {
            using (WebClient wUpload = new WebClient())
            {
                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SmsAyarlari_KullaniciAdi, txtKullaniciAdi.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SmsAyarlari_Parola, txtSifre.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SmsAyarlari_KullaniciNo, txtKullaniciNo.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SmsAyarlari_Orjinator, txtOrjinator.Text);
            try
            {
                SettingsTool.Kaydet();
                XtraMessageBox.Show("Başarılı Bir Şekilde Bilgileriniz Kayıt Edildi." + DateTime.Now);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kayıt Başarısız.");
            }
        }

        private void FrmSms_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}