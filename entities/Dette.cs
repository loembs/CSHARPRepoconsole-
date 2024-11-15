using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.entities;

namespace ConsoleApp.entities
{
    public class Dette
    {

        public DateTime Date { get; set; } = DateTime.Now; // Date du jour par defaut
        public float Montant { get; set; }
        public int Id { get; set; }

        // Relation
        public Client Client { get; set; }


        public override string ToString()
        {
            return $"Dette n°{Id}, du {Date:dd/MM/yyyy} pour {Montant}";
        }


    }
}
