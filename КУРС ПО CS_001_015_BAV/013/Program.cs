// 13. Удалить вторую цифру целого числа введенного с клавиатуры

int Z;
System.Console.Write("Введите число: ");
Z=System.Convert.ToInt32(System.Console.ReadLine());
int d0=Z%10;
// int d1=Z/10%10;
int d2=Z/100;
Z=d0+d2*10; 
System.Console.WriteLine(Z);