using System.Text;

Console.WriteLine("test");
int age = 8;
Console.OutputEncoding = Encoding.UTF8;

if(age >= 18)
{
    // instructions
    Console.WriteLine("🙈🙈🙈🙈");
}
else if(age >= 12)
{
    Console.WriteLine("🐼🐼🐼🐼🐼🐼");
}
else
{
    // autre instructions
    Console.WriteLine("🦄🦄🦄🦄🦄");
}

string temps = "Sunny";
switch (temps)
{
    case "Soleil":
    case "Sunny":
        // instructions
        Console.WriteLine("☀️");
        break;
    case "Nuage":
    case "Cloudy":
        Console.WriteLine("☁️");
        break;
    default:
        Console.WriteLine("🌈");
        break;
}
