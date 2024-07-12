// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PrintNum(string Message)
{
    Console.Write(Message);
    string NumString = Console.ReadLine();
    int NumInt = Convert.ToInt32(NumString);
    return NumInt;
}

int[] InputArray(int length)
{
    int[] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = PrintNum($"enter {i + 1} element");
    }
    return array;
} 

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[{i}] = {array[i]}");
    }
}

int PositiveNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = PrintNum("Enter the numbers ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"number of digits greater than 0 - {PositiveNum(array)}");