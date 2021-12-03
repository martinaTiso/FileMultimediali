using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali.Entities
{
abstract
        class FileMultimediale
    {

        private string Titolo { get; set; }

       
        public  Autore Autore { get; set; }


       
        //costruttote Filemultimediale
        public FileMultimediale(string titolo,string nome,string cognome,DateTime annoNascita)
        {
            Titolo = titolo;

            Autore = new Autore(nome,cognome, annoNascita);
        }
        public virtual string Print()
        {
            return $"Titolo: {Titolo}, Autore: {Autore}";
        }
    }
    
}
class Autore
{
    private string Nome { get; set; }

    private string Cognome { get; set; }
    private DateTime AnnoNascita { get; set; }

    public Autore(string nome, string cognome, DateTime annoNascita)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoNascita = annoNascita;

    }
   
}
