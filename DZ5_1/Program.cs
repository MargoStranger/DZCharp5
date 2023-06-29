//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.Write("Введите количество чисел: ");
int size = int.Parse(Console.ReadLine()!);
int[] Array = GetRead(size);

Console.Write($"В массиве {String.Join(", ", Array)} положительных чисел = {GetPositive(Array, size)}");


//метод поиска положительного элемента
int GetPositive(int[] array, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        count += array[i] > 0 ? 1 : 0; 
    }
    return count;
}

//метод ввода массива 
int[] GetRead(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}