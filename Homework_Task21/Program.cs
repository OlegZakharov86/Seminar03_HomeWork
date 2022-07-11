//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

//формула для нахождения расстояния между двумя точками в 3D пространстве: AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки Xa, Ya, Za");
            int Xa = Convert.ToInt32(Console.ReadLine());
            int Ya = Convert.ToInt32(Console.ReadLine());
            int Za = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите координаты второй точки Xb, Yb, Zb");
            int Xb = Convert.ToInt32(Console.ReadLine()); 
            int Yb = Convert.ToInt32(Console.ReadLine());
            int Zb = Convert.ToInt32(Console.ReadLine());

            int len = (Xb-Xa)*(Xb-Xa) + (Yb-Ya)*(Yb-Ya) + (Zb-Za)*(Zb-Za); 
            double dist = Math.Sqrt(len);
            Console.WriteLine(dist);
        }
        
    }
}
