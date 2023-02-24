namespace Grundämnen
{
    internal class Program
    {
        public class Grundämne
        {
            public string namn, z, typ, smältpunkt, kokpunkt;

            public void Print()
            {
                Console.WriteLine($"Grundämne: {namn}");
                Console.WriteLine($"Typ: {typ}");
                Console.WriteLine($"Smältpunkt: {smältpunkt}");
                Console.WriteLine($"Kokpunkt: {kokpunkt}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Grundämne syre = new Grundämne() { namn = "syre", z = "8", typ = "ickemetall", smältpunkt = "54,36 K", kokpunkt = "90,188 K" };
            Grundämne järn = new Grundämne() { namn = "järn", z = "26", typ = "metall", smältpunkt = "1811 K", kokpunkt = "3134 K" };
            Grundämne guld = new Grundämne() { namn = "guld", z = "79", typ = "metall", smältpunkt = "1337,33 K", kokpunkt = "3243 K" };

            syre.Print();
            järn.Print();
            guld.Print();
        }
    }
}