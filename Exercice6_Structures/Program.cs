//Point?[,] tableau = new Point?[5, 5];

//for (int i = 0; i < tableau.GetLength(0); i++)
//{
//    //Point p = new();
//    //p.x = i + 1;
//    //p.y = i + 1;

//    tableau[i, i] = new()
//    {
//        x = i + 1,
//        y = i + 1,
//    };
//}

//for (int i = 0; i < tableau.GetLength(0); i++)
//{
//    for (int j = 0; j < tableau.GetLength(1); j++)
//    {
//        Point? p = tableau[i, j];
//        //if (p == null) 
//        //{
//        //    Console.Write("\t");
//        //}
//        //else
//        //{
//        //    Console.WriteLine($"X:{p?.x}-Y:{p?.y}");
//        //}
//        Console.Write(p == null ? "\t" : $"X:{p?.x}-Y:{p?.y}"); 
//    }
//    Console.Write("\n");
//}

Celcius c = new Celcius { temperature = 30 };
//Farenheit f = c.ToFarenheit();
//Console.WriteLine(f.temperature);
//Celcius c2 = f.ToCelcius();
//Console.WriteLine(c2.temperature);

Equation equation = new Equation()
{
    a = 1,
    b = -2,
    c = 1
};

Console.WriteLine(equation.Resoudre());



struct Point
{
    public int x;
    public int y;
}

struct Farenheit
{
    public double temperature;

    public Celcius ToCelcius()
    {
        double t = (temperature - 32) / 1.8;
        return new Celcius { temperature = t };
    }
}

struct Celcius
{
    public double temperature;

    public Farenheit ToFarenheit() 
    {
        double t = (temperature * 1.8) + 32;
        return new Farenheit { temperature = t };
    }
}


// ax² + bx + c = 0 



struct Equation
{
    public double a, b, c;

    public (bool, double?, double?) Resoudre() 
    {
        double delta = (b * b) - (4 * a * c);
        if(delta < 0)
        {
            return (false, null, null);
        }
        else
        {
            return (
                true, 
                (-b + Math.Sqrt(delta)) / (2 * a) ,
                (-b - Math.Sqrt(delta)) / (2 * a)
            );
        }
    }
}