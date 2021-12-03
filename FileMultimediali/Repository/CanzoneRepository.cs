using FileMultimediali.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FileMultimediali.IRepositoryManager;

namespace FileMultimediali.Repository
{
    class CanzoneRepository : IRepositoryManager<Canzone>
    {
        static List<Canzone> canzoni = new List<Canzone>
        {
            new Canzone("nuvole", "Enaudi", GenereEnum.musica_classica,"luigi","Enaudi",new DateTime(1961,04,05)),
            new Canzone("Ma stasera", "Mengoni", GenereEnum.pop,"Marco","Mengoni",new DateTime (1991,3,4)),
            new Canzone("Malibu","Sangiovanni",GenereEnum.pop,"san","Giovanni",new DateTime(1991,9,06)),
            new Canzone("Marea","Madame",GenereEnum.pop,"Maria","madama",new DateTime(1994,08,07))

        };
        public List<Canzone> Fetch()
        {
            return canzoni;
        }
        
    }
}
