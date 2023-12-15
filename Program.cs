// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
System.Console.WriteLine("Введите числа массива");
array[i] = Convert.ToInt32(Console.ReadLine());    
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    count = count + 1;
}
System.Console.WriteLine($"Количество четных чисел массива = {count}");