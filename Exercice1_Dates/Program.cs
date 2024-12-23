// Calculer votre age ?
DateTime today = DateTime.Now;
DateTime dateNaissance = new DateTime(1990, 05, 31);

double age = (today - dateNaissance).TotalDays / 365.2425;

Console.WriteLine((int)age);
Console.WriteLine(Math.Floor(age));