////В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10]; 
Random random = new Random(); 
for (int i = 0; i < array.Length; i++) 
{ 
 array[i] = (double)random.NextDouble()* array.Length; 
 Console.Write($"{array[i]}\t"); 
} 
Console.Write("\n"); 
double min = array.Length; 
double max = 0; 
foreach (var num in array) 
{ 
 if (num < min) 
 min = num; 
 if (num > max) 
 max = num; 
} 
Console.WriteLine($"Максимальное значение: {max}"); 
Console.WriteLine($"Минимальное значение: {min}"); 
Console.WriteLine($"Разница между максимальным и минимальным элементами: {max - min}");
