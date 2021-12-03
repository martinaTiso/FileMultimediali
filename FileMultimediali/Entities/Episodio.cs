using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali.Entities
{
    internal class Episodio 
    {
        private string Titolo { get; set; }

        public Durata Durata { get; set; }

        private  bool Ascoltato { get; set; }

        public Episodio(string titolo, Durata durata,bool ascoltato)
        {
            Titolo = titolo;
            Durata = durata;
            Ascoltato = ascoltato;
        }
        public  string Print()
        {
            return $"Titolo: {Titolo},Durata: {Durata}";
        }

    }
    public struct Durata
    {
        public int Ore { get; set; }
        public int Minuti { get; set; }
        public int Secondi { get; set; }

        public Durata(int ore, int min, int sec)
        {
            Ore = ore;
            Minuti = min;
            Secondi = sec;
        }
    }
}

    

