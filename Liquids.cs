namespace APBD01;

public class Liquids : Kontener,IHazardNotifier
{
    private string typLadunku;
    private char typ;

    public Liquids(double masa, double wagaWlasna, double wysokosc, double glebokosc, double maksLadownosc,
        string typLadunku) : base(masa, wagaWlasna, wysokosc, glebokosc, maksLadownosc)
    {
        this.typLadunku = typLadunku;
        typ = 'L';
    }

    void checkForDanger()
    {
        if (typLadunku.Equals("niebezpieczny"))
        {
            uwaga();
        }
    }

    public override void ladowanie(double masaTowaru)
    {
        if (typLadunku.Equals("niebezpieczny"))
        {
            maksLadownosc = maksLadownosc*0.5;
        }else if (typLadunku.Equals("bezpieczny"))
        {
            maksLadownosc = maksLadownosc * 0.9;
        }
        
        if (masa + masaTowaru > maksLadownosc)
        {
            throw new OverfillException("UWAGA!! PRZEŁĄDOWANIE!!");
        }

        masa += masaTowaru;
    }

    public override string ToString()
    {
        return $"Numer Seryjny: {numerSeryjny}, Masa: {masa}, Waga Własna: {wagaWlasna}, Wysokość: {wysokosc}, Głębokość: {glebokosc}, Maks. Ładowność: {maksLadownosc}, Typ ładunku :{typLadunku}";
    }

    public void uwaga()
    {
        Console.WriteLine("UWAGA!");
    }
}