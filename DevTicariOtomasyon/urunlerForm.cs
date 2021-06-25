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
    public partial class urunlerForm : Form
    {
        public urunlerForm()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From Urunler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Urunler(urunAd,urunMarka,urunModel,urunYıl,urunAdet,urunAlisFiyat,urunSatisFiyat,urunDetay) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", txtYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((txtAlis.Text)));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((txtSatis.Text)));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtAlis.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtSatis.Text = "";
            txtUrunAdi.Text = "";
            txtYil.Text = "";
            NudAdet.Value = 0;
            RchDetay.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Urunler set urunAd=@p1, urunMarka=@p2, urunModel=@p3 , urunYıl=@p4, urunAdet=@p5, urunAlisFiyat=@p6, urunSatisFiyat=@p7, urunDetay=@p8 where urunId=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", txtYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((txtAlis.Text)));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((txtSatis.Text)));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.Parameters.Add("@p9", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnnUrunSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Urunler where urunId = @p1", bgl.baglanti());
            txtId.Text = gridView1.GetFocusedRowCellValue("urunId").ToString();
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void urunlerForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["urunId"].ToString();
            txtUrunAdi.Text = dr["urunAd"].ToString();
            txtAlis.Text = dr["urunAlisFiyat"].ToString();
            txtMarka.Text = dr["urunMarka"].ToString();
            txtModel.Text = dr["urunModel"].ToString();
            txtSatis.Text = dr["urunSatisFiyat"].ToString();
            txtYil.Text = dr["urunYıl"].ToString();
            NudAdet.Value = decimal.Parse(dr["urunAdet"].ToString());
            RchDetay.Text = dr["urunDetay"].ToString();
        }
    }
}
