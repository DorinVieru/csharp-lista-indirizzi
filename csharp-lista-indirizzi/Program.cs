namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Path del file
            string path = "C:\\Users\\User\\OneDrive - vxw2g\\Desktop\\CORSO BOOLEAN\\ESERCICIZI CORSO BOOLEAN\\.NET\\csharp-lista-indirizzi\\addresses.csv";
            var indirizzo = LeggiIndirizzoDaCSV(path);
            // Ciclo gli indirizzi per mostrarli in console
            foreach (var ind in indirizzo)
            {
                Console.WriteLine(ind.ToString());
            }

            // BONUS: Nuovo path per il nuovo file creato con la funzione ScriviNuovoFile
            string newpath = "C:\\Users\\User\\OneDrive - vxw2g\\Desktop\\CORSO BOOLEAN\\ESERCICIZI CORSO BOOLEAN\\.NET\\csharp-lista-indirizzi\\newaddresses.txt";
            ScriviNuovoFile(indirizzo, newpath);
        }

        // Funzione per leggere gli indirizzi in un file CSV e trasportarli all'interno di una Lista di oggetti
        public static List<Indirizzi> LeggiIndirizzoDaCSV(string path)
        {
            List<Indirizzi> indirizzo = new List<Indirizzi>();
            var stream = File.OpenText(path);

            int i = 0;
            while (!stream.EndOfStream)
            {
                var linea = stream.ReadLine();

                i++;
                if (i <= 1) // Ignoro la prima riga del testo
                    continue;

                try
                {
                    var dati = linea.Split(',');
                    string name = dati[0];
                    string surname = dati[1];
                    string street = dati[2];
                    string city = dati[3];
                    string province = dati[4];
                    int zip = int.Parse(dati[5]);

                    Indirizzi ind = new Indirizzi(name, surname, street, city, province, zip);
                    indirizzo.Add(ind);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Si è verificato un errore durante la lettura dell'indirizzo: {e.Message}");
                }
            }

            stream.Dispose();
            return indirizzo;
        }

        // BONUS: Funzione per creare nuovo file
        public static void ScriviNuovoFile(List<Indirizzi> indirizzo, string path)
        {
            using StreamWriter stream = File.CreateText(path);
            foreach (var ind in indirizzo)
                stream.WriteLine(ind.ToString());
        }
    }
}
