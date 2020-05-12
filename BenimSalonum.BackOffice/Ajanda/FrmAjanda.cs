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
using DevExpress.XtraScheduler;
using BenimSalonum.Entities.Context;
using System.Data.Entity;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Ajanda
{
    public partial class FrmAjanda : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        public FrmAjanda()
        {
            InitializeComponent();

            context.EFAppointments.Where(c=>c.KullaniciID==RoleTool.kullaniciEntity.KullaniciID).Load();
            context.EFResources.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();
            //localde çalışmak için verileri önce çağırıyoruz

            schedulerControl1.DataStorage.Appointments.DataSource = context.EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local.ToBindingList();
        }

        private void FrmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();        }

        private void saveScheduleItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            context.SaveChanges();
        }
    }
}