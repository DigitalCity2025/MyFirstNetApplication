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

// transformer un enum en tableau d'enum
TypeDeCarburant[] types = Enum.GetValues<TypeDeCarburant>();
// [Diesel, Essence, Gaz, Electricite]


// transformer un enum en tableau de string
string[] types2 = Enum.GetNames<TypeDeCarburant>();
// [Diesel, Essence, Gaz, Electricite]

// transformer un string en enum
TypeDeCarburant type1 = Enum.Parse<TypeDeCarburant>("Diesel"); // Diesel

// transformer un enum en string
string s = TypeDeCarburant.Essence.ToString();

// transformer un int en enum
TypeDeCarburant type2 = (TypeDeCarburant)43; //Essence 

// transformer un enum en int
int value = (int)TypeDeCarburant.Electricite; // 45

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
