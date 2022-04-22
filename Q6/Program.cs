using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
        class Bus
        {
            public int? Load;
        
            public void PrintStatus()
            {
          
            if (Load.HasValue)
            {
                Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
            }
        }

    }
