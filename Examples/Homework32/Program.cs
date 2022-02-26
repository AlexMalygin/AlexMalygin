//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void PrintArray(int [] array)  // Печать массива
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($" {array[i]}");
    }
Console.WriteLine();
}
int [] FillArray(int number)  // Заполняем массив 
{
    int[] array = new int[number];
    for(int i=0;i<number;i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}
int number = 8;
Console.WriteLine("массив Из восьми чисел заполненный нулями и единицами");
var array = FillArray(number);   
PrintArray(array);



