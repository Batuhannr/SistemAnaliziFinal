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
namespace DXApplication1
{
    public partial class faturaDetay : Form
    {
        public faturaDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        public string id;
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FaturaDetay where FaturaId='"+id+"'", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void faturaDetay_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void faturaDetayUrunDuzenleBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmFaturaDetayUrunDuzenleme fr = new frmFaturaDetayUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["faturaUrunId"].ToString();
            }
            fr.Show();
        }

        private void btnUrunSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string degisken;
            SqlCommand komutsil = new SqlCommand("Delete From FaturaDetay where faturaUrunId = @p1", bgl.baglanti());
            degisken = gridView1.GetFocusedRowCellValue("faturaUrunId").ToString();
            komutsil.Parameters.AddWithValue("@p1", degisken);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
