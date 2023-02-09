// 33. Возведите число А в натуральную степень B используя цикл

int a=2;
int b=20;  // при В равном 0 получаем результат 1 , т.к. любое число в степени 0 равно 1
int result=1;
int i=0;
while(i<b)
    {
    result*=a; // result=result*a;
    i+=1;      // i=i+1; 
    }
System.Console.WriteLine(result);