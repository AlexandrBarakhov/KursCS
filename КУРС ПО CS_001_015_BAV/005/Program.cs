// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

double a1,a2,a3;
System.Console.Write("Введите a1: ");
a1=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите a2: ");
a2=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите a3: ");
a3=Convert.ToDouble(Console.ReadLine());
double max;
max=a1;
if (a2>max) 
max=a2;
if (a3>max)
max=a3;
System.Console.WriteLine($"max={max}");