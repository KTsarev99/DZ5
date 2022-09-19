// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[5];
var number = new Random();
double max = 0;
double min = 100;
for (int i = 0; i < array.Length; i++)
{
    
    array[i] = number.NextDouble() * ((100) - (1)) + (1);
    Console.WriteLine("{0:0.000}",array[i]);
   

    if(array[i]>max)
    {
        max=array[i];
        
    }

    if(array[i]<min)
    {
       min = array[i] ;   
    }
}
Console.WriteLine("максимальне число");
Console.WriteLine("{0:0.000}",max);
Console.WriteLine("минимальное число");
Console.WriteLine("{0:0.000}",min);
Console.Write("разница =");
Console.Write("{0:0.000}",max-min);