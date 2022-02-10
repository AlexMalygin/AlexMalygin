// Задача 10: Показать вторую цифру трёхзначного числа.
// Задача 12: Удалить вторую цифру трёхзначного числа.
// Задача 14: Найти третью цифру числа или сообщить, что её нет.
// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

int GetRandomNumber()
{
    int randomNumb = new Random().Next(100,1000);
    return randomNumb;
}

int SecondDigit(int number)
{
    number = number / 10;
    return number % 10;
}
int number = GetRandomNumber();
Console.WriteLine($" Наше трёх значное число: {number}");
int secondNumber = SecondDigit(number);
Console.WriteLine($" Вторая цифра трёх значного числа: {secondNumber}");
// Решение с помощью переменной вида String
Console.WriteLine("Решение с помощью переменной вида String ");
Console.WriteLine($" Наше трёх значное число : {number}");

string valueStr = number.ToString();
Console.WriteLine($" Вторая цифра трёх значного числа: {valueStr[1]}"); 




