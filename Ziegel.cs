namespace ConsoleApp1;

public class Ziegel : IWeightable
{
    public enum Art {ganz = 12, halb = 22}

    public Art gewicht;

    public Art ganz;
    public Ziegel(Art EArt)
    {
        gewicht = EArt;
    }

    public double GetWeight()
    {
        return (double)gewicht;
    }
}