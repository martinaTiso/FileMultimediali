using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali.Entities
{
    internal class Podcast :FileMultimediale
    {
        

        private string Titolo { get; set; }
        
        private string Descrizione { get; set; }
        
        public List<Episodio> InsiemeEpisodi { get; set; }

        public Podcast(string titolo, Autore Autore,string  descrizione,List<Episodio>insiemeEpisodi,  string nome, string cognome, DateTime annoNascita) : base(titolo,nome, cognome, annoNascita)
        {
            Titolo = titolo;
            Descrizione = descrizione;
            InsiemeEpisodi = insiemeEpisodi;

           
        }
        public override string Print()
        {
            return $"Podcast-> {base.Print()}, Descrizione: {Descrizione} InsiemeEpisodi, {InsiemeEpisodi} ";
        }
    }
}
