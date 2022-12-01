Console.WriteLine("Input first numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second numbers");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, min = {number2}");
}
else
{
    Console.WriteLine($"max = {number2}, min = {number1}");
}