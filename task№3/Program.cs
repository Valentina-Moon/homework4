// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] arr = { 111, 222, 333, 444, 555, 666, 777, 888, 999 };
int evennubers(int[] arr)
{
    int Length = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            Length++;

    return Length;
}
int oodnumbers(int[] arr)
{
    int Length = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 > 0)
            Length++;

    return Length;
}
{
    Console.WriteLine($"количество четных чисел : {evennubers(arr)}");
    Console.WriteLine($"количество нечетных чисел: {oodnumbers(arr)}");

}