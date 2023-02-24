namespace Grundämnen
{
    internal class Program
    {
        public class Grundämne
        {
            public string namn, z, typ, smältpunkt, kokpunkt;
        }

        static void Main(string[] args)
        {
            Grundämne syre = new Grundämne() { namn = "syre", z = "8", typ = "ickemetall", smältpunkt = "54,36", kokpunkt = "90,188"};
            Grundämne järn = new Grundämne() { namn = "järn", z = "26", typ = "metall", smältpunkt = "1811", kokpunkt = "3134" };
            Grundämne guld = new Grundämne() { namn = "guld", z = "79", typ = "metall", smältpunkt = "1337,33", kokpunkt = "3243" };
        }
    }
}