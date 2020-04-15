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
         public static string cnxstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oussa\source\repos\TP4\ClassADO\_DATABASE\gestion.mdf;Integrated Security=True";
        //public static string cnxstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" +System.IO.Path.GetDirectoryName(Application.ExecutablePath) +"\\gestion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
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
