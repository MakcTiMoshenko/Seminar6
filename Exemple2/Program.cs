// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int b1 = ReadInt("Введите число b1: ");
int k1 = ReadInt("Введите число k1: ");
int b2 = ReadInt("Введите число b2: ");
int k2 = ReadInt("Введите число k2: ");
// double Perem(int b1, int k1, int b2, int k2){
 double x = (b2 - b1) / (k1 - k2);
 double y = k1 * x + b1;
//  return (x, y);
// }

// Perem(b1, k1, b2, k2);
System.Console.Write($"Точка пересечения двух прямых в x = {(x)}, y = {(y)}");