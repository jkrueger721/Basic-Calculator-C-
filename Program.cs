using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("x=");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;

                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("y=");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum y+x;
                Console.WriteLine("Result = {0}",sum);


            }
            while (true);

        }
    }
}
    
