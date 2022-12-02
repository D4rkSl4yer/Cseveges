using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cseveges
{
    internal class Beszelgetes
    {
        public static List<Beszelgetes> Beszelgetesek = new List<Beszelgetes>();
        public static List<String> Tagok = new List<string>();
        public DateTime Kezdet { get; set; }
        public DateTime Veg { get; set; }
        public string Kezdemenyezo { get; set; }
        public string Fogado { get; set; }
        public Beszelgetes(string szöveg) 
        {
            string[] dbok = szöveg.Split(';');
            dbok[0] = dbok[0].Replace('-', ' ');
            dbok[1] = dbok[1].Replace('-', ' ');
            Kezdet = DateTime.Parse(dbok[0]);
            Veg = DateTime.Parse(dbok[1]);
            Kezdemenyezo= dbok[2];
            Fogado= dbok[3];
        }
        
    }
}
