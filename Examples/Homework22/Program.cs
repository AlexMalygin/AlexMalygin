// Задача 22: Найти расстояние между точками в пространстве 2D/3D

int Input(string message)   // ВВодим число 
{
    Console.Write(message);
    string numb=Console.ReadLine();
    return int.Parse(numb);
}
double Rasst2d(int x1,int y1,int x2, int y2) // Расстояние между точками в 2d
{
    int distance = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
    return Math.Sqrt(distance);
}
double Rasst3d(int x1,int y1,int x2, int y2,int z1, int z2) // Расстояние между точками в 3D
{
    int distance = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)*(z2-z1)*(z2-z1);
    return Math.Sqrt(distance);
}

int x1 = Input("введите координаты точки x1: ");
int y1 = Input("введите координаты точки y1: ");
int x2 = Input("введите координаты точки x2: ");
int y2 = Input("введите координаты точки y2: ");
double dist2 = Rasst2d(x1,y1,x2,y2);                    
Console.WriteLine($"расстояние от точки один до точки два в 2D: {dist2}");
int z1 = Input("введите координаты точки z1: ");
int z2 = Input("введите координаты точки z2: ");
double dist3 = Rasst3d(x1,y1,x2,y2,z1,z2);
Console.WriteLine($"расстояние от точки один до точки два в 3D: {dist3}");
