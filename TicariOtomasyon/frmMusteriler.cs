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

namespace DXApplication1
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From Musteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnMusteriSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Musteriler where musteriId = @p1", bgl.baglanti());
            txtId.Text = gridView1.GetFocusedRowCellValue("musteriId").ToString();
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        void Sehirler()
        {

            SqlCommand komut = new SqlCommand("select sehir from iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();


        }
       
        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            listele();

            Sehirler();
        }
        

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Musteriler(musteriAd,musteriSoyad,musteriTelefon,musteriTelefonİki,musteriTc,musteriMail,musteriIl,musteriIlce,musteriAdres,musteriVergiDaire) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtTelBir.Text);
            komut.Parameters.AddWithValue("@p4", txtTelIki.Text);
            komut.Parameters.AddWithValue("@p5", txtTc.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", Cmbil.Text);
            komut.Parameters.AddWithValue("@p8", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p9", RchAdress.Text);
            komut.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Başarıyla Eklen", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelBir.Text = "";
            txtTelIki.Text = "";
            txtTc.Text = "";
            txtMail.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            RchAdress.Text = "";
            txtVergi.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["musteriId"].ToString();
            txtAd.Text = dr["musteriAd"].ToString();
            txtSoyad.Text = dr["musteriSoyad"].ToString();
            txtTelBir.Text = dr["musteriTelefon"].ToString();
            txtTelIki.Text = dr["musteriTelefonİki"].ToString();
            txtTc.Text = dr["musteriTc"].ToString();
            txtMail.Text = dr["musteriMail"].ToString();
            Cmbil.Text = dr["musteriIl"].ToString();
            Cmbilce.Text = dr["musteriIlce"].ToString();
            RchAdress.Text = dr["musteriAdres"].ToString();
            txtVergi.Text = dr["musteriVergiDaire"].ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Musteriler set musteriAd=@p1, musteriSoyad=@p2, musteriTelefon=@p3 , musteriTelefonİki=@p4, musteriTc=@p5, musteriMail=@p6, musteriIl=@p7, musteriIlce=@p8,musteriAdres=@p9,musteriVergiDaire=@p10 where musteriId=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtTelBir.Text);
            komut.Parameters.AddWithValue("@p4", txtTelIki.Text);
            komut.Parameters.AddWithValue("@p5", txtTc.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", Cmbil.Text);
            komut.Parameters.AddWithValue("@p8", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p9", RchAdress.Text);
            komut.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut.Parameters.Add("@p11", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void txtIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select Ilce from ilceler where Sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
    }
}

        
    
