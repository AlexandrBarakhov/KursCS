// 23. Проверить истинность утверждения !(X||Y) == !X && !Y
/*
X  Y      !(X||Y)     !X && !Y
0  0         1            1
0  1         0            0
1  0         0            0
1  1         0            0
*/
// При соответсвующих X и Y правая и левая часть утверждения эквивалентны

System.Console.WriteLine(test(false,false)||test(false,true)||test(false,true)||test(false,true));

bool test(bool x, bool y)
{
    return
    !(x||y) == (!x && !y);
}