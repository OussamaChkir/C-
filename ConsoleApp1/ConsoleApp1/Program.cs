using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> LClient = new List<Client> { 
                new Client() { CIN_Cl = 10023321, Nom_Cl = "Tounsi", Prenom_Cl = "Aymen", Ville_Cl = "Tunis", Tel_Cl = 22324566 }, 
                new Client() { CIN_Cl = 11367588, Nom_Cl = "Soussi", Prenom_Cl = "Ali", Ville_Cl = "Sousse", Tel_Cl = 99745521 }, 
                new Client() { CIN_Cl = 11556477, Nom_Cl = "Sfaxi", Prenom_Cl = "Linda", Ville_Cl = "Sfax", Tel_Cl = 44321155 },
                new Client() { CIN_Cl = 10004532, Nom_Cl = "Ben Ahmed", Prenom_Cl = "Youssef", Ville_Cl = "Tunis", Tel_Cl = 40665433 },
                new Client() { CIN_Cl = 12134456, Nom_Cl = "Tounsi", Prenom_Cl = "Sofien", Ville_Cl = "Sfax", Tel_Cl = 20556439 } };
            List<Commande> LCommande = new List<Commande> { 
                new Commande() { Num_Cde = 10020, CIN_Cl = 10023321, Date_Cde = new DateTime(2016, 09, 15) },
                new Commande() { Num_Cde = 12114, CIN_Cl = 10023321, Date_Cde = new DateTime(2017, 01, 05) }, 
                new Commande() { Num_Cde = 45334, CIN_Cl = 10023321, Date_Cde = new DateTime(2017, 10, 23) },
                new Commande() { Num_Cde = 23112, CIN_Cl = 12134456, Date_Cde = new DateTime(2017, 06, 20) }, 
                new Commande() { Num_Cde = 33246, CIN_Cl = 12134456, Date_Cde = new DateTime(2017, 08, 12) }, 
                new Commande() { Num_Cde = 55112, CIN_Cl = 11556477, Date_Cde = new DateTime(2017, 12, 01) } };
            var Liste_Join = from Cl in LClient
                             //séquence externe 
                             join Cde in LCommande //séquence interne
                             on Cl.CIN_Cl equals Cde.CIN_Cl //clé jointure
                             select new { //résultat de jointure
                                 NomPren = Cl.Nom_Cl+" "+Cl.Prenom_Cl, NumCde = Cde.Num_Cde };
            foreach (var c in Liste_Join) 
                Console.WriteLine("{0}:{1}", c.NomPren, c.NumCde);

            //Utilisation de la syntaxe de requête
            //var Liste_Select = from Cl in LClient select Cl;
            ////Ou bien utilisation de la syntaxe de méthode
            //var Liste_Select1 = LClient.Select(Cl=>Cl);
            //foreach (var c in Liste_Select) 
            //    Console.WriteLine("{0} : {1}",c.CIN_Cl, c.Nom_Cl + c.Prenom_Cl); 

            //var LC_Filtre = from Cl in LClient where Cl.Ville_Cl.Equals("Sfax") select Cl;
            ////Ou bien utilisation de la syntaxe de méthode 
            //var LC_Filtre1= LClient.Where(Cl => Cl.Ville_Cl.Equals("Sfax"));
            ////Affichage de la liste filtrée
            //foreach (Client c in LC_Filtre) 
            //    Console.WriteLine("{0}  {1}", c.Nom_Cl, c.Prenom_Cl);

            //var LC_Triee1 = LClient.OrderBy(cl => cl.CIN_Cl);
            //var LC_Triee = from Cl in LClient orderby Cl.Nom_Cl, Cl.Prenom_Cl select new { Cl.CIN_Cl, NomPren = Cl.Nom_Cl + "  " + Cl.Prenom_Cl };
            //foreach(var c in LC_Triee) Console.WriteLine("{0}:{1} ", c.CIN_Cl, c.NomPren);

            //Utilisation de la syntaxe de requête 
            var Groupe_Client = from Cl in LClient group Cl by Cl.Ville_Cl;
            //itération pour chaque groupe 
            foreach (var gCl in Groupe_Client) { Console.WriteLine("Ville : {0}", gCl.Key); 
                //clé du groupe
                foreach (Client c in gCl) 
                    // Chaque groupe possède une collection interne 
                    Console.WriteLine("{0}  {1}", c.Nom_Cl, c.Prenom_Cl); }


            Console.Read();


        }
    }
}
