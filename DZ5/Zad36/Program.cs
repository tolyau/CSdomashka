// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int Sum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}
int [] arr = getRandomArray(4,0,20);
System.Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(Sum(arr));