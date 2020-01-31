using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WorkShopCSharp
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            conexion.Open();
            return conexion;
        }
    }
}
