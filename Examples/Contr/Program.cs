string[] arrays = {"Russia", "Denmark", "Kazan", "123","56", "vs"};
string[] newarray = new string[10];

string[] PrintArray(string[] array)  // Функция печати массива
{
    for (int i = 0; i<array.Length;i++)
    {
            Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
  return array;  
}

string[] ChangeArray(string[] array,string[] array2)  // Метод вычисляющий длину элемента Массива
{
   
    for (int i = 0; i<array.Length;i++)
    {
        if (array[i].Length <= 3)        // Если длина элемента меньше равна трём
        {
         array2[i] = array[i];           // Записываем этот элемент в новый массив
        }
    }
return array2;    
}

Console.WriteLine("Исходный массив:");    
PrintArray(arrays);
Console.WriteLine("Новый массив с длиной элементов меньше или равной 3:");
PrintArray(ChangeArray(arrays, newarray));

