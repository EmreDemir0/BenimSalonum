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
using System.Net.Mail;
using System.Net;

namespace BenimSalonum.BackOffice.Rehber
{
    public partial class FrmMailGonder : DevExpress.XtraEditors.XtraForm
    {

        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        bool Secildi = false;
        public FrmMailGonder(bool _Secildi, List<Entities.Tables.Cari> _secilen = null)
        {
            InitializeComponent();
            Secildi = _Secildi;
            secilen = _secilen;
        }

        public void mailGonder(string path = null, string kime = null)
        {
            if (Secildi)
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.eu.mailgun.org";
                sc.EnableSsl = false;
                sc.UseDefaultCredentials = false;
                sc.Credentials = new NetworkCredential("info@mg.benimrandevum.com", "bb412cf715e6c49abb769c2508d5861d-a2b91229-0fc0d127");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info@mg.benimrandevum.com", "Benim Randevum");

                if (secilen != null)
                {
                    foreach (var item in secilen)
                    {
                        mail.To.Add(item.EMail);
                    }
                }
                else
                {
                    mail.To.Add(kime);

                    mail.Subject = txtKonu.Text;
                    mail.IsBodyHtml = true;
                    mail.Body = txtMesaj.Text;
                    Attachment attachment;
                    attachment = new Attachment(path);
                    mail.Attachments.Add(attachment);

                    try
                    {
                        sc.Send(mail);
                        XtraMessageBox.Show("Mail Başarı ile Gönderildi > " + DateTime.Now);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Mail Gönderilecek Kişi Bulunamadı > " + DateTime.Now);
            }

            }
            private void FrmMailGonder_Load(object sender, EventArgs e)
            {
                if (Secildi)
                {
                    foreach (var item in secilen)
                    {
                        txtKime.Text += item.EMail + ",";
                    }
                }
            }

            private void simpleButton1_Click(object sender, EventArgs e)
            {

            }
        }
    }