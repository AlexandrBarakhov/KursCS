// 26. Программа проверяет пятизначное число на палиндром

System.Console.Write("Введите пятизначное число: ");
string? y=System.Console.ReadLine();
int z=System.Convert.ToInt32(y);
int d0=z%10;
int d1=z/10%10;
// int d2=Z/100%10;
int d3=z/1000%10;
int d4=z/10000;
if (d0==d4 && d1==d3)
    System.Console.WriteLine($"Число {z} палиндром");
else
    System.Console.WriteLine($"Число {z} не палиндром");