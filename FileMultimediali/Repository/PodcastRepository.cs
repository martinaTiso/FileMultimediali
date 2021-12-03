using FileMultimediali.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FileMultimediali.IRepositoryManager;

namespace FileMultimediali.Repository
{
     class PodcastRepository : IRepositoryManager<Podcast>
    {


        static List<Podcast> podcasts = new List<Podcast>
        {
            new Podcast("fiore","fiorello", "Romantico",List<Episodio> epi,"Francesco","Fiorello",new DateTime(1961,8,03)),
            new Podcast("Nuvole nere","Dolce nera", "Drammatico", 2)
        };
        public List<Podcast> Fetch()
        {
            return podcasts;
        }
        
    }
}
