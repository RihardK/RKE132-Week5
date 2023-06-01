
Console.WriteLine("Enter the temperature:");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Boiling hot. Avoid going outside.");
}
else if (temp >= 20 && temp < 30)
{
    Console.WriteLine("Hot.");
}
else if (temp > 15 && temp < 20)
{
    Console.WriteLine("Warm.");
}
else if (temp > 10 && temp <= 15)
{
    Console.WriteLine("Chilly.");
}
else if (temp > 0 && temp <= 10)
{
    Console.WriteLine("Cold.");
}
else
{
    Console.WriteLine("Freezing. Wear extra layers.");
}