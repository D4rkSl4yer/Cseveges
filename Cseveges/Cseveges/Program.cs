namespace Cseveges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            Console.ReadKey();
        }

        private static void feladat6()
        {

        }

        private static void feladat5()
        {
            int leghosszabb = 0;
            for (int i = 0; i < Beszelgetes.Beszelgetesek.Count; i++)
            {
                if (Beszelgetes.Beszelgetesek[i].Veg - Beszelgetes.Beszelgetesek[i].Kezdet> Beszelgetes.Beszelgetesek[leghosszabb].Veg - Beszelgetes.Beszelgetesek[leghosszabb].Kezdet)
                {
                    leghosszabb = i;
                }
            }
            Console.WriteLine($"5. feladat: leghosszabb beszélgetés adatai\n\tKezdeményező:\t{Beszelgetes.Beszelgetesek[leghosszabb].Kezdemenyezo}\n\tFogadó:\t{Beszelgetes.Beszelgetesek[leghosszabb].Fogado}\n\tKezdete:\t{Beszelgetes.Beszelgetesek[leghosszabb].Kezdet}\n\tVége:\t{Beszelgetes.Beszelgetesek[leghosszabb].Veg}");
        }

        private static void feladat4()
        {
            Console.WriteLine($"4.feladat: Tagok száma: {Beszelgetes.Tagok.Count}fő - Beszélgetések: {Beszelgetes.Beszelgetesek.Count}");
        }

        private static void feladat3()
        {
            StreamReader sr = new StreamReader(@"csevegesek.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Beszelgetes.Beszelgetesek.Add(new Beszelgetes(sr.ReadLine()));
            }
            sr = new StreamReader(@"tagok.txt");
            while (!sr.EndOfStream)
            {
                Beszelgetes.Tagok.Add(sr.ReadLine());
            }
            sr.Close();
        }
    }
}