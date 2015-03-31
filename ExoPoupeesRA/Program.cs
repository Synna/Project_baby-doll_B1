using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoupeesRA
{
    class Program
    {
        static void Main(string[] args)
        {
            // ETAPE 1
            List<Vetement> GardeRobe1 = new List<Vetement> { new Vetement("Fichu", "Noir"), new Vetement("Robe", "Gris") };
            Poupee Mary83 = new Poupee("Mary", 83, 70, Poupee.sexe.femme, 15, "Ecosse", 1853);
            Mary83.Habiller(GardeRobe1);

            List<Vetement> GardeRobe2 = new List<Vetement> { new Vetement("Pantalon", "Rouge"), new Vetement("Chemise", "Jaune"), new Vetement("Gilet", "Bleu foncé") };
            Poupee Michka76 = new Poupee("Michka", 76, 10, Poupee.sexe.homme, 20, "Russie", 1920);
            Michka76.Habiller(GardeRobe2);

            Mary83.ComparePrix(Michka76);
            Console.ReadLine();

            // ETAPE 2
            PoupeeParlante Leon1 = new PoupeeParlante("Léon", 1, 80, Poupee.sexe.homme, 40, "Russie", 1917);
            Phrase ru1 = new Phrase("da", "oui");
            Phrase ru2 = new Phrase("vodka", "pastis");
            Leon1.AjouterPhrase(ru1);
            Leon1.AjouterPhrase(ru2);

            PoupeeParlante Adolf2 = new PoupeeParlante("Adolf", 2, 30, Poupee.sexe.homme, 60, "Allemagne", 1937);
            Phrase al1 = new Phrase("heil", "salut");
            Phrase al2 = new Phrase("gut", "bien");
            Adolf2.AjouterPhrase(al1);
            Adolf2.AjouterPhrase(al2);

            Console.WriteLine("Le prix de la poupee Leon : " + Leon1.Prix());
            Console.WriteLine("Le prix de la poupee Adolf : " + Adolf2.Prix());
            Console.ReadLine();

            // ETAPE 3
            Console.WriteLine("Mary possède un chapeau ? " + Mary83.PossedeVetement("Chapeau"));
            Console.WriteLine("Michka possède un gilet ? " + Michka76.PossedeVetement("Gilet"));
            Console.WriteLine("Michka possède un gilet vert ? " + Michka76.PossedeVetement("Gilet", "Vert"));

            Console.ReadLine();

            // ETAPE 4
            Mary83.Afficher();

            Console.ReadLine();

            Leon1.Afficher();

            Console.ReadLine();

            // ETAPE 5
            BoiteMusique boite1 = new BoiteMusique(75, 50, "France", 1980, "Classique", 1, 180);

            Console.WriteLine(ViewModel.laCollection.Count);

            foreach(ObjetDeCollection o in ViewModel.laCollection)
            {
                o.Afficher();
                Console.ReadLine();
            }

        }
    }
}
