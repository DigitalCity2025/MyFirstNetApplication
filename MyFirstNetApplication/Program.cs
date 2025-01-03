//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");
//Console.WriteLine("Hello");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    Console.WriteLine("Hello");
}

// multiple itérateurs
for (int i = 0, j = 25; i < 10 || j > 5; i++, j -= 2)
{
    Console.WriteLine(i);
    Console.WriteLine(j);
    Console.WriteLine("_____________");
}

// while 
//bool condition = true;

//while (condition)
//{
//    Console.WriteLine("Entrez un nombre");
//    int nombre = int.Parse(Console.ReadLine());
//    if(nombre > 5)
//    {
//        condition = false;
//    }
//}

int nb = 42;
//while (nb <= 5)
//{
//    Console.WriteLine("Entrez un nombre");
//    nb = int.Parse(Console.ReadLine());
//}

// do while
// pour être certain que les instructions soit éxécutées
// au moins une fois
do
{
    Console.WriteLine("Entrez un nombre");
    nb = int.Parse(Console.ReadLine());
} while (nb <= 5);


int[] tab = [42, 73, 12, 53, 4, 15, 66, 87];
foreach (int value in tab)
{
    Console.WriteLine(value);
}

//var enumerator = tab.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current);
//}
//enumerator.Reset();


