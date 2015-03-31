using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoupeesRA
{
    public class Phrase
    {
        public string phraseOriginale;
        public string traductionFr;

        public Phrase(string phrase, string phraseFr)
        {
            this.phraseOriginale = phrase;
            this.traductionFr = phraseFr;
        }
    }
}
