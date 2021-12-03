using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali.Entities
{
    internal class Canzone :FileMultimediale
    {
        
        private string Titolo { get; set; }
       

        public GenereEnum Genere { get; set; }

        public Canzone(string titolo, string autore, GenereEnum genere, string nome, string cognome, DateTime annoNascita) : base(titolo,nome,cognome,annoNascita)
        {

            
            Genere = genere;
           
        }
        public override string Print()
        {
            return $"Canzone -> {base.Print()},Genere: {Genere} ";
        }
        
    }
    enum GenereEnum
    {
        musica_classica,
        metal,
        pop,
        jazz

    }
}
