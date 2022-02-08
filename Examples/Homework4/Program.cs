// Найти максимальное из трех чисел

int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int numberC = new Random().Next(1, 10);
Console.WriteLine(numberC);
int max = numberA;
if (max<numberB) max = numberB;
if (max<numberC) max = numberC;
Console.WriteLine("максимальное число: " + max);
