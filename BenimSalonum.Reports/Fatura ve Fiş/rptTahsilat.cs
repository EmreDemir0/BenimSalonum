using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BenimSalonum.Entities.Context;

namespace BenimSalonum.Reports.Fatura_ve_Fiş
{
    public partial class rptTahsilat : DevExpress.XtraReports.UI.XtraReport
    {
        BenimSalonumContext context = new BenimSalonumContext();

        public rptTahsilat()
        {
            InitializeComponent();         
        }

    }
}
