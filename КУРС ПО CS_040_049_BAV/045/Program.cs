// 45. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

int[] a=new int[10];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,1000);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int numberOfEven=0;
int numberOfOdd=0;
for(int i=0;i<a.Length;i++)
    {
    if (a[i]%2==0)
        numberOfEven=numberOfEven+1;
    else numberOfOdd=numberOfOdd+1;
    }
System.Console.WriteLine($"Number of even: {numberOfEven}");        
System.Console.WriteLine($"Number of odd: {numberOfOdd}");