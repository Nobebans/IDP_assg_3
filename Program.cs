using System.Xml;

namespace Grundämnen
{
    internal class Program
    {
        public class Grundämne
        {
            //uppgift 1
            public string namn;
            public int z;
            public string typ;
            public double smältpunkt;
            public double kokpunkt;


            public void Print()
            {
                //uppgift 3
                Console.WriteLine($"Grundämne: {namn}");
                Console.WriteLine($"Typ: {typ}");
                Console.WriteLine($"Smältpunkt: {smältpunkt} K");
                Console.WriteLine($"Kokpunkt: {kokpunkt} K");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //uppgift 2
            Grundämne syre = new Grundämne();
            syre.namn = "syre";
            syre.z = 8;
            syre.typ = "ickemetall";
            syre.smältpunkt = 54.36;
            syre.kokpunkt = 90.188;

            Grundämne järn = new Grundämne();
            järn.namn = "järn";
            järn.z = 26;
            järn.typ = "metall";
            järn.smältpunkt = 1811;
            järn.kokpunkt = 3134;

            Grundämne guld = new Grundämne();
            guld.namn = "guld";
            guld.z = 79;
            guld.typ = "metall";
            guld.smältpunkt = 1337.33;
            guld.kokpunkt = 3243;

            //uppgift 3
            syre.Print();
            järn.Print();
            guld.Print();

            //upggift 4
            Grundämne[] grundämnen = new Grundämne[6];
            grundämnen[0] = syre;
            grundämnen[1] = järn;
            grundämnen[2] = guld;

            grundämnen[3] = new Grundämne();
            grundämnen[3].namn = "väte";
            grundämnen[3].z = 1;
            grundämnen[3].typ = "ickemetall";
            grundämnen[3].smältpunkt = 13.99;
            grundämnen[3].kokpunkt = 20.271;


            grundämnen[4] = new Grundämne();
            grundämnen[4].namn = "brom";
            grundämnen[4].z = 35;
            grundämnen[4].typ = "ickemetall";
            grundämnen[4].smältpunkt = 265.8;
            grundämnen[4].kokpunkt = 322;

            grundämnen[5] = new Grundämne();
            grundämnen[5].namn = "kvicksilver";
            grundämnen[5].z = 80;
            grundämnen[5].typ = "metall";
            grundämnen[5].smältpunkt = 234.321;
            grundämnen[5].kokpunkt = 629.88;

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

            //uppgift 7
            foreach (Grundämne grundämne in grundämnen)
            {
                if (grundämne.smältpunkt < 273.16 && grundämne.kokpunkt > 273.16)
                {
                    grundämne.Print();
                }
            }
        }
    }
}