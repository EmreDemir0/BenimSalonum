using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenimSalonum.Entities.Tools.LoadingTool
{
    public class LoadingTool
    {
        SplashScreenManager manager;
        public LoadingTool(XtraForm form)
        {
            manager = new SplashScreenManager(form, typeof(FrmLoading), true, true);
        }

        public void AnimasyonBaslat()
        {
            manager.ShowWaitForm();
        }
        public void AnimasyonBitir()
        {
            manager.CloseWaitForm();
        }
    }
}
