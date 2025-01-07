Person p = new();
p.age = 42;
p.prenom = "Khun";
p.nom = "Ly";
Person p2 = p;
p2.age = 43;
Console.WriteLine(p.age);


//PersonRecord record1 = new PersonRecord("Ly", "Khun", 42);
////record1.nom = "test";
//Console.WriteLine(record1.nom);

// création d'un type
struct Person
{
    public string nom;
    public string prenom;
    public int age;
}

//class PersonClass
//{
//    public string nom;
//    public string prenom;
//    public int age;
//}

//record PersonRecord(string nom, string prenom, int age);