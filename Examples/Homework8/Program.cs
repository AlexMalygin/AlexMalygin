// Показать четные числа от 1 до N
// подскажите пожалуйста как организовать ввод с целого числа с терминала
//Console.Write("введите количество чисел N: ");
//int N = Console.ReadLine();
int N=10;
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

