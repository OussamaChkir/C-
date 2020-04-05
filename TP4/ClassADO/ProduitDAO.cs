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
  public  class ProduitDAO
    {
        public static void Inserer(Produit p)
        {
            Connexion.Ouvrir();
            SqlCommand cmdaj = new SqlCommand("insert into Produit(Ref_Prod, Desig_Prod, Categ_Prod, PrixV_Prod,Qte_prod) Values(@Ref,@Desig,@Categ,@Prix,@Qte)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Ref", p.Ref_Prod);
            cmdaj.Parameters.AddWithValue("@Desig", p.Desig_Prod);
            cmdaj.Parameters.AddWithValue("@Categ", p.Categ_Prod);
            cmdaj.Parameters.AddWithValue("@Prix", p.PrixV_Prod);
            cmdaj.Parameters.AddWithValue("@Qte", p.Qte_prod);
            cmdaj.ExecuteNonQuery();
            Connexion.Close();
        }
        public bool Existe_Produit(Int64 Ref)
        {
            Connexion.Ouvrir();
            SqlCommand cverif = new SqlCommand("select * from produit where Ref_Prod=@Ref",Connexion.cn);
            cverif.Parameters.AddWithValue("@Ref", Ref);
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
        public static void supprimer(string Ref)
        {
            Connexion.Ouvrir();
            SqlCommand cmdsup = new SqlCommand("delete from produit where Ref_Prod=@Ref",Connexion.cn);
            cmdsup.Parameters.AddWithValue("@Ref", Ref);
            cmdsup.ExecuteNonQuery();
            Connexion.Close();
        }
        public static void supp_all()
        {
            Connexion.Ouvrir();
            SqlCommand cmdsup = new SqlCommand("delete from produit ", Connexion.cn);
            cmdsup.ExecuteNonQuery();
            Connexion.Close();
        }
        public static void modifier(Produit p)
        {
            Connexion.Ouvrir();
            SqlCommand cmdmod = new SqlCommand("update produit set Desig_Prod=@Desig, Categ_Prod=@Categ,PrixV_Prod=@Prix,Qte_prod=@Qte where Ref_Prod=@Ref",Connexion.cn);
            cmdmod.Parameters.AddWithValue("@Ref", p.Ref_Prod);
            cmdmod.Parameters.AddWithValue("@Desig", p.Desig_Prod);
            cmdmod.Parameters.AddWithValue("@Categ", p.Categ_Prod);
            cmdmod.Parameters.AddWithValue("@Prix", p.PrixV_Prod);
            cmdmod.Parameters.AddWithValue("@Qte", p.Qte_prod);
            cmdmod.ExecuteNonQuery();
            Connexion.Close();
        }
        public static DataTable Liste_Produit()
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from produit", Connexion.cn);
            da.Fill(dtc1);
            return dtc1;
        }
        public static DataTable List_Prod_ParCateg(string Categ)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from produit where Categ_Prod=@Categ", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Categ", Categ);
            da.Fill(dtc1);
            Connexion.Close();
            return dtc1;

        }
        public static DataTable List_Prod_Ref(string Ref)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from produit where Ref_Prod=@Ref", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Ref", Ref);
            da.Fill(dtc1);
            Connexion.Close();
            return dtc1;

        }
        public static DataTable List_Prod_Des(string Des)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from produit where Desig_Prod=@Des", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Des", Des);
            da.Fill(dtc1);
            Connexion.Close();
            return dtc1;

        }

    }
}
