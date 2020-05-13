using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Tables;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace BenimSalonum.Entities.Tools
{
    public static class RoleTool
    {
        public static Kullanici kullaniciEntity ;
        public static void RolleriYukle(XtraForm form)
        {
            BenimSalonumContext context = new BenimSalonumContext();

            foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KullaniciAdi == kullaniciEntity.KullaniciAdi && c.FormAdi == form.Name && c.Yetki == false).ToList())
            {
                var bulunan = form.Controls.Find(item.KontrolAdi, true).SingleOrDefault();

                if (bulunan != null)
                {
                    bulunan.Enabled = false;
                }
            }
        }
        public static void RolleriYukle(RibbonControl form)
        {
            BenimSalonumContext context = new BenimSalonumContext();
            try
            {
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FormAdi == "FrmAnaMenu" && c.Yetki == false).ToList())
                {
                    form.Items.SingleOrDefault(c => c.Name == item.KontrolAdi).Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
