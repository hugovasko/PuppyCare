// See https://aka.ms/new-console-template for more information

var remainingFood = int.Parse(Console.ReadLine()) * 1000;

var command = Console.ReadLine();

while (command != "Adopted")
{
    remainingFood -= int.Parse(command);
    command = Console.ReadLine();
}

if (remainingFood >= 0)
    Console.WriteLine($"Food is enough! Leftovers: {remainingFood} grams.");
else
    Console.WriteLine($"Food is not enough. You need {Math.Abs(remainingFood)} grams more.");