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
   public class LigneCommandeDAO
    {
        public static void delete(string num, string re)
        {
            Connexion.Ouvrir();
            SqlCommand cmdsup = new SqlCommand("delete from LigneCommande where num_cmd=@num and Ref_Prod=@ref", Connexion.cn);
            cmdsup.Parameters.AddWithValue("@ref", re);
            cmdsup.Parameters.AddWithValue("@num", num);
            cmdsup.ExecuteNonQuery();
            Connexion.Close();
        }
        public static void modifier(string num,string re,string qte)
        {
            Connexion.Ouvrir();
            SqlCommand cmdmod = new SqlCommand("update LigneCommande set num_cmd=@num, Ref_Prod=@ref,qte=@qte where num_cmd=@num and Ref_Prod=@ref", Connexion.cn);
            cmdmod.Parameters.AddWithValue("@num", num);
            cmdmod.Parameters.AddWithValue("@ref",re);
            cmdmod.Parameters.AddWithValue("@qte",qte);
            cmdmod.ExecuteNonQuery();
            Connexion.Close();
        }

        public static DataTable List_LigneCommande_ParNum(string num)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LigneCommande where num_cmd=@num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@num", num);
            da.Fill(dtc1);
            Connexion.Close();
            return dtc1;

        }
        public static DataTable List_LigneCommande_ParNum_Ref(string num, string re)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LigneCommande where num_cmd=@num and Ref_Prod=@ref", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@num", num);
            da.SelectCommand.Parameters.AddWithValue("@ref", re);
            da.Fill(dtc1);
            Connexion.Close();
            return dtc1;

        }
        public static bool Existe_listCommande(string num,string re)
        {
            Connexion.Ouvrir();
            SqlCommand cverif = new SqlCommand("select * from LigneCommande where Num_cmd=@num and Ref_Prod=@ref", Connexion.cn);
            cverif.Parameters.AddWithValue("@num", num);
            cverif.Parameters.AddWithValue("@ref", re);
            SqlDataReader drverif = cverif.ExecuteReader();
            if (drverif.HasRows == true)
            {
                drverif.Close();
                Connexion.Close();
                return true;
            }
            else
            {
                drverif.Close();
                Connexion.Close();
                return false;
            }

        }
    }
}
