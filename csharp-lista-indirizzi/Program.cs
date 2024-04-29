namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Path del file
            string path = "C:\\Users\\User\\OneDrive - vxw2g\\Desktop\\CORSO BOOLEAN\\ESERCICIZI CORSO BOOLEAN\\.NET\\csharp-lista-indirizzi\\addresses.csv";
            
        }

         public static List<Indirizzi> LeggiIndirizzoDaCSV(string path)
        {
            List<Indirizzi> indirizzo = new List<Indirizzi>();
            var stream = File.OpenText(path);

            
        }
    }
}
