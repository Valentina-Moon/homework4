//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int size = 123;
int [] Array = new int [size];
for (int i = 0; i < size; i++)
Array[i] = new Random().Next(0,100);
Console.WriteLine("МАССИВ:");
for (int i = 0; i < size; i++)
Console.WriteLine($"{Array[i]}");

int count = 0;

for (int i = 0; i < size; i++)
{
    if (Array[i] >= 10 && Array[i]<=99)
   count++;
}

Console.WriteLine($" количество элементов из отрезка [10,99] равна:{count}");


    

