Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1)
{
    Console.WriteLine(" второе число является квадратом первого числа");
}
else
{
    Console.WriteLine(" второе число не является квадратом первого числа");
} 