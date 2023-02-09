// 6. Написать программу вычисления значения функции y=sin(x)

double angGradus, angRadian;
Console.WriteLine("Введите значение угла в градусах: ");
angGradus = Convert.ToInt32(Console.ReadLine());
angRadian = angGradus * Math.PI / 180;  // перевод в радианы
Console.WriteLine(Math.Sin(angRadian));