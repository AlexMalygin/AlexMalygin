// В матрице чисел найти сумму элементов главной диагонали.

int[,] array =new int [5,5];
Random rand = new Random();
 void FillArray()  // Заполнение двухмерного массива
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = rand.Next(1,10);
         }
     }
 }

void PrintArray()  // Печать двухмерного массива
{
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j=0 ;j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
    
}
void MatrixDiag() // Если индексы  равны то суммируем
{
    int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            if (i==j)
            sum+=array[i,j];
         }
     }
     Console.WriteLine($"сумма элементов главной диагонали: {sum} ");
}


FillArray();
PrintArray();
Console.WriteLine();
MatrixDiag();

