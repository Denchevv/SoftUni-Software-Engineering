int age = int.Parse(Console.ReadLine());

string title = "";

if (age >= 0 && age <= 2) { title = "baby"; }
else if (age <= 13) { title = "child"; }
else if (age <= 19) { title = "teenager"; }
else if (age <= 65) { title = "adult"; }
else { title = "elder"; }

Console.WriteLine(title);