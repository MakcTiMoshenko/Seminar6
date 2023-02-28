// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ImputArray(string text)
{
    System.Console.WriteLine(text);
    return  Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] numberM = ImputArray("Введите числа M: ");

// int CountElements(int count)
// {
    int count=0;
    for(int i=0; i<numberM.Length; i++){
        if (numberM[i]>0) 
        count++;
    }
//     return count;
// }


PrintArray(numberM);
// CountElements(numberM);
// Console.WriteLine($"Количество введеных пользователем чисел больше 0 =  {CountElements(numberM)}");
Console.WriteLine($"Количество введеных пользователем чисел больше 0 =  {count}");