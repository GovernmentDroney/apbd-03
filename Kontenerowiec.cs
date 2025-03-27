namespace APBD01;

public class Kontenerowiec
{
    List<Kontener> kontenery = new List<Kontener>();
    private double predkosc;
    int maksLadownosc;
    private double maksWagaLaczna;
    public Kontenerowiec(List<Kontener> kontenery, double predkosc, int maksLadownosc, double maksWagaLaczna)
    {
        this.kontenery = kontenery;
        this.predkosc = predkosc;
        this.maksLadownosc = maksLadownosc;
        this.maksWagaLaczna = maksWagaLaczna;
    }
    public override string ToString()
    {
        return $"Kontenerowiec: Prędkość: {predkosc} węzłów, Maks. Ładowność: {maksLadownosc}, Maks. Waga Łączna: {maksWagaLaczna}, Liczba Kontenerów: {kontenery.Count}\n" +
               string.Join("\n", kontenery);
    }

    public void zaladujKontener(Kontener kontener)
    {
        kontenery.Add(kontener);
    }

    public void zaladujKontener(List<Kontener> kontenery)
    {
        foreach (var kont in kontenery)
        {
            zaladujKontener(kont);
        }
    }

    public void usunKontener(Kontener kontener)
    {
        if (kontenery.Contains(kontener))
        {
            kontenery.Remove(kontener);
        }
    }

    public void zmianaKontenerow(Kontener kontener1, Kontener kontener2)
    {
        if (kontenery.Contains(kontener1))
        {
            kontenery.Remove(kontener1);
            kontenery.Add(kontener2);
        }
    }

    public void zamianaStatkow(Kontenerowiec statek1, Kontenerowiec statek2, Kontener kontener1)
    {
        if (statek1.kontenery.Contains(kontener1))
        {
            statek1.kontenery.Remove(kontener1);
            statek2.kontenery.Add(kontener1);
        }
    }
}
