using ConsoleApp1;

Schiebetruhe < Kuebel > st1 = new();
Schiebetruhe<Sand> st2 = new();
Schiebetruhe<Ziegel> st3 = new();
st1.Befuelle(new Kuebel(3));
st2.Befuelle(new Sand());
st3.Befuelle(new Ziegel(Ziegel.Art.ganz));
st3.Befuelle(new Ziegel(Ziegel.Art.halb));

List<Schiebetruhe> Truhen = new List<Schiebetruhe>() { st1, st2, st3 };
Console.WriteLine(Truhen[2].ToString());
Console.WriteLine(Truhen[0].ToString());
Console.WriteLine(Truhen[1].ToString());
Console.WriteLine(Truhen[0].ToString());
Console.WriteLine("-------------------------------------");
Truhen.Sort();

for (int i = 0; i < Truhen.Count; i++)
{
    Console.WriteLine(Truhen[i].ToString());
}