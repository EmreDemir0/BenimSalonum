using BenimSalonum.Entities.Context;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Tools
{
    public class CodeTool
    {
        BarManager manager = new BarManager();
        PopupMenu popupMenu;
        XtraForm _form;
        BenimSalonumContext _context;
        Table _table;

        public enum Table
        {
            Cari,
            Stok,
            Fis
        }
        public CodeTool(XtraForm form, Table table)
        {
            _form = form;
            // _context = context;
            _table = table;
            manager.Form = _form;
            popupMenu = new PopupMenu(manager);
        }
        public void barButonOlustur()
        {
            _context = new BenimSalonumContext();

            foreach (var kod in _context.Kodlar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Tablo == _table.ToString()).ToList())
            {
                BarButtonItem item = new BarButtonItem
                {
                    Name = "btnKod" + kod.SonDeger,
                    Tag = kod.Id,
                    Caption = KodOlustur()
                };
                item.ItemClick += Buton_Click;
                popupMenu.AddItem(item);
            }
            BarButtonItem yeniKodEkle = new BarButtonItem
            {
                Name = "btnYeniKodEkle",
                Caption = "Yeni Kod Oluştur"
            };
            yeniKodEkle.ItemClick += YeniKodEkle_Click;
            popupMenu.AddItem(yeniKodEkle).BeginGroup = true;

            BarButtonItem guncelle = new BarButtonItem
            {
                Name = "btnGuncelle",
                Caption = "Güncelle"
            };
            guncelle.ItemClick += Guncelle_Click;
            popupMenu.AddItem(guncelle);

            DropDownButton buton = (DropDownButton)_form.Controls.Find("btnKod", true).SingleOrDefault();
            buton.MenuManager = manager;
            buton.DropDownControl = popupMenu;
        }

        private void Guncelle_Click(object sender, ItemClickEventArgs e)
        {
            BarButonSil();
            barButonOlustur();
        }
        private void BarButonSil()
        {
            popupMenu.ItemLinks.Clear();
        }

        private void YeniKodEkle_Click(object sender, ItemClickEventArgs e)
        {
            //Front officeyide bu şekilde çalıştır.     TİP BACKOFFİCE İSE BUNU FRONTSA BUNU YAP.
            Type tip = Assembly.Load("BenimSalonum.BackOffice").GetTypes().SingleOrDefault(c => c.Name == "FrmKodlar");
            XtraForm form = (XtraForm)Activator.CreateInstance(tip, _table.ToString());
            form.ShowDialog();
            BarButonSil();
            barButonOlustur();
        }

        private void Buton_Click(object sender, ItemClickEventArgs e)
        {
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            text.Text = e.Item.Caption;
            text.Focus();
        }

        public string KodOlustur()
        {
            var kod = _context.Kodlar.SingleOrDefault(c => c.OnEki == "FS" && c.Tablo == "Fis");
            string onEki = kod.OnEki;
            string sonDeger = kod.SonDeger.ToString();
            int sifirSayisi = 10 - (onEki.Length + sonDeger.Length);
            string sifirDizisi = new string('0', sifirSayisi);
            //    kod.SonDeger++;
            _context.SaveChanges();

            return onEki + sifirDizisi + sonDeger;
        }
        public string YeniFisOdemeKoduOlustur()
        {
            var kod = _context.Kodlar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OnEki == "FO" && c.Tablo == "Fis");
            string onEki = kod.OnEki;
            string sonDeger = kod.SonDeger.ToString();
            int sifirSayisi = 10 - (onEki.Length + sonDeger.Length);
            string sifirDizisi = new string('0', sifirSayisi);
            //      kod.SonDeger++;
            _context.SaveChanges();

            return onEki + sifirDizisi + sonDeger;
        }
        public void KodArttirma()
        {
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            BarItemLink buton = popupMenu.ItemLinks.SingleOrDefault(c => c.Caption == text.Text);
            if (buton != null)
            {
                int id = Convert.ToInt32(buton.Item.Tag.ToString());
                System.Windows.Forms.MessageBox.Show(id.ToString());

                _context.Kodlar.SingleOrDefault(c => c.Id == id).SonDeger++;
                _context.SaveChanges();
            }
        }

    }
}
