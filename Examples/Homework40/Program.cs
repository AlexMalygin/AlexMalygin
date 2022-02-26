//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

double[] array = new double[] { 2.2, 4.55, 5.3, 4.21, 5.4, 3.6, 9.1 };
void PrintArray(double [] array)  // Печать массива
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($" {array[i]}");
    }
Console.WriteLine();
}
void MinMax(double [] array) // Вычисляем максимальный и минимальный элемент
{
    double max = array[0];
    double min = array[0];

 for (int i = 1; i < array.Length; i++)
 {
     if (max <= array[i])
         max = array[i];
     else if (min >= array[i])
         min = array[i];
 }
  
 Console.WriteLine($"Максимальное значение = {max}, минимальное  ={min} ");
 Console.WriteLine($"Разница между максимальным и минимальным Значениеm равна {max - min}");
}
Console.WriteLine("массив вещественных чисел:");
PrintArray(array);
MinMax(array);


