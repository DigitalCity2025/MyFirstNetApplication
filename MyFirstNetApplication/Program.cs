bool flag = false;
bool flag2 = true;

int age = 42;
bool majeur = age > 18;

Console.WriteLine(majeur);

// > plus grand
// >= plus grand ou égal
// < plus petit
// <= plus petit ou égal
// == egal
// != différent

Console.WriteLine(42 == age);
Console.WriteLine(42.Equals(age));

string nom = "   Khun    ".Trim();
Console.WriteLine(nom.Equals("Khun"));
Console.WriteLine(nom == "Khun");

Console.WriteLine(nom == "kHuN"); // false
Console.WriteLine(nom.Equals("kHuN", StringComparison.InvariantCultureIgnoreCase)); // true

// OU inclusif, ET, XOR (OU Exclusif)
bool jeuneAdulte = age > 18 && age < 30;
Console.WriteLine(jeuneAdulte);

Console.WriteLine(age == 42 || nom == "Khun"); // OR
Console.WriteLine(age == 42 ^ nom == "Khun"); // XOR

Console.WriteLine(age == 42 || nom == "Khun");

// changer ou en et
Console.WriteLine(!(!(age == 42) && !(nom == "Khun")));

// inverser un booléen
bool test = true; // true
bool test2 = !test; // false

// loi de morgan
// !(cond1 && cond2) <=> !cond1 || !cond2
// !(cond1 || cond2) <=> !cond1 && !cond2





