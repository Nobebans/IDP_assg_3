using System.Xml;

namespace Grundämnen
{
    internal class Program
    {
        public class Grundämne
        {
            //uppgift 1
            public string namn, z, typ, smältpunkt, kokpunkt;

            public void Print()
            {
                //uppgift 3
                Console.WriteLine($"Grundämne: {namn}");
                Console.WriteLine($"Typ: {typ}");
                Console.WriteLine($"Smältpunkt: {smältpunkt}");
                Console.WriteLine($"Kokpunkt: {kokpunkt}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //uppgift 2
            Grundämne syre = new Grundämne() { namn = "syre", z = "8", typ = "ickemetall", smältpunkt = "54,36 K", kokpunkt = "90,188 K" };
            Grundämne järn = new Grundämne() { namn = "järn", z = "26", typ = "metall", smältpunkt = "1811 K", kokpunkt = "3134 K" };
            Grundämne guld = new Grundämne() { namn = "guld", z = "79", typ = "metall", smältpunkt = "1337,33 K", kokpunkt = "3243 K" };

            //uppgift 3
            syre.Print();
            järn.Print();
            guld.Print();

            //upggift 4
            Grundämne[] grundämnen = new Grundämne[6];
            grundämnen[0] = syre;
            grundämnen[1] = järn;
            grundämnen[2] = guld;
            grundämnen[3] = new Grundämne { namn = "väte", z = "1", typ = "ickemetall", smältpunkt = "13,99 K", kokpunkt = "20,271 K" };
            grundämnen[4] = new Grundämne { namn = "brom", z = "35", typ = "ickemetall", smältpunkt = "265,8 K", kokpunkt = "322 K" };
            grundämnen[5] = new Grundämne { namn = "kvicksilver", z = "80", typ = "metall", smältpunkt = "234,321 K", kokpunkt = "629,88 K" };

            //uppgift 5
            foreach (Grundämne grundämne in grundämnen)
            {
                grundämne.Print();
            }

            //uppgift 6
            foreach (Grundämne metaller in grundämnen)
            {
                if (metaller.typ == "metall")
                {
                    metaller.Print();
                }
            }
        }
    }
}