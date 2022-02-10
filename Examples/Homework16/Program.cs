// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

int GetRandomNumber()
{
    int randomNumb = new Random().Next(1,8); // День недели от одного до семи, если 
                                                //Если ввести от 1 до 31 то сможем вычислить выходные дни месяца
    return randomNumb;
}

bool VihodnoiDen(int number)
{
    return number % 6 == 0 || number % 7 == 0;     // Проверяем делится на шестой или седьмой день Без остатка
}
int number = GetRandomNumber();
Console.WriteLine($" День недели: {number}");

if (VihodnoiDen(number)) 
        Console.WriteLine($"день недели {number} Выходной");
    else
        Console.WriteLine($"день недели {number} Рабочий ");
