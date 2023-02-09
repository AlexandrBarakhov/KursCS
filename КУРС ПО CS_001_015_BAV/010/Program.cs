// 10. Вывести на экран последнюю цифру целого числа введенного склавиатуры

int Z;
System.Console.Write("Введите число: ");
Z=System.Convert.ToInt32(System.Console.ReadLine());
int d0=Math.Abs(Z%10);
System.Console.WriteLine(d0);