using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassADO
{
  public  class CommandeDAO
    {
        public static void Inserer(commande c,List<LigneCommande> lc)
        {
            Connexion.Ouvrir();
            SqlTransaction transaction = Connexion.cn.BeginTransaction();
            SqlCommand cmdaj = new SqlCommand();
            cmdaj.Connection = Connexion.cn;
            cmdaj.Transaction = transaction;
            try { 
                //commande1
            cmdaj.CommandText= "insert into commande(Num_cmd, cin_cl, date_cmd) Values('" + c.Num_cmd + "','" + c.cin_cl + "','" + c.date_cmd + "')";
            cmdaj.ExecuteNonQuery();
                //commande2
            for(int i = 0; i < lc.Count(); i++)
                {
            cmdaj.CommandText= "insert into LigneCommande(num_cmd, Ref_Prod, qte) Values('" + lc[i].num_cmd + "','" + lc[i].Ref_Prod + "','" + lc[i].qte + "')";
            cmdaj.ExecuteNonQuery();
                }
                transaction.Commit();
            }catch(Exception ex)
            {
                Console.Write(ex);
                transaction.Rollback();
            }
            finally
            {
                Connexion.Close();
            }
            
        }
        public static bool Existe_Commande(string num)
        {
            Connexion.Ouvrir();
            SqlCommand cverif = new SqlCommand("select * from commande where Num_cmd=@num", Connexion.cn);
            cverif.Parameters.AddWithValue("@num", num);
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
        public static DataTable List_Com_Num(string num)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from commande where Num_cmd=@num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@num", num);
            da.Fill(dtc1);
            Connexion.Close();
            return dtc1;

        }
    }
}
