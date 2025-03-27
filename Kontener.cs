namespace APBD01;
public class Kontener
{
    static int index = 0;

    protected double masa;
    protected double wagaWlasna;
    protected double wysokosc;
    protected double glebokosc;
    protected double maksLadownosc;
    protected string numerSeryjny;
    private char typ = 'K';

    
    public Kontener(double masa, double wagaWlasna, double wysokosc, double glebokosc, double maksLadownosc)
    {
        this.masa = masa; 
        this.wagaWlasna = wagaWlasna;
        this.wysokosc = wysokosc;
        this.glebokosc = glebokosc;
        this.maksLadownosc = maksLadownosc;
        numerSeryjny = getNumerSeryjny();
        
    }

    protected string getNumerSeryjny()
    {
        ++index;
        string numerSeryjny = "KON-" + typ+"-"+index;
        return numerSeryjny;
    }

    public virtual void oproznij()
    {
        masa = 0;
    }

    public virtual void ladowanie(double masaTowaru)
    {
        if (masa+masaTowaru > maksLadownosc)
        {
            throw new OverfillException("UWAGA!! PRZEŁĄDOWANIE!!");
        }
        masa += masaTowaru;
    }
    public override string ToString()
    {
        return $"Numer Seryjny: {numerSeryjny}, Masa: {masa}, Waga Własna: {wagaWlasna}, Wysokość: {wysokosc}, Głębokość: {glebokosc}, Maks. Ładowność: {maksLadownosc}";
    }
}

internal class OverfillException : Exception
{
    public OverfillException(string uwagaPrzełądowanie)
    {
        throw new NotImplementedException();
    }
}