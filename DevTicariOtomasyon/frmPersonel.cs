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
    public partial class frmPersonel : DevExpress.XtraEditors.XtraForm
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From Personeller", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personeller(personelAdSoyad,personelTelefon,personelTc,personelMaıl,personelIl,personelIlce,personelAdres,personelGorev) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtTel.Text);
            komut.Parameters.AddWithValue("@p3", txtTc.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", Cmbil.Text);
            komut.Parameters.AddWithValue("@p6", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p7", RchAdress.Text);
            komut.Parameters.AddWithValue("@p8", txtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Sisteme Başarıyla Eklen", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtAd.Text = "";
            txtTel.Text = "";
            txtTc.Text = "";
            txtMail.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            RchAdress.Text = "";
            txtGorev.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personeller set personelAdSoyad=@p1, personelTelefon=@p3 , personelTc=@p4, personelMaıl=@p5, personelIl=@p6, personelIlce=@p7, personelAdres=@p8,personelGorev=@p9 where personelId=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtTel.Text);
            komut.Parameters.AddWithValue("@p4", txtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", RchAdress.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.Parameters.Add("@p10", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            listele();
            Sehirler();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnPersonelSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Personeller where personelId = @p1", bgl.baglanti());
            txtId.Text = gridView1.GetFocusedRowCellValue("personelId").ToString();
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["personelId"].ToString();
            txtAd.Text = dr["personelAdSoyad"].ToString();
            txtTel.Text = dr["personelTelefon"].ToString();
            txtTc.Text = dr["personelTc"].ToString();
            txtMail.Text = dr["personelMaıl"].ToString();
            Cmbil.Text = dr["personelIl"].ToString();
            Cmbilce.Text = dr["personelIlce"].ToString();
            RchAdress.Text = dr["personelAdres"].ToString();
            txtGorev.Text = dr["personelGorev"].ToString();
        }
    }
}
