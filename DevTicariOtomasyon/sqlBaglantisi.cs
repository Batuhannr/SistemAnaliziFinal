using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DevTicariOtomasyon
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4RTTF1C;Initial Catalog=DBTicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
                
        }
    }
}
