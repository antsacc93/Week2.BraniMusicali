using System;

namespace Week2.BraniMusicali
{
    class Program
    {
        static void Main(string[] args)
        {
            BranoMusicale brano = new BranoMusicale();
            int scelta = SchermoMenu();
            do
            {
                AnalizzaScelta(scelta, brano);
                scelta = SchermoMenu();
            } while (scelta != 3);
        }

        private static void AnalizzaScelta(int scelta, BranoMusicale brano)
        {
            switch (scelta)
            {
                case 1:
                    Program.InserisciBrano(brano);
                    break;
                case 2:
                    Program.StampaDettagli(brano);
                    break;
                default:
                    break;

            }
        }

        private static void StampaDettagli(BranoMusicale brano)
        {
            Console.WriteLine(brano.ToString());
        }

        private static void InserisciBrano(BranoMusicale brano)
        {
            
            Console.WriteLine("Inserisci il titolo");
            brano.Titolo = Console.ReadLine();
            Console.WriteLine("Inserisci l'artista");
            brano.Artista = Console.ReadLine();
            Console.WriteLine("Inserisci genere musicale:");
            //trasformazione della stringa inserita dall'utente in enum
            //try parse restituisce un booleano che verifica la correttezza della trasformazione
            int[] values = new int[] { 0, 1, 2 };
            foreach (int enumValue in values)
            {
                Console.WriteLine(Enum.GetName(typeof(GenereMusicale), enumValue));
            }
            bool success = Enum.TryParse(Console.ReadLine(), out GenereMusicale genere);
            while (!success)
            {
                Console.WriteLine("Inserisci un valore corretto");
                success = Enum.TryParse(Console.ReadLine(), out genere);
            }
            brano.Genere = genere;
            Console.WriteLine("Inserisci la durata del brano");
            brano.Durata = Convert.ToDouble(Console.ReadLine());

        }

        private static int SchermoMenu()
        {
            Console.WriteLine("1. Inserisci nuovo brano");
            Console.WriteLine("2. Stampa dettagli");
            Console.WriteLine("3. Esci");
            int scelta = Convert.ToInt32(Console.ReadLine());
            //verifico che l'input dell'utente
            while(scelta < 0 || scelta > 3)
            {
                Console.WriteLine("Insersici un valore corretto");
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            return scelta;
        }
    }
}
