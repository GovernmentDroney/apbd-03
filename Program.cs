using APBD01;

class main
{
    public static void Main(String[] args)
    {
        List<Kontener> list1 = new List<Kontener>();
        Kontenerowiec kontenerowiec = new Kontenerowiec(list1, 5.0, 6, 600.0);
        Kontener kontener1 = new Cold(55.0, 6.0, 3.0,10.0,60, "bananas", 13.0);
        Kontener kontener2 = new Gaz(40.3, 6.0, 3.0,10.0,60, "niebezpieczny");
        kontener1.ladowanie(1.0);
    }
}