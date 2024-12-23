// simple caractère
char l = 'K';
string prenom = "Khun";
string nom = "Ly";
double prix = 0.1D * 3; // 0.30000000000004

string phrase = "Bonjour\nles\t\"AMIS\"";
string phrase2 = @"Bonjour
les     ""AMIS""";

string directory = "c:\\Users\\Desktop";
string directory2 = @"c:\Users\Desktop";


Console.WriteLine(phrase);
Console.WriteLine(phrase2);
Console.WriteLine(directory);
Console.WriteLine(directory2);

// concatenation
Console.WriteLine("Bonjour " + prenom + " " + nom + " !!!");
// string format
Console.WriteLine("Bonjour {0} {1} !!!", prenom, nom);

// string interpolation
Console.WriteLine($"Bonjour {prenom} {nom} !!!");


Console.WriteLine($"Prix : {prix:F2}");

int mois = 1;
int jour = 5;
int annee = 2000;

Console.WriteLine($"{jour:D2}/{mois:D2}/{annee}");

string alphabet = "abcdefghijklmnopqrstuvwxyz";
char lettre = alphabet[4];

Console.WriteLine(lettre);

Console.WriteLine(alphabet[..5]);
Console.WriteLine(alphabet[23..]);
Console.WriteLine(alphabet[^3..]);
Console.WriteLine(alphabet[5..10]);
