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
    public class ClientADO
    {
        public static void inserer(client c)
        {
            Connexion.Ouvrir();
            SqlCommand cmdaj = new SqlCommand("insert into client(cin_cl,Nom_cl,pren_cl,ville_cl,tel_cl) Values(@cin,@nom,@pren,@ville,@tel)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@cin", c.cin_cl);
            cmdaj.Parameters.AddWithValue("@nom", c.Nom_cl);
            cmdaj.Parameters.AddWithValue("@pren", c.pren_cl);
            cmdaj.Parameters.AddWithValue("@ville", c.ville_cl);
            cmdaj.Parameters.AddWithValue("@tel", c.tel_cl);
            cmdaj.ExecuteNonQuery();
            Connexion.Close();
        }
        public static void supprimer(Int64 cin)
        {
            Connexion.Ouvrir();
            SqlCommand cmdsup = new SqlCommand("delete from client where cin_cl = @cin", Connexion.cn);
            cmdsup.Parameters.AddWithValue("@cin", cin);
            cmdsup.ExecuteNonQuery();
            Connexion.Close();
        }
        public static void modifier(client c)
        {
            Connexion.Ouvrir();
            SqlCommand cmdaj = new SqlCommand("update client set cin_cl=@cin,Nom_cl=@nom,pren_cl=@pren,ville_cl=@ville,tel_cl=,@tel ", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@cin", c.cin_cl);
            cmdaj.Parameters.AddWithValue("@nom", c.Nom_cl);
            cmdaj.Parameters.AddWithValue("@pren", c.pren_cl);
            cmdaj.Parameters.AddWithValue("@ville", c.ville_cl);
            cmdaj.Parameters.AddWithValue("@tel", c.tel_cl);
            cmdaj.ExecuteNonQuery();
            Connexion.Close();
        }
        public static DataTable Liste_Client()
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from client", Connexion.cn);
            da.Fill(dtc1);
            return dtc1;
        }
        public static DataTable Liste_Client_ParCin(Int64 cin_cl)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from client where cin_cl=@cin", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@cin", cin_cl);
            da.Fill(dtc1);
            return dtc1;
        }
        public static DataTable Liste_Client_ParNom(string nom)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from client where Nom_cl=@nom", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@nom", nom);
            da.Fill(dtc1);
            return dtc1;
        }
        public static DataTable Liste_Client_ParPren(string pren)
        {
            Connexion.Ouvrir();
            DataTable dtc1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from client where pren_cl=@pren", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@pren", pren);
            da.Fill(dtc1);
            return dtc1;
        }
    }
}
