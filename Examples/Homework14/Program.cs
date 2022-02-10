// Задача 14: Найти третью цифру числа или сообщить, что её нет.

Console.Write("введите число: ");

string strNumber = Console.ReadLine();

    if(int.TryParse(strNumber, out int intNumber))
    {
        string resultValue = intNumber.ToString();
    if (resultValue.Length >= 3)
    
            Console.WriteLine($"третья цифра числа: {resultValue[2]}"); 
        else
     Console.WriteLine("число не трёхзначное");
    }        
    else 

    Console.WriteLine("Вилли не число");
    

