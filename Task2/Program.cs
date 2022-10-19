// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()??"0");
if (Math.Sqrt(num2)==num1)
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else if (Math.Sqrt(num1)==num2)
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
     Console.WriteLine("Одно из чисел НЕ является квадратом другого");
}