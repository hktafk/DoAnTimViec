using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Do_An_Tuyen_Dung
{
    internal class LichSuNTD_DAO
    {
        DBConnection conn = new DBConnection();
        SqlConnection connStr = Connection.GetSqlConnection();
    }
}
