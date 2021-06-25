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
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From Firmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void btnFirmaSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Firmalar where firmaId = @p1", bgl.baglanti());
            txtId.Text = gridView1.GetFocusedRowCellValue("firmaId").ToString();
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void ozelKodAcıklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FirmaKod1 from Kodlar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RcKod1.Text = dr[0].ToString();

            }
            bgl.baglanti().Close();
        }
        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            listele();
            Sehirler();
            ozelKodAcıklamalar();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Firmalar (firmaAd,firmaYetkiliStatu,firmaYetkiliAdSoyad,firmaYetkiliTc,firmaTelefon1,firmaTelefon2,firmaTelefon3,firmaMail,firmaFax,firmaIl,firmaIlce,firmaVergiDaire,firmaAdres,ozelKod1,ozelKod2,ozelKod3, firmaSektor) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", txtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtTel1.Text);
            komut.Parameters.AddWithValue("@p6", txtTel2.Text);
            komut.Parameters.AddWithValue("@p7", txtTel3.Text);
            komut.Parameters.AddWithValue("@p8", txtMail.Text);
            komut.Parameters.AddWithValue("@p9", txtFax.Text);
            komut.Parameters.AddWithValue("@p10", Cmbil.Text);
            komut.Parameters.AddWithValue("@p11", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p12", txtVergi.Text);
            komut.Parameters.AddWithValue("@p13", RchAdress.Text);
            komut.Parameters.AddWithValue("@p14", txtKod1.Text);
            komut.Parameters.AddWithValue("@p15", txtKod2.Text);
            komut.Parameters.AddWithValue("@p16", txtKod3.Text);
            komut.Parameters.AddWithValue("@p17", txtSektor.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtAd.Text = "";
            txtYetkiliGorev.Text = "";
            txtYetkili.Text = "";
            txtTc.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";
            txtMail.Text = "";
            txtFax.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            txtVergi.Text = "";
            RchAdress.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtSektor.Text = "";

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["firmaId"].ToString();
                txtAd.Text = dr["firmaAd"].ToString();
                txtYetkiliGorev.Text = dr["firmaYetkiliStatu"].ToString();
                txtYetkili.Text = dr["firmaYetkiliAdSoyad"].ToString();
                txtTc.Text = dr["firmaYetkiliTc"].ToString();
                txtTel1.Text = dr["firmaTelefon1"].ToString();
                txtTel2.Text = dr["firmaTelefon2"].ToString();
                txtTel3.Text = dr["firmaTelefon3"].ToString();
                txtMail.Text = dr["firmaMail"].ToString();
                txtFax.Text = dr["firmaFax"].ToString();
                Cmbil.Text = dr["firmaIl"].ToString();
                Cmbilce.Text = dr["firmaIlce"].ToString();
                txtVergi.Text = dr["firmaVergiDaire"].ToString();
                RchAdress.Text = dr["firmaAdres"].ToString();
                grupkontrol.Text = dr["ozelKod1"].ToString();
                txtKod1.Text = dr["ozelKod1"].ToString();
                txtKod2.Text = dr["ozelKod2"].ToString();
                txtKod3.Text = dr["ozelKod3"].ToString();
                txtSektor.Text = dr["firmaSektor"].ToString();

            }
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Firmalar set firmaAd=@p1, firmaYetkiliStatu=@p2, firmaYetkiliAdSoyad=@p3 , firmaYetkiliTc=@p4, firmaTelefon1=@p5, firmaTelefon2=@p6, firmaTelefon3=@p7, firmaMail=@p8,firmaFax=@p9,firmaIl=@p10,firmaIlce=@p11,firmaVergiDaire=@p12,firmaAdres=@p13,ozelKod1=@p14,ozelKod2=@p15,ozelKod3=@p16,firmaSektor=@p17 where firmaId=@p18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", txtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtTel1.Text);
            komut.Parameters.AddWithValue("@p6", txtTel2.Text);
            komut.Parameters.AddWithValue("@p7", txtTel3.Text);
            komut.Parameters.AddWithValue("@p8", txtMail.Text);
            komut.Parameters.AddWithValue("@p9", txtFax.Text);
            komut.Parameters.AddWithValue("@p10", Cmbil.Text);
            komut.Parameters.AddWithValue("@p11", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p12", txtVergi.Text);
            komut.Parameters.AddWithValue("@p13", RchAdress.Text);
            komut.Parameters.AddWithValue("@p14", txtKod1.Text);
            komut.Parameters.AddWithValue("@p15", txtKod2.Text);
            komut.Parameters.AddWithValue("@p16", txtKod3.Text);
            komut.Parameters.AddWithValue("@p17", txtSektor.Text);
            komut.Parameters.Add("@p18", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            txtAd.Text = "";
            txtYetkiliGorev.Text = "";
            txtYetkili.Text = "";
            txtTc.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";
            txtMail.Text = "";
            txtFax.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            txtVergi.Text = "";
            RchAdress.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtSektor.Text = "";
        }
    }
}
