//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

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
void PrintArrayChetNechet(int [] array)  // Печать количество нечетных\четных чисел
{
    int chet = 0;
    int nechet = 0;
    for(int i=0;i<array.Length;i++)
    {   
       if (array[i]%2==0)
       chet++;
       else 
       nechet++;  
    }
Console.WriteLine($"количество четных чисел {chet} ");
Console.WriteLine($"количество Нечетных чисел {nechet} ");
}
int [] FillArray(int number)  // Заполняем массив положительными трёхзначными Случайными  числами
{
    int[] array = new int[number];
    Random rand = new Random();
    for(int i=0;i<number;i++)
    {
        array[i] = rand.Next(100,999);
    }
    return array;
}
int n = Input("введите Количество элементов массива: ");
Console.WriteLine("массив чисел");
var array = FillArray(n);   
PrintArray(array);
PrintArrayChetNechet(array);
