//  В двумерном массиве n×k заменить четные элементы на противоположные.
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
void ChangeArray()  // Замена четных элементов массива на противоположной
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if(array[i,j] %2==0)
             array[i, j] = array[i,j]*-1 ;
         }
     }
 }
FillArray();
PrintArray();
ChangeArray();
Console.WriteLine();
PrintArray();
