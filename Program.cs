namespace Tennisverein
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            List<Mensch> l = new List<Mensch>();
            l.Add(new Foerderer(Status.Gold, "Tom", "+43 444 444444", "n@gmx.at"));
            l.Add(new Foerderer(Status.Silber, "Julian", "+43 444 454444", "n@gmx.a43534t"));
            l.Add(new Mitglied("grg", "nq@gmx.at", "+43 660 1545456", new("AT04 646464 646546", 40, false)));
            l.Add(new Mitglied("htht", "nq@gmx.at", "+43 660 1545456", new("AT04 646464 646546", 40, true)));
            l.Add(new Foerderer(Status.Bronze, "Jimmy", "+43 444 464444", "n@gmx.at3223"));
            l.Add(new Mitglied("SImon", "nq@gmx.at", "+43 660 1545456", new("AT04 646464 646546", 40, true)));
            l.Add(new Mitglied("Qwq", "nq@gmx.at", "+43 660 1545456", new("AT04 646464 646546", 40, true)));
            l.Add(new Mitglied("csf", "nq@gmx.at", "+43 660 1545456", new("AT04 646464 646546", 40, false)));
            l.Add(new Mitglied("ggr", "nq@gmx.at", "+43 660 1545456", new("AT04 646464 646546", 40, true)));
          foreach(Mensch m in l)
            {
                Console.Write(m.GetInfo()+Environment.NewLine);
            }

        }
    }
}
