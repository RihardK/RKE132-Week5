
int math, bio, chem;

Console.WriteLine("Enter your maths result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your bio results:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chem results:");
chem = Int32.Parse(Console.ReadLine());

if (math >= 90 && bio >= 90 && chem >= 90)
{
    Console.WriteLine("Congratulatons, you have been accepted!");
}
else
{
    Console.WriteLine("Sorry, your scores are too low.");
}