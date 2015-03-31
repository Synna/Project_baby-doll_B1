using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoupeesRA
{
    public class PoupeeParlante : Poupee
    {
        List<Phrase> listePhrase = new List<Phrase>();

        public PoupeeParlante(string unNom, int uneMatricule, int unAgePersonnage, sexe unSexe, double uneTaille, string unPays, int uneAnneFabrication)
            : base(unNom, uneMatricule, unAgePersonnage, unSexe, uneTaille, unPays, uneAnneFabrication)
        {

        }

        public void AjouterPhrase(Phrase unePhrase)
        {
             listePhrase.Add(unePhrase);
        }

        public override void Afficher()
        {
            Console.WriteLine("----------- Poupée parlante " + this.nom + " -----------");
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Matricule : " + this.matricule);
            Console.WriteLine("Année de fabrication : " + this.anneeFabrication + " (age poupée : " + this.Age() + " )");
            Console.WriteLine("Sexe du personnage : " + this.leSexe);
            Console.WriteLine("Age du personnage repésenté : " + this.agePersonnage);
            Console.WriteLine("Pays d'origine : " + this.pays);
            Console.WriteLine("Taille poupée : " + this.taille + " cm");

            AfficherVetement();

            AfficherLangue();

            Console.WriteLine();
            Console.WriteLine("-> Prix : " + this.Prix() + " euros");

        }

        private void AfficherLangue()
        {
            if(listePhrase != null)
            {
                Console.WriteLine();
                Console.WriteLine("Phrases :");
                foreach(Phrase p in listePhrase)
                {
                    Console.WriteLine("- \"" + p.phraseOriginale + "\" (Fr : \"" + p.traductionFr + "\")");
                }
            }
        }
    }
}
