// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("введите количество элементы в массиве:");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < size; i++)
    array[i] = new Random().Next(0, 10);

Console.WriteLine("массив:");
for (int i = 0; i < size; i++)
Console.WriteLine($"{array[i]}");

int Sum = 0;
for (int i = 1; i < size; i = i + 2)
    Sum = Sum + array[i];
Console.WriteLine();
Console.WriteLine($" сумма чисел одномерного массива стоящих на нечетной позиции {Sum}");



