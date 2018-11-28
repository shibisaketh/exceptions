using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
  class Program
    {  static int  s = 0;

       static  void fun1()
        {
            try
            {
                Console.WriteLine("Fun 1 started...");
                if (s == 0)
                    throw new Exception("Exception occured in fun 1");
                Console.WriteLine("Fun 1 end.");//will not execute this line as it throw exception
            }
            catch(Exception e)
            {
                Console.WriteLine("catch Fun 1." + e.Message);
                throw;//re throw
            }
        }

        static void fun2()
        {
            //try
            {
                Console.WriteLine("Fun 2 started...");
                fun1();
                Console.WriteLine("Fun 2 end.");//this will not execute as the exception occured
            }
            //catch(Exception e)//as the exception is not handled here it will go to main
            //{
            //    Console.WriteLine("catch Fun 1." + e.Message);
            //    throw;
            //}
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("In Main");
                fun2();
            }
            catch (Exception e)//if not handled the exception will crash
            {
                Console.WriteLine("catch in main." + e.Message);
            }
        }
    }
}
