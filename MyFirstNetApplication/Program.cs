using System.Collections;
using System.Dynamic;

ArrayList list = new();
list.Add(42);
list.Add(39);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine(list.Count);

list.Add("Coucou");

foreach (var item in list)
{
    Console.WriteLine(item);
}

List<double> numbers = new ();
numbers.Add(42);
//ints.Add("Hello");
numbers.Add(4.13);
numbers.Add(42);

// numbers.Remove(42); // [4.13, 42]
// numbers.RemoveAt(2);
// numbers.RemoveAll(n => n == 42);

numbers.AddRange([12, 66, 55]); // [4.13, 42, 12, 66, 55]

// vider une liste 
// numbers.Clear();

Console.WriteLine("---------");
foreach (var item in numbers)
{
    Console.WriteLine(item);
}


Hashtable hashtable = new();
hashtable.Add("one", "Maison");
hashtable.Add("two", "Appartement");
hashtable.Add("toto", "Chateau");
hashtable.Add(false, true);

Console.WriteLine(hashtable["toto"]);
Console.WriteLine(hashtable[false]);

Dictionary<string, string> dico = new();
dico.Add("test", "Khun");
dico.Add("machin", "Mike");

foreach (var item in dico.Values)
{
    Console.WriteLine(item);
}
Console.WriteLine("_________");
foreach (var item in dico.Keys)
{
    Console.Write("clé: ");
    Console.WriteLine(item);
    Console.Write("valeur: ");
    Console.WriteLine(dico[item]);
}
foreach (var item in dico)
{
    Console.Write("clé: ");
    Console.WriteLine(item.Key);
    Console.Write("valeur: ");
    Console.WriteLine(item.Value);
}

//foreach (var item in hashtable)
//{
//    Console.WriteLine(((DictionaryEntry)item).Key);
//}

Console.WriteLine("test");
numbers.Select((val, key) => (val, key)).ToList().ForEach(v =>
{
    Console.WriteLine(v.key);
    Console.WriteLine(v.val);
});

int i = 0;

foreach (var item in numbers)
{
    Console.WriteLine(item);
    Console.WriteLine(i++);
}

Dictionary<string, int> trad = new();
trad.Add("One", 1);
trad.Add("Two", 2);

var trad2 = new { One = 1, Two = 2 };

Console.WriteLine(trad["One"]);
Console.WriteLine(trad2.One);

dynamic d = new ExpandoObject();
d.One = 1;
d.Two = 2;
d.Three = 3;
Console.WriteLine(d.One);


//long value = long.Parse(Console.ReadLine());

