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
    public partial class frmFaturalar : Form
    {
        public frmFaturalar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From FaturaBilgi", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            txtId.Text = "";
            txtSeri.Text = "";
            txtSiraNo.Text = "";
            txtTarih.Text = "";
            txtSaat.Text = "";
            txtAlici.Text = "";
            txtTeslimAlan.Text = "";
            txtTeslimEden.Text = "";
        }

            private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFaturaId.Text == "" )
            {
                SqlCommand komut = new SqlCommand("insert into FaturaBilgi (faturaSeri,faturaSıraNo,faturaTarih,faturaSaat,faturaVergiDaire,faturaAlici,faturaTeslimEden,faturaTeslimAlan) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSiraNo.Text);
                komut.Parameters.AddWithValue("@p3", txtTarih.Text);
                komut.Parameters.AddWithValue("@p4", txtSaat.Text);
                komut.Parameters.AddWithValue("@p5", txtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p6", txtAlici.Text);
                komut.Parameters.AddWithValue("@p7", txtTeslimAlan.Text);
                komut.Parameters.AddWithValue("@p8", txtTeslimEden.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                Temizle();


            }
            else 
            {
                SqlCommand komut = new SqlCommand("insert into FaturaDetay (faturaUrunAd,faturaMiktar,faturaFiyat,faturaTutar,faturaId) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut.Parameters.AddWithValue("@p3", txtFiyat.Text);
                komut.Parameters.AddWithValue("@p4", txtTutar.Text);
                komut.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Detay Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void frmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            Temizle();

        }

        private void btnFaturaSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From FaturaBilgi where faturaBilgiId = @p1", bgl.baglanti());
            txtId.Text = gridView1.GetFocusedRowCellValue("faturaBilgiId").ToString();
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnDetay_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            faturaDetay fr = new faturaDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["faturaBilgiId"].ToString();
            }
            fr.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["faturaBilgiId"].ToString();
            txtSeri.Text = dr["faturaSeri"].ToString();
            txtSiraNo.Text = dr["faturaSıraNo"].ToString();
            txtTarih.Text = dr["faturaTarih"].ToString();
            txtSaat.Text = dr["faturaSaat"].ToString();
            txtVergiDaire.Text = dr["faturaVergiDaire"].ToString();
            txtAlici.Text = dr["faturaAlici"].ToString();
            txtTeslimAlan.Text = dr["faturaTeslimEden"].ToString();
            txtTeslimEden.Text = dr["faturaTeslimAlan"].ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update FaturaBilgi set faturaSeri=@p1, faturaSıraNo=@p3 , faturaTarih=@p4, faturaSaat=@p5, faturaVergiDaire=@p6, faturaAlici=@p7, faturaTeslimEden=@p8,faturaTeslimAlan=@p9 where faturaBilgiId=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSeri.Text);
            komut.Parameters.AddWithValue("@p3", txtSiraNo.Text);
            komut.Parameters.AddWithValue("@p4", txtTarih.Text);
            komut.Parameters.AddWithValue("@p5", txtSaat.Text);
            komut.Parameters.AddWithValue("@p6", txtVergiDaire.Text);
            komut.Parameters.AddWithValue("@p7", txtAlici.Text);
            komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", txtTeslimEden.Text);
            komut.Parameters.Add("@p10", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
