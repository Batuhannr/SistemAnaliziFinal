using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DevTicariOtomasyon
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketlerPro", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void firmaHareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute FirmaHareketlerPro", bgl.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        private void frmKasa_Load(object sender, EventArgs e)
        {
            musterihareket();
            firmaHareket();

            SqlCommand komut1 = new SqlCommand("Select SUM(faturaTutar) from FaturaDetay", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblTutar.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
            SqlCommand komut2 = new SqlCommand("Select SUM(giderTutar) from Giderler", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                lblOdemeler.Text = dr2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
            SqlCommand komut3 = new SqlCommand("Select SUM(giderTutar) from Giderler WHERE giderTur = 'Maaş'", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lblMaaslar.Text = dr3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
            SqlCommand komut4 = new SqlCommand("Select Count(*) from Musteriler ", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblMusteri.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut5 = new SqlCommand("Select Count(*) from Firmalar ", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lblFirma.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut6 = new SqlCommand("Select Count(*) from Personeller ", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                lblPersonel.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut7 = new SqlCommand("Select SUM(urunAdet) from Urunler", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();

            while (dr7.Read())
            {
                lblStok.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
