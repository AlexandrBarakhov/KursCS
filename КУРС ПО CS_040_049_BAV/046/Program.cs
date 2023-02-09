// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int h1=10;
int h2=99;
int[] a=new int[123];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,2);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int q=0;
for(int i=h1;i<=h2;i++)
    q=q+1;
System.Console.WriteLine($"Number of array elements: {q}");        
