using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTicariOtomasyon
{
    public partial class frmAnaForm : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }
        urunlerForm fr;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new urunlerForm();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        frmMusteriler fr1;
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null)
            {
                fr1 = new frmMusteriler();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }
        frmFirmalar fr2;
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new frmFirmalar();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        frmPersonel fr3;
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new frmPersonel();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        frmGiderler fr4;
        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new frmGiderler();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        frmNotlar fr5;
        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new frmNotlar();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        frmBankalar fr6;
        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null)
            {
                fr6 = new frmBankalar();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        frmRehber fr7;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null)
            {
                fr7 = new frmRehber();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        frmFaturalar fr8;
        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null)
            {
                fr8 = new frmFaturalar();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        frmHareketler fr9;
        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null)
            {
                fr9 = new frmHareketler();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        frmStoklar fr10;
        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null)
            {
                fr10 = new frmStoklar();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        frmRaporlar fr11;
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null)
            {
                fr11 = new frmRaporlar();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        frmKasa fr12;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr12 ==null)
            {
                fr12 = new frmKasa();
                fr12.MdiParent = this;
                fr12.Show();
            }

        }
    }
}
