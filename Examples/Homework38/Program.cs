//Найти сумму чисел одномерного массива стоящих на нечетной позиции

int Input(string message)   // ВВодим число Элементов массива
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
void PrintArraySumNechet(int [] array)  // Печать сумму чисел одномерного массива стоящих на нечетной позиции
{
    int sum = 0;
    for(int i=0;i<array.Length;i=i+2)
    {   
       sum =sum + array[i];
    }
Console.WriteLine($"cуммa чисел одномерного массива стоящих на нечетной позиции: {sum} ");
}
int [] FillArray(int number)  // Заполняем массив Случайными  числами
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
PrintArraySumNechet(array);
