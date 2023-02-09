// 36. Написать программу вычисления произведения чисел от 1 до N

int n=5;             // здесь можно задать и 0, потому что факториал 0 существует и равен 1
int factorial=1;     
int i=0;
while (i<n)
    {
    i+=1;            // i=i+1;
    factorial*=i;    // factorial=factorial*i;
    }
System.Console.WriteLine(factorial);