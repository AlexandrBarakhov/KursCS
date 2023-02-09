// 27. Найти расстояние между точками в 3D пространстве

double x1=1.5, y1=2.5, z1=5;
double x2=-1.5, y2=-2.5, z2=-5;

double distance= Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));

System.Console.WriteLine(distance);