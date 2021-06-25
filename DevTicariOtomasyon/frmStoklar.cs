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
    public partial class frmStoklar : DevExpress.XtraEditors.XtraForm
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmStoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Antalya", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Balıkesir", 2);
            SqlDataAdapter da = new SqlDataAdapter("Select urunAd,Sum(urunAdet) As 'Miktar' from Urunler group by urunAd", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlDataAdapter da2 = new SqlDataAdapter("Select firmaIl,Count(*) From Firmalar group by firmaIl", bgl.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            SqlCommand komut = new SqlCommand("Select urunAd,sum(urunAdet) as 'Miktar' from Urunler group by urunAd", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("Select firmaIl,Count(*) From Firmalar group by firmaIl", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
