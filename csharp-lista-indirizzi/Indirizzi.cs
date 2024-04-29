using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzi
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int ZIP { get; set; }

        // Costruttore 
        public Indirizzi (string name, string surname, string street, string city, string province, int zip)
        {
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.ZIP = zip;
        }

        // Imposto la visualizzazione degli indirizzi in Console
        public override string ToString()
        {
            return $"****************\n" +
                $"Nome: {Name} \n" +
                $"Cognome: {Surname} \n" +
                $"Piazza/Via: {Street} \n" +
                $"Città: {City}  \n" +
                $"Provincia: {Province} \n" +
                $"Codice ZIP: {ZIP}";
        }
    }
}
