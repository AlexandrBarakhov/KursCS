// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumDigits(int n)
{
    if (n==0) 
        return 0;//пограничный случай
    int sum=0;
    while(n>0)
    {
        sum+=n%10;
        n/=10;
    }
        return sum;
}
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigits(N));