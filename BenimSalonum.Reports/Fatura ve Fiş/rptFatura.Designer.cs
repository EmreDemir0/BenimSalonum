namespace BenimSalonum.Reports.Fatura_ve_Fiş
{
    partial class rptFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptFatura));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStokKodu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colStokAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMiktar = new DevExpress.XtraReports.UI.XRTableCell();
            this.colKdv = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirimFiyat = new DevExpress.XtraReports.UI.XRTableCell();
            this.colIndirimOrani = new DevExpress.XtraReports.UI.XRTableCell();
            this.colIndirim = new DevExpress.XtraReports.UI.XRTableCell();
            this.colTutar = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.SubtotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.DiscountLineTotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.TaxLineTotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.TotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.UnitDiscountParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.UnitTaxParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.colCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.colAdres = new DevExpress.XtraReports.UI.XRLabel();
            this.colTelefon = new DevExpress.XtraReports.UI.XRLabel();
            this.colVergiDairesi = new DevExpress.XtraReports.UI.XRLabel();
            this.colEmail = new DevExpress.XtraReports.UI.XRLabel();
            this.colVergiNo = new DevExpress.XtraReports.UI.XRLabel();
            this.colTarih = new DevExpress.XtraReports.UI.XRLabel();
            this.colFisNo = new DevExpress.XtraReports.UI.XRLabel();
            this.vendorLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.colIskontroOrani = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.colGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.colIskontoToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.colIndirimToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.colAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.colKdvToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.lblAdresBilgi = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 63.5F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1651F, 63.5F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStokKodu,
            this.colStokAdi,
            this.colMiktar,
            this.colKdv,
            this.colBirimFiyat,
            this.colIndirimOrani,
            this.colIndirim,
            this.colTutar});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Dpi = 254F;
            this.colStokKodu.Multiline = true;
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.Text = "colStokKodu";
            this.colStokKodu.Weight = 1D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Dpi = 254F;
            this.colStokAdi.Multiline = true;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Text = "colStokAdi";
            this.colStokAdi.Weight = 1D;
            // 
            // colMiktar
            // 
            this.colMiktar.Dpi = 254F;
            this.colMiktar.Multiline = true;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Text = "colMiktar";
            this.colMiktar.Weight = 0.68589739276740425D;
            // 
            // colKdv
            // 
            this.colKdv.Dpi = 254F;
            this.colKdv.Multiline = true;
            this.colKdv.Name = "colKdv";
            this.colKdv.Text = "colKdv";
            this.colKdv.Weight = 0.64743603914885872D;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Dpi = 254F;
            this.colBirimFiyat.Multiline = true;
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Text = "colBirimFiyat";
            this.colBirimFiyat.Weight = 1.243589645006814D;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Dpi = 254F;
            this.colIndirimOrani.Multiline = true;
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.Text = "colIndirimOrani";
            this.colIndirimOrani.Weight = 1.1666674553301031D;
            // 
            // colIndirim
            // 
            this.colIndirim.Dpi = 254F;
            this.colIndirim.Multiline = true;
            this.colIndirim.Name = "colIndirim";
            this.colIndirim.Text = "colIndirim";
            this.colIndirim.Weight = 1.25640946774682D;
            // 
            // colTutar
            // 
            this.colTutar.Dpi = 254F;
            this.colTutar.Multiline = true;
            this.colTutar.Name = "colTutar";
            this.colTutar.Text = "colTutar";
            this.colTutar.Weight = 1D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 102.9375F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 1007F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            // 
            // SubtotalCalcField
            // 
            this.SubtotalCalcField.DisplayName = "Subtotal";
            this.SubtotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.SubtotalCalcField.Name = "SubtotalCalcField";
            // 
            // DiscountLineTotalCalcField
            // 
            this.DiscountLineTotalCalcField.DisplayName = "DiscountLineTotal";
            this.DiscountLineTotalCalcField.Expression = "0";
            this.DiscountLineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.DiscountLineTotalCalcField.Name = "DiscountLineTotalCalcField";
            // 
            // TaxLineTotalCalcField
            // 
            this.TaxLineTotalCalcField.DisplayName = "TaxLineTotal";
            this.TaxLineTotalCalcField.Expression = "0";
            this.TaxLineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.TaxLineTotalCalcField.Name = "TaxLineTotalCalcField";
            // 
            // TotalCalcField
            // 
            this.TotalCalcField.DisplayName = "Total";
            this.TotalCalcField.Expression = "[SubtotalCalcField]";
            this.TotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.TotalCalcField.Name = "TotalCalcField";
            // 
            // UnitDiscountParameter
            // 
            this.UnitDiscountParameter.Name = "UnitDiscountParameter";
            this.UnitDiscountParameter.Type = typeof(decimal);
            this.UnitDiscountParameter.ValueInfo = "0";
            this.UnitDiscountParameter.Visible = false;
            // 
            // UnitTaxParameter
            // 
            this.UnitTaxParameter.Name = "UnitTaxParameter";
            this.UnitTaxParameter.Type = typeof(decimal);
            this.UnitTaxParameter.ValueInfo = "0";
            this.UnitTaxParameter.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblAdresBilgi,
            this.xrLabel10,
            this.xrLabel8,
            this.xrLabel9,
            this.xrPictureBox1,
            this.xrTable2,
            this.xrLine1,
            this.colCariAdi,
            this.colAdres,
            this.colTelefon,
            this.colVergiDairesi,
            this.colEmail,
            this.colVergiNo,
            this.colTarih,
            this.colFisNo,
            this.vendorLogo});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 622.2324F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 133.6675F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(554.3021F, 41.48665F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "Yenimahalle 0420349528";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.84749F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(554.3021F, 83.81998F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "Pamuklar Mahallesi Kızılcahamam Caddesi 50 / B";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.069176F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(638.9687F, 46.77831F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Aktifim Kozmetik San. Tic. Ltd. Şti.";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(687.9167F, 3.069176F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(172.0734F, 187.4308F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrTable2
            // 
            this.xrTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable2.Dpi = 254F;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 558.7324F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1651F, 63.5F);
            this.xrTable2.StylePriority.UseBorderDashStyle = false;
            this.xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Stok Kodu";
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Stok Adı";
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Miktar";
            this.xrTableCell3.Weight = 0.68589739276740425D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Kdv";
            this.xrTableCell4.Weight = 0.64743603914885872D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Birim Fiyat";
            this.xrTableCell5.Weight = 1.243589645006814D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Dpi = 254F;
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "İndirim Oranı";
            this.xrTableCell6.Weight = 1.1666674553301031D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Dpi = 254F;
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "İndirim Tutari";
            this.xrTableCell7.Weight = 1.25640946774682D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Dpi = 254F;
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Tutar";
            this.xrTableCell8.Weight = 1D;
            // 
            // xrLine1
            // 
            this.xrLine1.Dpi = 254F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 187.4308F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1648F, 13.44087F);
            // 
            // colCariAdi
            // 
            this.colCariAdi.Dpi = 254F;
            this.colCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(0F, 200.8717F);
            this.colCariAdi.Multiline = true;
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colCariAdi.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colCariAdi.Text = "colCariAdi";
            // 
            // colAdres
            // 
            this.colAdres.Dpi = 254F;
            this.colAdres.LocationFloat = new DevExpress.Utils.PointFloat(0F, 259.2917F);
            this.colAdres.Multiline = true;
            this.colAdres.Name = "colAdres";
            this.colAdres.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colAdres.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colAdres.Text = "colAdres";
            // 
            // colTelefon
            // 
            this.colTelefon.Dpi = 254F;
            this.colTelefon.LocationFloat = new DevExpress.Utils.PointFloat(592.6667F, 499.4275F);
            this.colTelefon.Multiline = true;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colTelefon.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colTelefon.Text = "colTelefon";
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Dpi = 254F;
            this.colVergiDairesi.LocationFloat = new DevExpress.Utils.PointFloat(0F, 441.0075F);
            this.colVergiDairesi.Multiline = true;
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colVergiDairesi.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colVergiDairesi.Text = "colVergiDairesi";
            // 
            // colEmail
            // 
            this.colEmail.Dpi = 254F;
            this.colEmail.LocationFloat = new DevExpress.Utils.PointFloat(0F, 499.4275F);
            this.colEmail.Multiline = true;
            this.colEmail.Name = "colEmail";
            this.colEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colEmail.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colEmail.Text = "colEmail";
            // 
            // colVergiNo
            // 
            this.colVergiNo.Dpi = 254F;
            this.colVergiNo.LocationFloat = new DevExpress.Utils.PointFloat(592.6667F, 441.0075F);
            this.colVergiNo.Multiline = true;
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colVergiNo.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colVergiNo.Text = "colVergiNo";
            // 
            // colTarih
            // 
            this.colTarih.Dpi = 254F;
            this.colTarih.LocationFloat = new DevExpress.Utils.PointFloat(1244.877F, 259.2917F);
            this.colTarih.Multiline = true;
            this.colTarih.Name = "colTarih";
            this.colTarih.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colTarih.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colTarih.Text = "Fatura Tarihi :";
            // 
            // colFisNo
            // 
            this.colFisNo.Dpi = 254F;
            this.colFisNo.LocationFloat = new DevExpress.Utils.PointFloat(1244.877F, 200.8717F);
            this.colFisNo.Multiline = true;
            this.colFisNo.Name = "colFisNo";
            this.colFisNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colFisNo.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.colFisNo.Text = "FaturaNo :";
            // 
            // vendorLogo
            // 
            this.vendorLogo.Dpi = 254F;
            this.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft;
            this.vendorLogo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("vendorLogo.ImageSource"));
            this.vendorLogo.LocationFloat = new DevExpress.Utils.PointFloat(1244.877F, 0F);
            this.vendorLogo.Name = "vendorLogo";
            this.vendorLogo.SizeF = new System.Drawing.SizeF(403.1229F, 190.5F);
            this.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.vendorLogo.StylePriority.UseBorderColor = false;
            this.vendorLogo.StylePriority.UseBorders = false;
            this.vendorLogo.StylePriority.UsePadding = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel2,
            this.xrLabel1,
            this.colIskontroOrani,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel13,
            this.colGenelToplam,
            this.colIskontoToplam,
            this.colIndirimToplam,
            this.colAraToplam,
            this.colKdvToplam});
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.HeightF = 617.782F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 500.942F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(1098.021F, 58.42004F);
            this.xrLabel7.Text = "İş Bankası IBAN : TR 7000 2000 5000 6000 95";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 559.362F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(1098.021F, 58.42004F);
            this.xrLabel2.Text = "İş Bankası IBAN : TR 7000 2000 5000 6000 95";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1143F, 228.1766F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel1.Text = "İskonto Oranı :";
            // 
            // colIskontroOrani
            // 
            this.colIskontroOrani.Dpi = 254F;
            this.colIskontroOrani.LocationFloat = new DevExpress.Utils.PointFloat(1397F, 228.1766F);
            this.colIskontroOrani.Multiline = true;
            this.colIskontroOrani.Name = "colIskontroOrani";
            this.colIskontroOrani.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colIskontroOrani.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(1143F, 111.3365F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel4.Text = "Kdv Toplam";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1143F, 52.91667F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel3.Text = "Ara Toplam :";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(1143F, 169.7566F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel5.Text = "İndirim Toplam :";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1143F, 286.5967F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel6.Text = "İskonto Toplam :";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(1143F, 345.0167F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel13.Text = "Genel Toplam :";
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.Dpi = 254F;
            this.colGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(1397F, 345.0167F);
            this.colGenelToplam.Multiline = true;
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colGenelToplam.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // colIskontoToplam
            // 
            this.colIskontoToplam.Dpi = 254F;
            this.colIskontoToplam.LocationFloat = new DevExpress.Utils.PointFloat(1397F, 286.5967F);
            this.colIskontoToplam.Multiline = true;
            this.colIskontoToplam.Name = "colIskontoToplam";
            this.colIskontoToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colIskontoToplam.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // colIndirimToplam
            // 
            this.colIndirimToplam.Dpi = 254F;
            this.colIndirimToplam.LocationFloat = new DevExpress.Utils.PointFloat(1397F, 169.7566F);
            this.colIndirimToplam.Multiline = true;
            this.colIndirimToplam.Name = "colIndirimToplam";
            this.colIndirimToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colIndirimToplam.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // colAraToplam
            // 
            this.colAraToplam.Dpi = 254F;
            this.colAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(1397F, 52.91667F);
            this.colAraToplam.Multiline = true;
            this.colAraToplam.Name = "colAraToplam";
            this.colAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colAraToplam.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // colKdvToplam
            // 
            this.colKdvToplam.Dpi = 254F;
            this.colKdvToplam.LocationFloat = new DevExpress.Utils.PointFloat(1397F, 111.3365F);
            this.colKdvToplam.Multiline = true;
            this.colKdvToplam.Name = "colKdvToplam";
            this.colKdvToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colKdvToplam.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // lblAdresBilgi
            // 
            this.lblAdresBilgi.Dpi = 254F;
            this.lblAdresBilgi.LocationFloat = new DevExpress.Utils.PointFloat(0F, 317.7117F);
            this.lblAdresBilgi.Multiline = true;
            this.lblAdresBilgi.Name = "lblAdresBilgi";
            this.lblAdresBilgi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAdresBilgi.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.lblAdresBilgi.Text = "colTelefon";
            // 
            // rptFatura
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.SubtotalCalcField,
            this.DiscountLineTotalCalcField,
            this.TaxLineTotalCalcField,
            this.TotalCalcField});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.excelDataSource1});
            this.DataSource = this.excelDataSource1;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(257, 251, 103, 1007);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.UnitDiscountParameter,
            this.UnitTaxParameter});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.StyleSheetPath = "";
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.CalculatedField SubtotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField DiscountLineTotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField TaxLineTotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField TotalCalcField;
        private DevExpress.XtraReports.Parameters.Parameter UnitDiscountParameter;
        private DevExpress.XtraReports.Parameters.Parameter UnitTaxParameter;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokKodu;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colMiktar;
        private DevExpress.XtraReports.UI.XRTableCell colKdv;
        private DevExpress.XtraReports.UI.XRTableCell colBirimFiyat;
        private DevExpress.XtraReports.UI.XRTableCell colIndirimOrani;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel colCariAdi;
        private DevExpress.XtraReports.UI.XRLabel colAdres;
        private DevExpress.XtraReports.UI.XRLabel colTelefon;
        private DevExpress.XtraReports.UI.XRLabel colVergiDairesi;
        private DevExpress.XtraReports.UI.XRLabel colEmail;
        private DevExpress.XtraReports.UI.XRLabel colVergiNo;
        private DevExpress.XtraReports.UI.XRLabel colTarih;
        private DevExpress.XtraReports.UI.XRLabel colFisNo;
        private DevExpress.XtraReports.UI.XRPictureBox vendorLogo;
        private DevExpress.XtraReports.UI.XRTableCell colTutar;
        private DevExpress.XtraReports.UI.XRTableCell colIndirim;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel colGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel colIskontoToplam;
        private DevExpress.XtraReports.UI.XRLabel colIndirimToplam;
        private DevExpress.XtraReports.UI.XRLabel colAraToplam;
        private DevExpress.XtraReports.UI.XRLabel colKdvToplam;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel colIskontroOrani;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel lblAdresBilgi;
    }
}
