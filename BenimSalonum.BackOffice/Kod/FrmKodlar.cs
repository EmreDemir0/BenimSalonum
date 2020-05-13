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
using DevExpress.XtraGrid;
using System.Threading;
using DevExpress.Utils.Extensions;
using System.Data.Entity;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Kod
{
    public partial class FrmKodlar : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        KodDAL kodDal = new KodDAL();
        private Entities.Tables.Kod _entity;
        private string _tablo;

        public FrmKodlar(string tablo)
        {
            InitializeComponent();
            _tablo = tablo;
            context.Kodlar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Tablo == _tablo).Load();
            gridControlKod.DataSource = context.Kodlar.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //buray musteri ıd kontrolü koy
            try
            {
                context.Kodlar.Local.ForEach(c => c.Tablo = _tablo);
                context.SaveChanges();


                labelControl2.Text = "Kayıt Başarılı. " + DateTime.Now;
                Thread.Sleep(1000);
                this.Close();
            }
            catch (Exception)
            {
                labelControl2.Text = "Kayıt Başarısız Gerekli Alanları Kontrol Ederek Tekrar Deneyiniz.";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridKod_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Entities.Tables.Kod row = (Entities.Tables.Kod)e.Row;
            if (context.Kodlar.Local.Any(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OnEki == row.OnEki && c.Tablo == _tablo))
            {
                XtraMessageBox.Show("Aynı Ön Ekle Kod Kaydedilemez");
                gridKod.CancelUpdateCurrentRow();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridKod.DeleteSelectedRows();
            context.SaveChanges();
        }

        private void gridKod_ShownEditor(object sender, CancelEventArgs e)
        {
            if (gridKod.FocusedRowHandle == GridControl.NewItemRowHandle)
            {
                e.Cancel = true;
            }
        }
    }
}