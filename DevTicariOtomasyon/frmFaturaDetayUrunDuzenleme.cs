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
    public partial class frmFaturaDetayUrunDuzenleme : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaDetayUrunDuzenleme()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        public string id;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update FaturaDetay set faturaUrunAd=@p1,faturaMiktar=@p2, faturaFiyat=@p3,faturaTutar=@p4 where faturaUrunId=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p5", txtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişikilik Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void frmFaturaDetayUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunId.Text = id;
            SqlCommand komut = new SqlCommand("Select * from FaturaDetay where faturaUrunId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtFiyat.Text = dr[3].ToString();
                txtMiktar.Text = dr[2].ToString();
                txtTutar.Text = dr[4].ToString();
                txtUrunAd.Text = dr[1].ToString();
                bgl.baglanti().Close();
            }
        }
    }
 }

