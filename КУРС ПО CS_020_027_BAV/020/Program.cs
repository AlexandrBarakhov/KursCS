// 20. Дано число. Проверить кратно ли оно 7 и 23

int z=161;
if (z%7==0 && z%23==0) // && - ленивый И
    System.Console.WriteLine($"Число {z} кратно 7 и 23");
else
    System.Console.WriteLine($"Число {z} не кратно 7 и 23");