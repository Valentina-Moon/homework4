//Найти произведение парных чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] array = new int[10]; 
Random random = new Random(); 
for (int i = 0; i < array.Length; i++) 
{ 
 array[i] = random.Next() % array.Length; 
 Console.Write($"{array[i]} "); 
} 
Console.Write("\n"); 
for(int i = 0; i <= array.Length/2; i++) 
{ 
 int result = array[i] * array[array.Length - 1 - i]; 
  Console.WriteLine($"произведение парных чисел: {result} "); 
}

