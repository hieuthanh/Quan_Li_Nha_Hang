using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_QuanLi
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-9E5E5MG;Initial Catalog=QLCH;Integrated Security=True");
        //protected SqlConnection _conn = new SqlConnection("Data Source = COMPUTER; Initial Catalog = QLCH; Integrated Security = True");
        
    }
}
