//Написать программу замену элементов массива на противоположные
int Input(string message)   // ВВодим число 
{
    Console.Write(message);
    string numb=Console.ReadLine();
    return int.Parse(numb);
}
void PrintArray(int [] array)  // Печать массива
{
    for(int i=0;i<array.Length;i++)
    {   
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}
void PrintArrayMinus(int [] array)  // Печать Противоположных чисел массива
{
    for(int i=0;i<array.Length;i++)
    {   array[i]=array[i]*-1;    // Делаем числа отрицательными
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}
int [] FillArray(int number)  // Заполняем массив Случайными числами
{
    int[] array = new int[number];
    Random rand = new Random();
    for(int i=0;i<number;i++)
    {
        array[i] = rand.Next(1,11);
    }
    return array;
}
int n = Input("введите Количество элементов массива: ");
Console.WriteLine("массив чисел");
var array = FillArray(n);   
PrintArray(array);
Console.WriteLine("противоположный массив чисел");
PrintArrayMinus(array);
