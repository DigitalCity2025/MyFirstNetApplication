// Calculer votre age ?
DateTime today = DateTime.Now;
DateTime dateNaissance = new DateTime(1990, 05, 31);

double age = (today - dateNaissance).TotalDays / 365.2425;

Console.WriteLine((int)age);
Console.WriteLine(Math.Floor(age));

// Calculer l'heure de la pause
DateTime pause = new DateTime(2024, 12, 23, 15, 0, 0);
TimeSpan diff = pause - today;
string pauseFormat = diff.ToString("c");
Console.WriteLine(pauseFormat);
Console.WriteLine($"{diff.Hours:D2}:{diff.Minutes:D2}:{diff.Seconds:D2}");