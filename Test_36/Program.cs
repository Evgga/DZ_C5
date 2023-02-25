// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = randomArray(4);

int[] randomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 100);
    }
    return array;
}

int sumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
Console.WriteLine($"[{string.Join(",", array)}] -> {sumOdd(array)}");
