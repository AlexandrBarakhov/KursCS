// 8. Вывести на экран числа от -N до N

int N,i;
Console.WriteLine("Введите N: ");
N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // проброс каретки чтобы не сливалось
i=-N;
while (i<=N)
{
    System.Console.WriteLine(i);   
    i++;
}