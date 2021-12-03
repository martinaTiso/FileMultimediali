// See https://aka.ms/new-console-template for more information
using FileMultimediali.Entities;
using FileMultimediali.Repository;



//// DOMAANDE TEORICHE
/// <summary>
///

//ESERCIZIO 1

//a.inizializzazione
//b.dichiarazione
//c.assegnazione

//ESERCIZIO 2

//value

//ESERICIZIO 3

//C

//ESERCIZIO 4

//C

//ESERCIZIO 5

//int i;------

//Person p----

//string s=String.Empty------vuota


//double ? d------ null




public static CanzoneRepository canzoneRepo = new CanzoneRepository();
public static PodcastRepository podcastRepo = new PodcastRepository();

{
    bool continuare = true;
    int scelta;


    while (continuare)
    {
        Console.Write("Premi un qualunque tasto");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Premi 1 per vedere tutte le canzoni");
        Console.WriteLine("Premi 2 per vedere tutti i podcast ");
        Console.WriteLine("Premi 3 per filtrare le canzoni per genere");
        Console.WriteLine("Premi 4 per filtrare il podcast per episodi");
        Console.WriteLine("Premi 5 per filtrare gli episodi per durata");
        Console.WriteLine("Premi 6 per ");
        Console.WriteLine("Premi 0 per uscire");

        do
        {
            Console.WriteLine("Fai la tua scelta");
        } while (!int.TryParse(Console.ReadLine(), out scelta));

        switch (scelta)
        {
            case 1:
                {
                    /*List<Canzone> canzoni = FetchCanzoni()*/;
                    Stampa(canzoni);
                    
                    break;
                }
            case 2:
                {

                    break;
                }
            case 3:
                {

                    break;
                }
            case 4:
                {

                    break;
                }
            case 5:
                {

                    break;
                }
            case 6:
                {
                    break;
                }
            case 0:
                {
                    continuare = false;
                    break;
                }

        }

    }
    //public static List<Canzone> FetchCanzoni()
    //{
    //    List<Canzone> canzoni = new List<Canzone>();

    //    canzoni.AddRange(canzoneRepo.Fetch());


    //    return canzoni;
    //}
    //public static List<Podcast> FetchPodcast()
    //{
    //    List<Podcast> podcasts = new List<Podcast>();

    //    podcasts.AddRange(podcastRepo.Fetch());


    //    return podcasts;
    }
    public  static  void Stampa(List<Canzone>canzoni)
    {
        foreach (var canzone in canzoni)
        {
            Console.WriteLine(canzone.Print());
        }
    }







