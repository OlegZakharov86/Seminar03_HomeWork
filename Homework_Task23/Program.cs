namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <=a; i++)
            {
                PrintCube(i);
            }
        }
        public static void PrintCube(int n)
        {
            Console.WriteLine(n * n * n);
        }
    }
}
