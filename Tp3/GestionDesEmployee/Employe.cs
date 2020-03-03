using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesEmployee
{
   public abstract class Employe :IEquatable<Employe>
    {
        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Datenaissance { get; set; }

        public Employe(int Matricule,string Nom,string Prenom,DateTime Datenaissance)
        {
            this.Matricule = Matricule;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Datenaissance = Datenaissance;
        }

        public bool Equals(Employe e)
        {
            return e.Matricule == Matricule;
        }
        public override string ToString()
        {
            return "Matricule"+Matricule+"Nom"+Nom+"Prenom"+Prenom+"Date de Naissance"+Datenaissance;
        }
        public abstract double GetSalaire();
        
            
        
    }
}
