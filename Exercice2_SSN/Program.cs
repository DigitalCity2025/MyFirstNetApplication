using System.Text.RegularExpressions;

Console.WriteLine("Entrez le registre nationale belge que vous souhaitez vérifier");
string entree = Console.ReadLine() ?? "";

int annee;
int mois;
int jour;
string cleanedString = entree.Replace(".", "").Replace("-", "");

int toControl;
int controlNumber;

//// xx.xx.xx-xxx.xx

//// vérifier le nombre de caractères
//if (entree.Length != 15)
//{
//    Console.WriteLine("Invalide");
//}

//// vérifier le placement de points et des tirets
//else if (entree[2] != '.' || entree[5] != '.' || entree[12] != '.' || entree[8] != '-')
//{
//    Console.WriteLine("Invalide");
//}
//// vérifier que les 6 premiers caractères forment une date correcte
//else if (!int.TryParse(entree[..2], out annee))
//{
//    Console.WriteLine("Invalide");
//}
//else if (!int.TryParse(entree[3..5], out mois) || mois > 12)
//{
//    Console.WriteLine("Invalide");
//}
//else if (!int.TryParse(entree[6..8], out jour) || jour > 31)
//{
//    Console.WriteLine("Invalide");
//}
//// vérifier les chiffres de controle (97 - (xxxxxxxxx % 97)) == xx
//else if (
//    !int.TryParse(cleanedString[..9], out toControl) 
//    || !int.TryParse(cleanedString[^2..], out controlNumber)
//    || 97 - (toControl % 97) != controlNumber
//)
//{
//    Console.WriteLine("Invalide");
//}
//else
//{
//    Console.WriteLine("Valide");
//}

string pattern = @"^\d{2}\.(0[1-9]|1[0-2])\.(0[1-9]|1[0-9]|2[0-9]|3[0-1])-\d{3}\.\d{2}$";
if(!new Regex(pattern).Match(entree).Success)
{
    Console.WriteLine("Invalide");
}
else if (
    !int.TryParse(cleanedString[..9], out toControl)
    || !int.TryParse(cleanedString[^2..], out controlNumber)
    || 97 - (toControl % 97) != controlNumber
)
{
    Console.WriteLine("Invalide");
}
else
{
    Console.WriteLine("Valide");
}