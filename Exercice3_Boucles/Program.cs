//// F1 -> 1
//// F2 -> 1
//// F3 -> 1+1 = 2
//// F4 -> 1+2 = 3
//// F5 -> 2+3 = 5
//// F6 -> 3+5 = 8
//// FN -> FN-1 + FN-2

//int fnMoins1 = 1, fnMoins2 = 1;
//for (int i = 3; i <= 25; i++)
//{
//    int fn = fnMoins1 + fnMoins2;
//    fnMoins2 = fnMoins1;
//    fnMoins1 = fn;
//    Console.WriteLine($"F{i} = {fn}");
//}

//// 1! = 1
//// 2! = 1 * 2 = 2
//// 3! = 1 * 2 * 3 = 6
//// 4! = 1 * 2 * 3 * 4 = 24
//// n! = 1 * 2 * ... * n

//Console.WriteLine("Calculer le factoriel de ...");
//int nb = int.Parse(Console.ReadLine());

//decimal value = 1;
//for (int i = 2; i <= nb; i++)
//{
//    value = value * i;
//}
//Console.WriteLine(value);

//Console.WriteLine("Calculer les n premiers nombres premiers ...");
//int nb = int.Parse(Console.ReadLine() ?? "0");
//int compteur = 0;

//for (int i = 2; compteur < nb; i++)
//{
//    bool estPremier = true;
//    for (int j = 2; j < i; j++)
//    {
//        if(i % j == 0)
//        {
//            estPremier = false;
//            break;
//        }
//    }
//    if(estPremier)
//    {
//        Console.WriteLine(i);
//        compteur++;
//    }
//}

//for (int table = 1; table <= 5; table++)
//{
//	for (int multiplicateur = 1; multiplicateur <= 20; multiplicateur++)
//	{
//        Console.Write($"{table} X {multiplicateur} = {table * multiplicateur}");
//        Console.Write("\t");
//	}
//    Console.Write("\n");
//}

//for (int i = 0; i < 100; i++)
//{
//    int table = (i / 20) + 1;
//    int multi = (i % 20) + 1;
//    Console.WriteLine($"{table} X {multi} = {table * multi}");
//}

//for (double i = 0; i <= 20; i += 0.1)
//{
//    Console.WriteLine(i);
//}

// si a est une approximation de racine de b alors
// (a² + b) / 2a sera une meilleure approximation

//double a = 1;
//while(Math.Abs((a * a) - 2) > 0.000000000001)
//{
//    a = (a * a + 2) / (2 * a);
//    Console.WriteLine(a);
//}