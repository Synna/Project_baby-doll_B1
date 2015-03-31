using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoupeesRA
{
    public class Vetement
    {
        public string nom;
        public string couleur;

        public Vetement(string leNom, string laCouleur = null)
        {
            this.nom = leNom;
            this.couleur = laCouleur;
        }
    }
}
