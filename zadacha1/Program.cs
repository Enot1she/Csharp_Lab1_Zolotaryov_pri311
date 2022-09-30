using Microsoft.Win32.SafeHandles;
using System.Diagnostics.Tracing;

// Zadanie1

//Console.WriteLine("Введите радиус окружности");
//double R = 0;
//R = Convert.ToDouble(Console.ReadLine());
//double L = Math.Round(2 * Math.PI * R, 3);
//double S = Math.Round(Math.PI * R * R, 3);
//double V = Math.Round(Math.PI * 4 / 3 * Math.Pow(R, 3), 3);
//Console.WriteLine("Длина окружности == " + L);
//Console.WriteLine("Площадь окружности == " + S);
//Console.WriteLine("Объем сферы == " + V);


// Zadanie2

//int a = 33, b = 22;
//Console.WriteLine("Изначальные значения переменных: a == " + a + " b == " + b);
//(a, b) = (b, a);
//Console.WriteLine("Значения переменных после замены: a == " + a + " b == " + b);


// Zadanie3

//Console.WriteLine("Введите любое трехзначное число от 100 до 999:");
//int a = 0;
//a = Convert.ToInt32(Console.ReadLine());
//int smm = 0, proizved = 0;
//int ch1 = 0, ch2 = 0, ch3 = 0;
//ch1 = a / 100;
//ch2 = a / 10 % 10;
//ch3 = a % 10;
//smm = ch1 + ch2 + ch3;
//proizved = ch1 * ch2 * ch3;
//Console.WriteLine("Сумма == " + smm);
//Console.WriteLine("Произведение == " + proizved);


// Zadanie4

//Console.WriteLine("Введите любое трехзначное число от 100 до 999:");
//int a = 0;
//a = Convert.ToInt32(Console.ReadLine());
//string newa;
//int ch1 = 0, ch2 = 0, ch3 = 0;
//ch1 = a / 100;
//ch2 = a / 10 % 10;
//ch3 = a % 10;
//newa = Convert.ToString(ch3) + Convert.ToString(ch2) + Convert.ToString(ch1);
//Console.WriteLine("Старое число == " + a);
//Console.WriteLine("Новое число == " + newa);





// Dop.zadanie1

//double x = 14.26;
//double y = -1.22;
//double z = 3.5 * 0.01;
//double t = 2 * Math.Cos(x - (Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + (z * z / (3 - z * z / 5)));
//Console.Write("t == " + t);

// Dop.zadanie6


double x = 0.01655;
double y = -2.75;
double z = 0.15;
double b = Math.Sqrt(10 * (Math.Pow(x, 1.0 / 3.0) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
Console.WriteLine("b == " + Math.Round(b, 6));

//Ответ в ворде должен быть с минусом




