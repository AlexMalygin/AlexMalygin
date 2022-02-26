//Показать кубы чисел, заканчивающихся на четную цифру
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
        Console.WriteLine($"{array[i]}");
    }
Console.WriteLine();
}
void PrintArrayChet(int [] array)  // Печать Четных чисел массива
{
    for(int i=0;i<array.Length;i++)
    {   if(array[i] % 2 == 0)   // Проверяем четные или нет числa
        Console.WriteLine($"{array[i]}");
    }
Console.WriteLine();
}
int [] FillArray(int number)  // Заполняем массив Кубами чисел 
{
    int[] array = new int[number];
    for(int i=0;i<number;i++)
    {
        array[i] = (i+1)*(i+1)*(i+1);
    }
    return array;
}
int n = Input("введите число N больше одного: ");
Console.WriteLine("Кубы чисел от одного до N");
var array = FillArray(n);   
PrintArray(array);
Console.WriteLine("чётные kубы чисел от одного до N");
PrintArrayChet(array);
