
// transtypage (cast) implicite
using System.Globalization;

int nb = 42;
double nb2 = nb;


// transtypage (cast) explicite
double nb3 = 42.5;
int nb4 = (int)nb3;


string chaine = "42";
// un string ne peut être «Caster» en int
// int nombreEntier = (int)chaine;

int nombreEntier = int.Parse(chaine);
Console.WriteLine(nombreEntier * 25);

double nombreFlottant = double.Parse("42.05");
bool flag = bool.Parse("False");
DateTime date = DateTime.Parse("1982-05-06T12:46:42");


string value = 42.ToString();
string value2 = DateTime.Now.ToString(
    "dd MMMM yyyy", CultureInfo.GetCultureInfo("fr-BE")
);
Console.WriteLine(value2);

// ne fonctionne pas
//int myNumber = int.Parse("42.3");
int.TryParse("42.3", out int myNumber);
Console.WriteLine(myNumber);

string a = string.Empty; // ""
Console.WriteLine(a);

//Console.WriteLine("Entrez un nombre");
//int valeurEntree;
//while (!int.TryParse(Console.ReadLine(), out valeurEntree))
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Valeur incorrecte");
//    Console.ResetColor();
//}

// Console.WriteLine(valeurEntree);