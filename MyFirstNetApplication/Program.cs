// string 

// concatenation
Console.WriteLine("42" + 42);

// nombre
// addition + 
Console.WriteLine(42 + 42); // 84

// soustraction -
// division /
// multiplication *
// modulo %

Console.WriteLine(5 % 3); // 2 car  5 = 3 * 1 + (2)

// affectaction
int a = 42; // 42
a += 6; // a = a + 6 // 48
a %= 9; // a = a % 9  // 3
// a <<= 2; // 12 // 11 => 1100 // 12
// post incrémentation
a++; // 4 // a = a + 1
// préincrémentation
++a; // 5 // a = a + 1

Console.WriteLine(++a); // 6
Console.WriteLine(a); // 6

// opérateur ternaire
int age = 17;
string categorie = age >= 18 ? "Adulte" : "Enfant";
Console.WriteLine(categorie);

// opérateur switch
int jour = 1;
string j = jour switch
{
    1 => "Lundi",
    2 => "Mardi",
    3 => "Mercredi",
    _ => "Je ne sais pas"
};

Console.WriteLine(j);

int? promo = null;
int prix = 42;

Console.WriteLine(prix - ((promo == null ? 0 : promo) * prix / 100));

// coalesce (ternaire qui donne une valeur par défaut si la variable est nulle)
Console.WriteLine(prix - ((promo ?? 0) * prix / 100));

string entree = Console.ReadLine() ?? string.Empty;
