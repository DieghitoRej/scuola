using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
   public class Scuola
    {
        public List<Alunno> listaAlunni = new List<Alunno>();
        public string Nome { get; set; }
        public string Inidirizzo { get; set; }
        public string Apertura { get; set; }
        public string Chiusura { get; set; }

        void AggiungiAlunno(List<Alunno> listaAlunni, Alunno alunnoNuovo)
        {
            listaAlunni.Add(alunnoNuovo);
        }
        public List<Alunno> RicercaCognome(string cognome)
        {
            List<Alunno> alunniTrovati = new List<Alunno>();
            foreach(Alunno alunno in listaAlunni)
            {
                string cognomeAlunno = (alunno.Cognome).ToLower();
                if(cognomeAlunno == cognome)
                {
                    alunniTrovati.Add(alunno);
                }
            }
            return alunniTrovati;
        }
        public List<Alunno> RicercaEtà(int età)
        {
            List<Alunno> alunniTrovati = new List<Alunno>();
            foreach (Alunno alunno in listaAlunni)
            {
                if (alunno.età == età)
                {
                    alunniTrovati.Add(alunno);
                }
            }
            return alunniTrovati;
        }
        public int alunniPresenti()
        {
            return listaAlunni.Count;
        }

    }
}
