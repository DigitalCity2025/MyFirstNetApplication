//Console.WriteLine("Entrer un nombre");
//int max = int.Parse(Console.ReadLine() ?? "");
//List<int> premiers = new();
//int nb = 2;
//while (nb <= max)
//{
//    // tester si nb est premier
//    bool estPremier = true;
//    for (int i = 2; i < nb; i++) 
//    {
//        if(nb % i == 0)
//        {
//            estPremier = false;
//            break;
//        }
//    }
//    if (estPremier)
//        premiers.Add(nb);
//    // tester le nombre suivant
//    nb++;
//}

//Console.WriteLine(string.Join(",", premiers));


//Console.WriteLine("Entrer un nombre");
//int max = int.Parse(Console.ReadLine() ?? "");
//List<int> premiers = new();
//for (int nb = 2; nb <= max; nb++)
//{
//    // tester si nb est premier
//    bool estPremier = true;
//    foreach(int i in premiers)
//    {
//        if (nb % i == 0)
//        {
//            estPremier = false;
//            break;
//        }
//    }
//    if (estPremier)
//        premiers.Add(nb);
//}

//Console.WriteLine(string.Join(",", premiers));

Console.WriteLine("Entrer un premier nombre");
string nb1 = Console.ReadLine() ?? "0";
Console.WriteLine("Entrer un second nombre");
string nb2 = Console.ReadLine() ?? "0";

nb1 = nb1.PadLeft(nb2.Length, '0');
nb2 = nb2.PadLeft(nb1.Length, '0');
char[] t1 = nb1.ToCharArray();
char[] t2 = nb2.ToCharArray();

Stack<int> result = new Stack<int>();
int report = 0;

for (int i = nb1.Length - 1; i >= 0; i--)
{
    int somme = int.Parse(t1[i].ToString()) + int.Parse(t2[i].ToString()) + report;
    report = somme >= 10 ? 1 : 0;
    result.Push(somme % 10);
}
if(report == 1)
{
    result.Push(report);
}


Console.WriteLine(string.Join("", result));



