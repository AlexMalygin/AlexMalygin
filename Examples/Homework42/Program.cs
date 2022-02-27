// Определить сколько чисел больше 0 введено с клавиатуры

int Input(string message)   // ВВодим число
{
    Console.Write(message);
    string numb=Console.ReadLine();
    return int.Parse(numb);
}

void VvodBolsheNull(int numb)  
{
    int count = 0;
    for (int i = 0; i < numb; i++)
     {
         Console.Write($"Введите число {i + 1}: ");
         int x = int.Parse(Console.ReadLine());        // Считываем числа С клавиатуры
         if (x > 0)
             count++;
     }
     Console.WriteLine($"чисел больше нуля: {count}");

 }

 int n = Input("Введите количество чисел: ");
 VvodBolsheNull(n); 
