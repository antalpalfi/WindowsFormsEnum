using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEnum
{
   public class Werknemer
    {
        public string Naam { get; set; }
        public double Salari { get; set; }
        public string Land { get; set; }
        
        
        public Werknemer(string naam, double salari = 2440.55, string land = "Belgium")
        {
           
            Naam = naam;
            Salari = salari;
            Land = land;
        }
        public Werknemer()
        {
        }
        public virtual string Beschrijft()
        {
            return $"Naam: {Naam}\n" + 
                $"Salari: {Salari} euro brutto\n" +
                $"Komt uit: {Land}";
        }
        public override string ToString()
        {
            return Naam;
        }


    }
}
