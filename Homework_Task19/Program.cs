//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число");
            string a = Convert.ToInt32(Console.ReadLine()).ToString();
            
              if(a[0] == a[4] || a[1] == a[3])
            {
                Console.WriteLine($"Число {a} палиндром");
            }
            else
            {
                Console.WriteLine($"Число {a} не палиндром");
            }  
        
            
        }
    }
}
