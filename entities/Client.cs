using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.entities
{
    public class Client
    {
        private static int count;
        public int Id { get; set; }
        public string Surnom {  get; set; } 
        public string Telephone { get; set; }
        public string Adresse {  get; set; }

        public List<Dette> Dettes { get; } = new List<Dette>();
        public Client() {
            count++;
            Id = count;
        }
        public void AddDette(Dette dette)
        {
            Dettes.Add(dette);
            dette.Id = Dettes.Count;
            dette.Client = this;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Surnom: {Surnom}, Téléphone: {Telephone}, Adresse: {Adresse}";
        }
        public bool equals(Client other) {
            if (this == other) return true;
            if (other == null) return false;
            Client client =(Client)other;
            return Id == client.Id &&
                Surnom == client.Surnom &&
                Telephone == client.Telephone &&
                Adresse == client.Adresse;
        }

    }
}
