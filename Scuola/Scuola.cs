using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
   public class Scuola
    {
        Alunno[] listaAlunni { get; set; }
        public string Nome { get; set; }
        public string Inidirizzo { get; set; }
        public string Apertura { get; set; }
        public string Chiusura { get; set; }

        //sinceramente non capisco se devo creare un metodo per memorizzare dati o solo le strutture necessare per contenerli,
        //dato che ogni parte della classe è settabile.

    }
}
