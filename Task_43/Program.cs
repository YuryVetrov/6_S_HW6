// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2* x + b2; значения b1, k1, b2, k2 задаются пользователем
// k1 = 5, k2 = 9, b1 = 2, b2 = 4  -> (-0,5; 5,5)
Console.WriteLine("Даны два уравнения у = k1 * x + b1; и y = k2 * x + b2;");
System.Console.WriteLine("Введите число равное k1");
string K1 = Console.ReadLine(); // задаём строку для введения числа k1
System.Console.WriteLine("Введите число равное k2");
string K2 = Console.ReadLine(); // задаём строку для введения числа k2
System.Console.WriteLine("Введите число равное b1");
string B1 = Console.ReadLine(); // задаём строку для введения числа b1
System.Console.WriteLine("Введите число равное b2");
string B2 = Console.ReadLine(); // задаём строку для введения числа b2
double k1 = Convert.ToInt32(K1);
double k2 = Convert.ToInt32(K2);
double b1 = Convert.ToInt32(B1);
double b2 = Convert.ToInt32(B2);
//double b1 = 2;
//double k1 = 5;
//double b2 = 4;
//double k2 = 9;
/* из предоставленных уравнений найдём х, подставив вместо у второе уравнение
k1 * x + b1 = k2 * x + b2 
k1 * x - k2 *x = b2 - b1
x (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)
*/
double x = (b2 - b1) / (k1 - k2);
//System.Console.WriteLine(x);
/* из полученного значения х найдём у, подставив вместо х полученное значение
y1 = k1 * x + b1
y1 = k1 * (b2 - b1) / (k1 - k2) + b1

y2 = k2* x + b2
y2 = k2 * (b2 - b1) / (k1 - k2) + b2
*/
double y1 = k1 * (b2 - b1) / (k1 - k2) + b1;
double y2 = k2 * (b2 - b1) / (k1 - k2) + b2;

if(y1 == y2)
System.Console.WriteLine($"Координаты точки пересечения двух прямых ({x}; {y1})");
else
System.Console.WriteLine("Ошибка входных значений");
