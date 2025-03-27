using System.Runtime.InteropServices;

namespace APBD01;

public class Gaz:Kontener,IHazardNotifier
{
    private string typLadunku;
    private char typ;
    public Gaz(double masa, double wagaWlasna, double wysokosc, double glebokosc, double maksLadownosc, string typLadunku) : base(masa, wagaWlasna, wysokosc, glebokosc, maksLadownosc)
    {
        this.typLadunku = typLadunku;
        typ = 'G';
    }

    public override void oproznij()
    {
        masa = masa - 0.05 * masa;
    }

    public override void ladowanie(double masaTowaru)
    {
        if (masa + masaTowaru > maksLadownosc)
        {
            throw new OverfillException("UWAGA!! PRZEŁĄDOWANIE!!");
        }

        masa += masaTowaru;
    }

    void checkForDanger()
    {
        if (typLadunku.Equals("niebezpieczny"))
        {
            uwaga();
        }
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