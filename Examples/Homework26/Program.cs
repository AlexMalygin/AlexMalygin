//Задача 26: Возведите число А в натуральную степень B используя цикл
//Задача 28: Подсчитать сумму цифр в числе
//Задача 30: Показать кубы чисел, заканчивающихся на четную цифру
//Задача 32: Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int Input(string message)   // ВВодим число 
{
    Console.Write(message);
    string numb=Console.ReadLine();
    return int.Parse(numb);
}
int Stepen(int a, int b)   // Считаем степень в цикле
{   
    int step = a;
    for(int i = 1; i< b; i++)
    {
        step *= a;
    }
    return step;
}

int a = Input("введите число A больше одного: ");
int b = Input("Введите натуральную степень в которой нужно возвести число A : ");
int result = Stepen(a,b);
Console.WriteLine($"число {a} в степени {b} = {result}");


