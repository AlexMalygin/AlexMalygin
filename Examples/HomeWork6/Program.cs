
// Выяснить является ли число чётным

int numberA = new Random().Next(1, 10);
Console.WriteLine("является ли четным числом " + numberA);
if (numberA%2 == 0)
{
Console.WriteLine("четное число: " + numberA);
}
else {
Console.WriteLine("нечетное число: " + numberA);
}

