// Найти точку пересечения двух прямых заданных 
// уравнением y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы

int Input(string message)   // ВВодим число
{
    Console.Write(message);
    string numb=Console.ReadLine();
    return int.Parse(numb);
}
void CrossFunc(int b1, int k1, int b2, int k2)
 {
 var x = (b2 - b1) / (k1 - k2);          // Решение уравнения для икс
 var y = k1 * x + b1;                    // Решение уравнения игрек   
 Console.WriteLine($"Точка пересечения двух прямых y = k1 * x + b1, y = k2 * x + b2: ({x},{y})");
 }

 int b1 = Input("Введите Число b1: ");
 int k1 = Input("Введите Число k1: ");
 int b2 = Input("Введите Число b2: ");
 int k2 = Input("Введите Число k2: ");
 CrossFunc (b1, k1, b2, k2);

