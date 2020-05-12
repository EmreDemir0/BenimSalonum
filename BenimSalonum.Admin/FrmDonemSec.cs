﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BenimSalonum.Admin
{
    public partial class FrmDonemSec : DevExpress.XtraEditors.XtraForm
    {
        public string donem;
        public FrmDonemSec()
        {
            InitializeComponent();
            spinDonem.Properties.MinValue = DateTime.Now.Year - 3;
            spinDonem.Properties.MaxValue = DateTime.Now.Year + 1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            donem = spinDonem.Text;
            this.Close();
        }
    }
}