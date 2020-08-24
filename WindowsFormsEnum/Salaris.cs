using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsEnum
{
    public class Salaris : Werknemer
    {
        public string Contract { get; set; }
        public double Netto { get; set; }
       
        public Salaris(string naam = "Geert", double salari = 2440.55, string land = "Belgium", string contract = "maand") : base(naam, salari,land)
        {
            Contract = contract;
            Netto = BerekenNetoo();
           
        }
        private double BerekenNetoo()
        {
            double netto = Salari/1.21;
            return Math.Round(netto,2);
        }
        public override string Beschrijft()
        {
            return base.Beschrijft() + $"\nType of contract: {Contract} \n" +
                $"Netto salaris: {Netto}";
        }
    }
}
