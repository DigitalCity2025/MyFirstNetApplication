// Diesel, Essence, Gaz , Electricite

// dans une chaine de caractère il n'y a pas de restriction
string carburant = "glmsjflmg";

TypeDeCarburant carbu = TypeDeCarburant.Diesel;

Console.WriteLine((TypeDeCarburant)42);

Console.WriteLine((int)carbu);

Role r = Role.Reassortisseur | Role.Rh | Role.Vendeur;
Console.WriteLine(r);

// Vérifie si un enum contient un autre enum 
if(r.HasFlag(Role.Directeur) && r.HasFlag(Role.Vendeur))
{
    Console.WriteLine("Bienvenue monsieur le directeur");
}

// transformer un enum en tableau
TypeDeCarburant[] types = Enum.GetValues<TypeDeCarburant>();

// transformer un string en enum
TypeDeCarburant type1 = Enum.Parse<TypeDeCarburant>("Diesel");

// transformer un int en enum
TypeDeCarburant type2 = (TypeDeCarburant)3;

// transformer un enum en int
int value = (int)TypeDeCarburant.Electricite;

enum TypeDeCarburant
{
    Diesel = 42,
    Essence,
    Gaz,
    Electricite
}

[Flags]
enum Role 
{
    Vendeur = 1,
    Reassortisseur = 2,
    Rh = 4,
    Directeur = 8
}

// 8 => 1000
// 4 => 0100
// 2 => 0010
// 1 => 0001

// 0001
