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
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Fiyat_Değiştir
{
    public partial class FrmFiyatDegistir : DevExpress.XtraEditors.XtraForm
    {
        public bool secildi = false;
        public List<FiyatDegistir> list;

        public FrmFiyatDegistir()
        {
            InitializeComponent();
            list = new List<FiyatDegistir>
            {
                new FiyatDegistir
                {
                    FiyatTuru = "Alış Fiyatı-1",
                    KolonAdi = "AlisFiyati1",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru = "Alış Fiyatı-2",
                    KolonAdi = "AlisFiyati1",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru = "Alış Fiyatı-3",
                    KolonAdi = "AlisFiyati1",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru = "Satış Fiyatı-1",
                    KolonAdi = "SatisFiyati1",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru = "Satış Fiyatı-2",
                    KolonAdi = "SatisFiyati2",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru = "Satış Fiyatı-3",
                    KolonAdi = "SatisFiyati3",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                }
            };
            FiyatDegistirGridControl.DataSource = list;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}