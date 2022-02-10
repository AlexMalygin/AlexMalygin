// Задача 12: Удалить вторую цифру трёхзначного числа.

int GetRandomNumber()
{
    int randomNumb = new Random().Next(100,1000);
    return randomNumb;
}
int number = GetRandomNumber();
Console.WriteLine($" Наше трёх значное число : {number}");

int DelSecondDigit(int number)
{
string valueStr = number.ToString();
Console.WriteLine($" Вторая цифра трёх значного числа: {valueStr[1]}"); 
Console.Write(" Удалим Вторую цифру трёх значного числа: "); 
Console.WriteLine($"{valueStr[0]}{valueStr[2]}");
return number;
}

int result = DelSecondDigit(number);
