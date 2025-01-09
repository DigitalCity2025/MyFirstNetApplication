Carte[] paquet = new Carte[52];

int i = 0;
foreach(Couleur couleur in Enum.GetValues<Couleur>())
{
    foreach (Valeur valeur in Enum.GetValues<Valeur>())
    {
        paquet[i].valeur = valeur;
        paquet[i].couleur = couleur;
        i++;
    }
}

// melanger des cartes
paquet = paquet
    .Select(c => (c, Guid.NewGuid()))
    .OrderBy(x => x.Item2)
    .Select(t => t.Item1).ToArray();

foreach (Carte item in paquet)
{
    Console.WriteLine($"{((int)item.valeur < 11 ? (int)item.valeur : item. valeur)} {item.couleur}");
}

Console.WriteLine();

enum Couleur
{
    Pique,
    Coeur,
    Carreau,
    Trefle
}

enum Valeur
{
    As = 14,
    Deux = 2,
    Trois,
    Quatre,
    Cinq,
    Six,
    Sept,
    Huit,
    Neuf,
    Dix,
    Valet,
    Dame,
    Roi
} 

struct Carte
{
    public Couleur couleur;
    public Valeur valeur;
}