// Показать четные числа от 1 до N
Console.Write("введите количество чисел N: ");
string? Nstr = Console.ReadLine();
int N = int.Parse(Nstr);
int I = 0;
while (I < N)
{
    int numberA = new Random().Next(1, N);
    if (numberA%2 == 0)
    {
        Console.WriteLine(" четные числа: " + numberA);
    }
    I++;
}

