// С клавиатуры вводятся два числа a и b. Найти максимальное из них

double a,b;
System.Console.Write("Введите a: ");
a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b: ");
b=Convert.ToDouble(Console.ReadLine());
double max;
if (a>b)
{
  max=a;
}
else
{
  max=b;
}
System.Console.WriteLine($"max={max}");