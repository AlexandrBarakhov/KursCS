// 12. С клавиатуры вводится целое число из диапазона [10, 99]. Показать наибольшую цифру числа

int Z;
System.Console.Write("Введите число из диапазона [10, 99]: ");
Z=System.Convert.ToInt32(System.Console.ReadLine());
int d0=Z%10;
int d1=Z/10%10;
if (d0>d1) 
System.Console.WriteLine(d0);
else
System.Console.WriteLine(d1);