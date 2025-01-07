Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("🌈");


Person p;

// appels de la fonction Parler
p.Parler();
p.Parler();
p.Parler();
p.Parler();
p.Parler();

//appels de la fonction Test
Test();
Test();
Test();
Test();
Test();
Test();

int value = FactorielDe(5);
Console.WriteLine(value);

void Test()
{
    // définition de la fonction
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ceci est un test !!");
    Console.ResetColor();
}

int FactorielDe(int nb)
{
    int result = 1;
    for (int i = 2; i <= nb; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(Diviser(1, 42));

double Diviser(double nb1 = 1, double nb2 = 1)
{
    return nb1 / nb2;
}

Test44(nb: 4, s: "");

void Test44(in string s = "", int nb = 55)
{
    // on ne peut plus modifier un paramètre précédé du mot clé in
    //s = "dswdfsq";
}


double Somme(params double[] values)
{
    double result = 0;
    foreach (var item in values)
    {
        result += item;
    }
    return result;
}

int v = 42;

// passer la reference plutot que la valeur
void UpdateValue(ref int v2)
{
    v2 = 45;
}

UpdateValue(ref v);
Console.WriteLine(v); //45


List<int> list = [1,2,3];
UpdateList(list);

Console.WriteLine(4.13);

void UpdateList(in List<int> l)
{
    l.Add(4);
}

Console.WriteLine(list.Last());


Console.WriteLine("-------------------");
Console.WriteLine(Somme(42,7,8,9,11,33,99));


// retourner plusieurs valeurs
(int, bool, string , char) Test55555()
{
    return (42, true, "Khun", '\n');
}

(int nb, bool flag, string s, char c) = Test55555();
(int, bool, string, char) tuple = Test55555();
Console.WriteLine(tuple.Item1); 
Console.WriteLine(nb);



struct Person
{
    // définition de la fonction
    /// <summary>
    /// Ecrit dans la console qq chose
    /// </summary>
    public void Parler() 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Bonjour je m'appelle Khun");
        Console.ResetColor();
    }
}