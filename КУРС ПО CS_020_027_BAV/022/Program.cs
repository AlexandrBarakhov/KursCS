// 22. По двум заданным числам проверять является ли одно квадратом другого

double a,b;
string? s;
System.Console.Write("Введите первое число: ");
s=System.Console.ReadLine();
a=System.Convert.ToDouble(s);
System.Console.Write("Введите второе число: ");
s=System.Console.ReadLine();
b=System.Convert.ToDouble(s);

/*
if (a*a==b)    
    System.Console.WriteLine($"Число {b} является квадратом числа {a}");
else 
    if (b*b==a)    
        System.Console.WriteLine($"Число {a} является квадратом числа {b}");
    else
        System.Console.WriteLine($"Числа {a} и {b} не являются квадратами друг друга");    
*/

if (a*a==b)    
    System.Console.WriteLine($"Число {b} является квадратом числа {a}");
if (b*b==a)    
    System.Console.WriteLine($"Число {a} является квадратом числа {b}");
if (a*a!=b && b*b!=a)
    System.Console.WriteLine($"Числа {a} и {b} не являются квадратами друг друга");