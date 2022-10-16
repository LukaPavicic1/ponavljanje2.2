using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje2._2
{
    class Stablo
    {
        private bool otpadajuListovi;
        string vrstaStabla;

        public Stablo(bool otpadajuListovi)
        {
            OtpadajuListovi = otpadajuListovi;
        }

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public override string ToString()
        {
            if (OtpadajuListovi == true)
            { vrstaStabla = "bijelogoricno"; }
            else
            { vrstaStabla = "crnogoricno"; }
            return ("Otpadaju listovi: " + OtpadajuListovi + " Vrsta stabla: " + vrstaStabla);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);
            Console.WriteLine(stablo1.ToString());
            Console.WriteLine(stablo2.ToString());
            Console.ReadKey();
        }
    }
}
