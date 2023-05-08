using System.Globalization;

namespace ConsoleApp1;

public class Schiebetruhe<T> : Schiebetruhe,IComparable where T: IWeightable
{
    private List<T> inhalt;

    public Schiebetruhe()
    {
        inhalt = new List<T>();
    }

    public void Befuelle(T item)
    {
        inhalt.Add(item);
    }

    public override string ToString()
    {
        return SchiebetruheGewicht().ToString(CultureInfo.InvariantCulture);
    }
    
    public int CompareTo(object? obj)
    {
        if (obj == null)
        {
            return 1;
        }
        
        if (this.SchiebetruheGewicht() < (obj as Schiebetruhe).SchiebetruheGewicht())
        {
            return -1;
        }
        
        else if (this.SchiebetruheGewicht() == (obj as Schiebetruhe).SchiebetruheGewicht())
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public override double SchiebetruheGewicht()
    {
        double weight = 0;
        for (int i = 0; i < inhalt.Count; i++)
        {
            weight += inhalt[i].GetWeight();
        }
        return weight;
    }
}