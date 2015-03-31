using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoupeesRA
{
    public class BoiteMusique : ObjetDeCollection
    {
        int matricule;
        double taille;
        string pays;
        int annee;
        string style;
        int nbAir;
        double prix;

        public BoiteMusique(int laMatricule, double laTaille, string lePays, int lAnnee, string leStyle, int leNbAir, double lePrix)
        {
            ViewModel.laCollection.Add(this);
            this.matricule = laMatricule;
            this.taille = laTaille;
            this.pays = lePays;
            this.annee = lAnnee;
            this.style = leStyle;
            this.nbAir = leNbAir;

            AttribuerPrix(lePrix);

        }

        public void AttribuerPrix(double unPrix)
        {
            if(unPrix > (this.taille * Age() / 10 * this.nbAir))
            {
                this.prix = unPrix;
            }
            else
            {
                throw  new PrixTropBasException();
            }
        }

        private int Age()
        {
            return DateTime.Now.Year - annee;
        }

        public override void Afficher()
        {
            Console.WriteLine("----------- Boite à musique " + this.matricule + " -----------");
            Console.WriteLine("Matricule : " + this.matricule);
            Console.WriteLine("Année de fabrication : " + this.annee + " (age boîte : " + this.Age() + " ans )");
            Console.WriteLine("Pays d'origine : " + this.pays);
            Console.WriteLine("Taille boîte : " + this.taille + " cm");
            Console.WriteLine("Nombre d'airs : " + this.nbAir);
            Console.WriteLine("Style de musique : " + this.style);

            Console.WriteLine();
            Console.WriteLine("-> Prix : " + this.prix + " euros");

        }
    }
    public class PrixTropBasException : Exception
    {
        public PrixTropBasException() : base("Le prix attribué est trop bas.")
        {

        }
    }
}
