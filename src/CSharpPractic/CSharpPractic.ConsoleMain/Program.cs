using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractic.ConsoleMain
{

    

    public class Program
    {

        
        static void Main(string[] args)
        {
             Task.Run(() => 
             {
                 for (int i = 0; i < 1000; i+=2)
                 {
                     Console.WriteLine("current val : " + i.ToString()  );
                     Thread.Sleep(20);
                 }
             });

            for (int i = 1; i < 1000; i+=2)
            {
                Console.WriteLine("Main val : " + i.ToString());
                Thread.Sleep(20);
            }


            Console.Read(); 
        }
    }
}
