//Задача 28: Подсчитать сумму цифр в числе
int Input(string message)   // ВВодим число 
{
    Console.Write(message);
    string numb=Console.ReadLine();
    return int.Parse(numb);
}
int sum = 0;
int a = Input("введите Целое число A: ");
int result = a;
while(result != 0) 
{
    sum = sum + result%10; // Вычисляем последнюю цифру числа И складываем её
    result = result/10;    // Отбрасываем  последнюю цифру числа
}

Console.WriteLine($"сумма чисел числа A {a} = {sum}");
