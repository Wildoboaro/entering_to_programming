class Program  
{  
    static void Main()  
    {
int count = 0;
int distance;
int ff_speed;
int sf_speed;
int d_speed;
int f_dir = 1;
int time;
Console.Write("Введите начальное расстояние меэду доузьями(в метрах):");
distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость первого друга(в км/ч):");
ff_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость втооого друга(в км/ч):");
sf_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введитн скорость собаки(в км/ч):");
d_speed = Convert.ToInt32(Console.ReadLine());


while (distance > 10)
{
    if (f_dir == 1)
    {
        time = distance/(ff_speed + d_speed);
 //       distance = distance - (ff_speed + sf_speed) * time;
    }
    else 
    {   
   //     if (f_dit == -1)
   //     {
        time = distance / (sf_speed + d_speed);
   //         distance = distance - (ff_speed + sf_speed) * time;
   //     }
    }
    distance = distance - (ff_speed + sf_speed) * time;
 count = count + 1;
 f_dir = f_dir * (-1);
}
Console.WriteLine($"Собака пробежит {count} раз.");

}
}