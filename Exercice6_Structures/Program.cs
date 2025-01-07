Point?[,] tableau = new Point?[5, 5];

for (int i = 0; i < tableau.GetLength(0); i++)
{
    //Point p = new();
    //p.x = i + 1;
    //p.y = i + 1;
    
    tableau[i, i] = new()
    {
        x = i + 1,
        y = i + 1,
    };
}

for (int i = 0; i < tableau.GetLength(0); i++)
{
    for (int j = 0; j < tableau.GetLength(1); j++)
    {
        Point? p = tableau[i, j];
        //if (p == null) 
        //{
        //    Console.Write("\t");
        //}
        //else
        //{
        //    Console.WriteLine($"X:{p?.x}-Y:{p?.y}");
        //}
        Console.Write(p == null ? "\t" : $"X:{p?.x}-Y:{p?.y}"); 
    }
    Console.Write("\n");
}

struct Point
{
    public int x;
    public int y;
}

struct Farenheit
{
    public double temperature;
}

struct Celcius
{
    public double temperature;
}
