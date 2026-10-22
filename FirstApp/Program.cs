int age;

while (true)
{
    Console.WriteLine("Скільки тобі років?");
    string input = Console.ReadLine() ?? "";

    if (int.TryParse(input, out age) && age >= 0)
    {
        break;
    }

    Console.WriteLine("Помилка! Введи ціле невід'ємне число.");
}

if (age < 18)
{
    Console.WriteLine("Ти неповнолітній.");
}
else if (age < 65)
{
    Console.WriteLine("Ти дорослий.");
}
else
{
    Console.WriteLine("Ти у старшій віковій категорії.");
}