//Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
//(Решить можно, если хотите потренироваться)
//(Следующее число складывается из двух предыдущих)

//Если N = 5 -> 0 1 1 2 3

//Если N = 3 -> 0 1 1

//Если N = 7 -> 0 1 1 2 3 5 8

//2i+i-1


Console.Write("Введите количество чисел: ");
int size = int.Parse(Console.ReadLine()!);

Console.Write($"{size} чисел Фибоначи {String.Join(", ", GetFibonachi(size))}");


//Метод  числа Фибоначи без рекурсии
int[] GetFibonachi(int N)
{
    int[] array = new int[N];
    if (N==0) array[0] = 0; 
    else
    {
        array[0] = 0;
        array[1] = 1;
    }
    for (int i = 2; i < N; i++)
    {
        array[i]=array[i-1]+array[i-2];
    }
    return array;
}