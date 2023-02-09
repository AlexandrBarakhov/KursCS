// 15. С клавитуры вводиться целое число. Вывести третью цифру числа или сообщить, что ее нет (Вывести: NO)

int Z;
Console.Write("Введите число: ");
Z=Convert.ToInt32(Console.ReadLine());
int D=Z/100;
if (D != 0)
    {
  //int result = D % 10;
  //если введенное число трехзначное отрицательное, то выводиться отрицательная третья цифра, поэтому нужен Abs      
    int result = Math.Abs(D % 10);
    Console.WriteLine($"Третья цифра числа {Z} равна {result}");
    }
else
    Console.WriteLine("NO");