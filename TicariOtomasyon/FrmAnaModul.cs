using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class FrmAnaModul : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        UrunlerForm fr;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new UrunlerForm();
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
        private void btnFırmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        frmRehber fr4;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new frmRehber();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        frmGiderler fr5;
        private void btnGıderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new frmGiderler();
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
        frmFaturalar fr7;

        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null)
            {
                fr7 = new frmFaturalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        frmNotlar fr8;

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null)
            {
                fr8 = new frmNotlar();
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
    }
}
