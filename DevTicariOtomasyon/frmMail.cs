using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace DevTicariOtomasyon
{
    public partial class frmMail : DevExpress.XtraEditors.XtraForm
    {
        public frmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mailim = new MailMessage();
            mailim.From = new MailAddress("batuhnnr@gmail.com");
            mailim.To.Add(txtMail.Text);
            mailim.Subject = txtKonu.Text;
            mailim.Body = RctxtMesaj.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("batuhnnr@gmail.com", "10063474Ob");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(mailim, (object)mailim);
                MessageBox.Show("Mail Gönderildi");
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = mail;
        }
    }
}
