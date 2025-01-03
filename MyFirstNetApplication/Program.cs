int a = 42;

//type de valeur[]

// créer un tableau contenant 4 entiers
// par defaut [0,0,0,0]
int[] tableau = new int[4];
Console.WriteLine();

string[] tableauDeString = new string[4];
// [null, null, null, null]

// initialisation d'un tableau avec plusieures valeurs
string[] noms = [ "Khun", "Mike", "Thierry" ];
string[] autresNoms = { "Khun", "Mike", "Thierry" };

Console.WriteLine(noms == autresNoms); // false
Console.WriteLine(noms.SequenceEqual(autresNoms)); // true

// recupérer un élémént d'un tableau
Console.WriteLine(noms[2]); // Thierry

// modifier un élément du tableau
Console.WriteLine(noms[2] = "Simon");
Console.WriteLine(noms[2]); // Simon

// slice
string[] nomsDeMesCollegues = autresNoms[^2..]; // ["Mike", "Thierry"]

// longueur d'un tableau
int l = nomsDeMesCollegues.Length;
int l2 = nomsDeMesCollegues.Count();

Console.WriteLine(l);
Console.WriteLine(l2);

// attention à ne pas sortir des indexs d'un tableau
// string n = noms[42];

// inverser les valeurs du tableau
noms = noms.Reverse().ToArray();

Console.WriteLine(string.Join(",", noms)); // Simon, Mike, Khun

// copie de l'addresse mémoire du tableau
string[] t = noms;
t[0] = "Caroline";
Console.WriteLine(noms[0]); // Caroline

// copie des valeurs du tableau
string[] t2 = noms.ToArray();
//string[] t2 = [..noms];
t2[0] = "John";
Console.WriteLine(noms[0]); // Caroline


// ["Ringo", "Caroline", "Mike", "Khun", "Steve"]
string[] t3 = ["Ringo", ..noms, "Steve"];

int[] ints = new int[0];
if(ints.Length == 0)
{
    Console.WriteLine("Le tableau est vide");
}

Console.WriteLine();

// multidimension

// tableau de tableaux
int[][] tableauDeTableaux = new int[5][];
tableauDeTableaux[0] = [1, 2, 3];
tableauDeTableaux[1] = [5, 2, 42];

// les tailles des tableaux internes peuvent être différentes
tableauDeTableaux[2] = [5, 2, 44, 33, 66];

int[,] matrice = new int[4, 6];
matrice[0, 5] = 42;

//int[,,,,] matice2 = new int[4, 5, 3, 2, 6];

//object[] objects = [1, "", 555F, true];

//object[][] tabtab = new object[5][];
//tabtab[0] = [1,2,3];
//tabtab[2] = ["","",""];

Console.WriteLine();