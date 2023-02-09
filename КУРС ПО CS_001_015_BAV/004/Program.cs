// По заданному с клавиатуры номеру дня недели вывести его название

string? s;
int a;
System.Console.Write("Введите число: ");
s=Console.ReadLine();
a=Convert.ToInt32(s);
// a=Convert.ToInt32(Console.ReadLine());
/*
if (a==1)    
    System.Console.WriteLine("Понедельник");
if (a==2)    
    System.Console.WriteLine("Вторник");
if (a==3)    
    System.Console.WriteLine("Среда");   
if (a==4)    
    System.Console.WriteLine("Четверг");
if (a==5)    
    System.Console.WriteLine("Пятница");
if (a==6)    
    System.Console.WriteLine("Суббота");
if (a==7)    
    System.Console.WriteLine("Воскресенье");
*/

if (a==1)    
    System.Console.WriteLine("Понедельник");
    else
if (a==2)    
    System.Console.WriteLine("Вторник");
    else
if (a==3)    
    System.Console.WriteLine("Среда");
    else
if (a==4)    
    System.Console.WriteLine("Четверг");
    else
if (a==5)    
    System.Console.WriteLine("Пятница");
    else
if (a==6)    
    System.Console.WriteLine("Суббота");
    else
if (a==7)    
    System.Console.WriteLine("Воскресенье");
    else System.Console.WriteLine("Ошибка");