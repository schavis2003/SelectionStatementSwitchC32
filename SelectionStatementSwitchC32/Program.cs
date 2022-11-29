//Exercise 2
Console.WriteLine("What is your favorite school subject?");

var subject = Console.ReadLine();

switch (subject)
{
    case "Math":
        Console.WriteLine("Math is a tough subject!");
        break;

    case "Science":
        Console.WriteLine("Science is a tough subject!");
        break;

    case "English":
        Console.WriteLine("English is an interesting subject.");
        break;

    case "Algebra":
        Console.WriteLine("Algebra is a mindboggling subject!");
        break;

    case "Gym":
        Console.WriteLine("Gym is a fun and healthly subject for everyone, I think");
        break;

    default:
        Console.WriteLine("Oh wow! I haven't taken that subject before.");
        break;
}