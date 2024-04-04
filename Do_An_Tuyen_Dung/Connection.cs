using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Do_An_Tuyen_Dung
{
    internal class Connection
    {
        private static readonly string stringConnection = @"Data Source=DESKTOP-T4EF20F\SQLEXPRESS;Initial Catalog=DoAnNhom;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }


    }
}
