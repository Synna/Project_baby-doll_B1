using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoupeesRA
{
    public class Poupee : ObjetDeCollection
    {
        public enum sexe { homme, femme };

        protected string nom;
        protected int matricule;
        protected int anneeFabrication;
        protected int agePersonnage;
        protected sexe leSexe;
        protected double taille;
        protected string pays;
        protected List<Vetement> listeVetement;

        public Poupee(string unNom, int uneMatricule, int unAgePersonnage, sexe unSexe, double uneTaille, string unPays, int uneAnneFabrication)
        {
            ViewModel.laCollection.Add(this);
            this.nom = unNom;
            this.matricule = uneMatricule;
            this.agePersonnage = unAgePersonnage;
            this.leSexe = unSexe;
            this.taille = uneTaille;
            this.pays = unPays;
            this.anneeFabrication = uneAnneFabrication;
        }

        public void Habiller(List<Vetement> lesVetements)
        {
            this.listeVetement = lesVetements;
        }

        public double Prix()
        {
            double leprix = 0;
            if(this.Age() <= 30)
            {
                leprix = this.taille;
            }
            else
            {
                leprix = this.taille * (Age() - 20) / 10;
            }
            if (typeof(Poupee) == this.GetType())
            {
                leprix = leprix * 1.3;
            }
            return leprix;
        }

        protected int Age()
        {
            return DateTime.Now.Year - anneeFabrication;
        }

        public void ComparePrix(Poupee uneAutrePoupee)
        {
            Console.WriteLine("- La poupee \"" +  this.nom + "\" coûte : " + this.Prix() + " euros.");
            Console.WriteLine("- La poupee \"" + uneAutrePoupee.nom + "\" coûte : " + uneAutrePoupee.Prix() + " euros.");

            if(this.Prix() > uneAutrePoupee.Prix())
                Console.WriteLine("->   La poupee \"" + this.nom + "\" est plus chère que \"" + uneAutrePoupee.nom + "\".");
            else if (this.Prix() < uneAutrePoupee.Prix())
                Console.WriteLine("->   La poupee \"" + uneAutrePoupee.nom + "\" est plus chère que \"" + this.nom + "\".");
            else
                Console.WriteLine("->   Les poupees ont le même prix.");

        }

        public bool PossedeVetement(string unVetement, string uneCouleur = null)
        {
            foreach(Vetement v in listeVetement)
            {
                if (v.nom == unVetement && v.couleur == uneCouleur || v.nom == unVetement && uneCouleur == null)
                    return true;
            }
            return false;
        }

        public override void Afficher()
        {
            Console.WriteLine("----------- Poupée " + this.nom + " -----------");
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Matricule : " + this.matricule);
            Console.WriteLine("Année de fabrication : " + this.anneeFabrication + " (age poupée : " + this.Age() + " ans )");
            Console.WriteLine("Sexe du personnage : " + this.leSexe);
            Console.WriteLine("Age du personnage repésenté : " + this.agePersonnage);
            Console.WriteLine("Pays d'origine : " + this.pays);
            Console.WriteLine("Taille poupée : " + this.taille + " cm");

            AfficherVetement();

            Console.WriteLine();
            Console.WriteLine("-> Prix : " + this.Prix() + " euros");

        }

        protected void AfficherVetement()
        {
            if(listeVetement != null)
            {
                Console.WriteLine();
                Console.WriteLine("Garde robe : ");
                foreach (Vetement v in listeVetement)
                {
                    if (v.couleur != null)
                    {
                        Console.WriteLine("-  " + v.nom + " ( " + v.couleur + " )");
                    }
                    else
                        Console.WriteLine("-  " + v.nom);
            }
            }
        }

    }
}
