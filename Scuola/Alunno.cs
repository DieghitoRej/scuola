using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{

   public class Alunno
    {
      //commento giusto per mostrare il pull
        
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int età { get; set; }
    public string Città { get; set; }

    public string ToString()
     {
       return ("nome: " + Nome + "cognome: " + Cognome + "età: " + età + "Città di residenza: " + Città);
     }
    public string Biennio(int età)
        {
            if (età < 16)
            {
                return "Biennio";
            }
            else
            {
                return "Triennio";
            }
        }




    }
}
