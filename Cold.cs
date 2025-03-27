namespace APBD01;

public class Cold : Kontener
{
    Dictionary<string, double> productTemperatures = new Dictionary<string, double>
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };
    
    string typLadunku;
    double temp;
    private char typ;
    public Cold(double masa, double wagaWlasna, double wysokosc, double glebokosc, double maksLadownosc,
        string typLadunku, double temp) : base(masa, wagaWlasna, wysokosc, glebokosc, maksLadownosc)
    {
        this.typLadunku = typLadunku;
        this.temp = temp;
        typ = 'C';
    }
    public override string ToString()
    {
        return $"Numer Seryjny: {numerSeryjny}, Masa: {masa}, Waga Własna: {wagaWlasna}, Wysokość: {wysokosc}, Głębokość: {glebokosc}, Maks. Ładowność: {maksLadownosc}, Typ ładunku :{typLadunku}";
    }

    void check()
    {
            if (productTemperatures.ContainsKey(typLadunku))
            {
                Console.WriteLine("zły typ ładunku");
            }

            if (temp < productTemperatures[typLadunku])
            {
                Console.WriteLine("UWAGA ZA NISKA TEMPERATURA");
            }

    }
}