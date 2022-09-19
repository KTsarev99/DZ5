// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int count1 =0;
int[] array = new int[10];
Random number = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = number.Next(100,1000);
if(array[i] %2==0)
count1++;
Console.WriteLine(array[i]); 
}
Console.WriteLine(count1);