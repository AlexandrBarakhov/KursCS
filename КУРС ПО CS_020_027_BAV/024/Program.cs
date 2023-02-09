// 24. Определить номер четверти плоскости, в которой находится точка с координатами X и Y, причем X=!0 и Y=!0

int x=5, y=5;
if (x>0 && y>0) System.Console.WriteLine("Guarter 1");
if (x<0 && y>0) System.Console.WriteLine("Guarter 2");
if (x<0 && y<0) System.Console.WriteLine("Guarter 3");
if (x>0 && y<0) System.Console.WriteLine("Guarter 4");