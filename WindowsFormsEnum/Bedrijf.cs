using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEnum
{
    public class Bedrijf
    {
        public string BedNaam { get; set; }
        public string BtwNummer { get; set; }
        public List<Werknemer> WerkNemmersList { get; set; }

        public Bedrijf(string bNaam, string btwNummer)
        {
            BedNaam = bNaam;
            BtwNummer = btwNummer;
            WerkNemmersList = new List<Werknemer>();
        }
        public Bedrijf()
        {

        }
       
        public override string ToString()
        {
            return BedNaam;
        }
        public virtual string BedrijfInfo()
        {
            return $"Btw nummer: {BtwNummer}";
        }
    }
}
