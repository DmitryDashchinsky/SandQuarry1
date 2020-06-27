using System;

namespace SandQuarry
{   
   class Program
    {  
        static void Main(string[] args)
        {
            double accuracy = 1E-14;
            int t, N, a;
            Console.WriteLine("1-Truck; 2-Train; 3-Conveyor;\nThe program perceives only the number of hours.\n Iput data:\n Type of machine: ");
            string typy = Console.ReadLine();
            Console.WriteLine("\nNumber of hours:  ");
            string T = Console.ReadLine();
            Console.WriteLine("\nParameter N: ");
            string n = Console.ReadLine();
            
            a = Convert.ToInt32(typy);
            N = Convert.ToInt32(n);
            t = Convert.ToInt32(T);

            string res="0";

            if (a<1-accuracy)
            {
                Console.WriteLine("\nNo device type selected.");
            }
            else if(a>3+accuracy)
            {
                Console.WriteLine("\nNo device type selected.\n");
            }

            Engine e = new Engine(N, t);
            Truck truck = new Truck(N, t, res);
            Train train = new Train(N, t, res);
            Conveyor c = new Conveyor(N, t, res);
            if(Math.Abs(a-1)<accuracy)
            {
                truck.Display(t);
            }
            else if(Math.Abs(a - 2) < accuracy)
            {
                train.Display(t);
            }
            else
            {
                c.Display(t);
            }
            Console.ReadKey();
        } 
   }
}
