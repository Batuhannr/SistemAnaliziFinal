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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute GiderBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void GiderTur()
        {

            SqlCommand komut = new SqlCommand("select giderTurAd from GiderTur", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbTur.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void Personel()
        {

            SqlCommand komut = new SqlCommand("select personelId from Personeller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbPersonel.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void frmGiderler_Load(object sender, EventArgs e)
        {
            listele();
            GiderTur();
            Personel();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Giderler(giderTutar,giderTur,giderNot,giderPersonelId) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse((txtTutar.Text)));
            komut.Parameters.AddWithValue("@p2", CmbTur.Text);
            komut.Parameters.AddWithValue("@p3", RchANot.Text);
            komut.Parameters.AddWithValue("@p4", CmbPersonel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Sisteme Başarıyla Eklen", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtTutar.Text = "";
            CmbTur.Text = "";
            CmbPersonel.Text = "";
            RchANot.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["giderId"].ToString();
            txtTutar.Text = dr["giderTutar"].ToString();
            CmbTur.Text = dr["giderTur"].ToString();
            CmbPersonel.Text = dr["personelAdSoyad"].ToString();
            RchANot.Text = dr["giderNot"].ToString();
        }

        private void btnGiderSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Giderler where giderId = @p1", bgl.baglanti());
            txtId.Text = gridView1.GetFocusedRowCellValue("giderId").ToString();
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Giderler set giderTutar=@p1, giderTur=@p2, giderPersonelId=@p3 , giderNot=@p4 where giderId=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse((txtTutar.Text)));
            komut.Parameters.AddWithValue("@p2", CmbTur.Text);
            komut.Parameters.AddWithValue("@p3", CmbPersonel.Text);
            komut.Parameters.AddWithValue("@p4", RchANot.Text);
            komut.Parameters.Add("@p5", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
