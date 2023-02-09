// 43. Написать подпрограмму замены элементов целочисленного массива типа int
// на противоположные по значению. Подпрограмма принимает на вход массив и в нем же и меняет значения.

void Opposite(int[] input)
{
    for(int i=0; i<input.Length; i++)
    { 
        input[i]*=-1;
    }  
}

int[] a=new int[15];
Random random=new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10); // не включая 10

for(int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

Opposite(a);

for(int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();