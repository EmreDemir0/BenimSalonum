using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenimSalonum.Entities.Tools
{
    public class ExportTool
    {
        XtraForm _form;
        DropDownButton _dropDown;
        GridView _grid;
        BarManager _manager = new BarManager();
        PopupMenu _popupMenu;

        public ExportTool(XtraForm form, GridView grid, DropDownButton dropDown)
        {
            _form = form;
            _dropDown = dropDown;
            _grid = grid;
            _popupMenu = new PopupMenu(_manager);
            _dropDown.MenuManager = _manager;
            _dropDown.DropDownControl = _popupMenu;
            //PDF
            BarButtonItem pdfExport = new BarButtonItem
            {
                Name = "pdf",
                Caption = "PDF Dosyası"
            };
            pdfExport.ItemClick += Export;
            _popupMenu.AddItem(pdfExport);
            //EXCEL
            BarButtonItem xlsxExport = new BarButtonItem
            {
                Name = "xlsx",
                Caption = "Excel Dosyası"               
            };
            xlsxExport.ItemClick += Export;
            _popupMenu.AddItem(xlsxExport);
            //XLS
            BarButtonItem xlsExport = new BarButtonItem
            {
                Name = "xls",
                Caption = "Excel Dosyası"
            };
            xlsExport.ItemClick += Export;
            _popupMenu.AddItem(xlsExport);
            //html
            BarButtonItem htmlExport = new BarButtonItem
            {
                Name = "html",
                Caption = "HTML Dosyası"
            };
            htmlExport.ItemClick += Export;
            _popupMenu.AddItem(htmlExport);           
            //word
            BarButtonItem docxExport = new BarButtonItem
            {
                Name = "docx",
                Caption = "Word Dosyası"
            };
            docxExport.ItemClick += Export;
            _popupMenu.AddItem(docxExport);


        }

        private void Export(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = $"{e.Item.Caption}|*.{e.Item.Name}";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (e.Item.Name)
                {
                    case "pdf":
                        _grid.ExportToPdf(dialog.FileName);
                        break;
                    case "xlsx":
                        _grid.ExportToXlsx(dialog.FileName);
                        break;
                    case "xls":
                        _grid.ExportToXls(dialog.FileName);
                        break;
                    case "html":
                        _grid.ExportToHtml(dialog.FileName);
                        break;
                    case "docx":
                        _grid.ExportToDocx(dialog.FileName);
                        break;

                }
            }
        }
    }
}
