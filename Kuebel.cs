namespace ConsoleApp1;

public class Kuebel : IWeightable
{
    public double liter;
    public Kuebel(double Liter)
    {
        this.liter = Liter;
    }
    public double GetWeight()
    {
        return liter * 0.85;
    }
}