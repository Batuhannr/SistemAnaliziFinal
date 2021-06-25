using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTicariOtomasyon
{
    public partial class frmRehber : DevExpress.XtraEditors.XtraForm
    {
        public frmRehber()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void MusteriListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select musteriId,musteriAd,musteriSoyad,musteriTelefon,musteriTelefonİki,musteriMail from Musteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        void FirmaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select firmaId,firmaAd,firmaTelefon1,firmaTelefon2,firmaTelefon3,firmaMail,firmaFax from Firmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void frmRehber_Load(object sender, EventArgs e)
        {
            MusteriListele();
            FirmaListele();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["firmaMail"].ToString();
            }
            frm.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void btnMailToMusteri_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["musteriMail"].ToString();
            }
            frm.Show();
        }
    }
}
