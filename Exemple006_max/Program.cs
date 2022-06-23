Console.WriteLine("Введите первую переменную");
//string number1 = Console.ReadLine();
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую переменную");
//string number2 = Console.ReadLine();
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью переменную");
//string number3 = Console.ReadLine();
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертую переменную");
//string number4 = Console.ReadLine();
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятую переменную");
//string number5 = Console.ReadLine();
int e = Convert.ToInt32(Console.ReadLine());

int max = a;

if ( b > max ) max = b;
if ( k > max ) max = k;
if ( d > max ) max = d;
if ( e > max ) max = e;

Console.Write("max=");
Console.WriteLine(max);