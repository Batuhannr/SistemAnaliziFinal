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
    public partial class frmBankalar : Form
    {
        public frmBankalar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgiler", bgl.baglanti());
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
        void FirmaListe() 
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select firmaId,firmaAd from Firmalar", bgl.baglanti());
            da.Fill(dt);
            GLUEFirma.Properties.NullText = "Bir Firma Seçiniz";
            GLUEFirma.Properties.ValueMember = "firmaId";
            GLUEFirma.Properties.DisplayMember = "firmaAd";
            GLUEFirma.Properties.DataSource = dt;

        }
        private void frmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            Sehirler();
            FirmaListe();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Bankalar(bankaAdi,bankaIl,bankaIlce,bankaSube,bankaIban,bankaHesapNo,bankaYetkili,bankaYetkiliTelefon,bankaTarih,bankaHesapTuru,fırmaId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", Cmbil.Text);
            komut.Parameters.AddWithValue("@p3", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", txtSube.Text);
            komut.Parameters.AddWithValue("@p5", txtIban.Text);
            komut.Parameters.AddWithValue("@p6", txtHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", txtTel.Text);
            komut.Parameters.AddWithValue("@p9", TxtTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtHesapTur.Text);
            komut.Parameters.AddWithValue("@p11", GLUEFirma.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtBankaAdi.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            txtSube.Text = "";
            txtIban.Text = "";
            txtHesapNo.Text = "";
            txtYetkili.Text = "";
            txtTel.Text = "";
            TxtTarih.Text = "";
            txtHesapTur.Text = "";
            GLUEFirma.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["Id"].ToString();
            txtBankaAdi.Text = dr["bankaAdi"].ToString();
            Cmbil.Text = dr["bankaIl"].ToString();
            Cmbilce.Text = dr["bankaIlce"].ToString();
            txtSube.Text = dr["bankaSube"].ToString();
            txtIban.Text = dr["bankaIban"].ToString();
            txtHesapNo.Text = dr["bankaHesapNo"].ToString();
            txtYetkili.Text = dr["bankaYetkili"].ToString();
            txtTel.Text = dr["bankaYetkiliTelefon"].ToString();
            TxtTarih.Text = dr["bankaTarih"].ToString();
            txtHesapTur.Text = dr["bankaHesapTuru"].ToString();
            //GLUEFirma.Text = dr["fırmaAd"].ToString();
        }

        private void btnBankaSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Bankalar where Id = @p1", bgl.baglanti());
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Bankalar set bankaAdi=@p1, bankaIl=@p3 , bankaIlce=@p4, bankaSube=@p5, bankaIban=@p6, bankaHesapNo=@p7, bankaYetkili=@p8,bankaYetkiliTelefon=@p9,bankaTarih=@p10,bankaHesapTuru=@p11 where Id=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p3", Cmbil.Text);
            komut.Parameters.AddWithValue("@p4", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p5", txtSube.Text);
            komut.Parameters.AddWithValue("@p6", txtIban.Text);
            komut.Parameters.AddWithValue("@p7", txtHesapNo.Text);
            komut.Parameters.AddWithValue("@p8", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p9", txtTel.Text);
            komut.Parameters.AddWithValue("@p10", TxtTarih.Text);
            komut.Parameters.AddWithValue("@p11", txtHesapTur.Text);
            komut.Parameters.Add("@p12", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
