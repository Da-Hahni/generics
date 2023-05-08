namespace ConsoleApp1;

public class Ziegel : IWeightable
{
    private Art gewicht;

    public enum Art
    {
        ganz = 12,
        halb = 22
    }

    public Ziegel(Art EArt)
    {
       this.gewicht = EArt;
    }

    public double GetWeight()
    {
        return (double)gewicht;
    }
}