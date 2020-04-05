using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ClassADO
{
  public  class Connexion
    {
        public static SqlConnection cn;
        public static string cnxstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=gestion;Integrated Security=True;Pooling=False";

        public static void Ouvrir()
        {
            cn = new SqlConnection();
            if (cn.State == ConnectionState.Closed)
            {
                cn.ConnectionString = cnxstring;
                cn.Open();
            }
        }
        public static void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
               
                cn.Close();
            }

        }
    }
}
