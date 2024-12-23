
// Créer une Date
DateTime date = new DateTime();
Console.WriteLine(date);

// Créer une date basée sur la date du jour
DateTime today = DateTime.Now;

// Formater une date
Console.WriteLine(today.ToString("dd/MM/yyyy"));
Console.WriteLine($"{today:dd/MM/yyyy}");

// Créer une date précise 
//DateTime dateDuDebutDeLaFormation = new DateTime(2024,12,9);
DateTime dateDuDebutDeLaFormation = DateTime.Parse("2024-12-09");
Console.WriteLine(dateDuDebutDeLaFormation);

Console.WriteLine(dateDuDebutDeLaFormation.Year);
Console.WriteLine(dateDuDebutDeLaFormation.DayOfWeek);

DateTime maDateDeNaissance = new DateTime(1982, 5, 6);

// calculer la différence entre 2 dates
Console.WriteLine((today - maDateDeNaissance).TotalDays);

Console.ReadKey();