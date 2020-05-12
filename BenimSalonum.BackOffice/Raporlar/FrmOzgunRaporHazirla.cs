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
using System.Reflection;

namespace BenimSalonum.BackOffice.Raporlar
{
    public partial class FrmOzgunRaporHazirla : DevExpress.XtraEditors.XtraForm
    {
        private List<object> veriListesi = new List<object>();
        BenimSalonumContext context = new BenimSalonumContext();
        public FrmOzgunRaporHazirla()
        {
            InitializeComponent();
        }

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            foreach (var itemChecked in checkedListBoxControl1.Items.Where(c => c.CheckState == CheckState.Checked).ToList())
            {
                Type tip = Assembly.Load("BenimSalonum.Entities").GetTypes()
                    .SingleOrDefault(c => c.Name == itemChecked.Value.ToString());
                object veri = Activator.CreateInstance(tip);

                MethodInfo info = tip.GetMethod(itemChecked.Tag.ToString());
                try
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context }));
                }
                catch (Exception)
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context, null }));
                }

            }
            FrmOzgunRaporlar form = new FrmOzgunRaporlar(veriListesi);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}