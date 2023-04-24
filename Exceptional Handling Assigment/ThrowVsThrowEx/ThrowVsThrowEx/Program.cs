using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowVsThrowEx
{
   
    class Program
    {
        public void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void Method2()
        {

            try
            {
                Method3();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void Method3()
        {

            try
            {
                int num = 0, num2 = 10;
                num = num2 / num;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            Program prg = new Program();

            try
            {
                prg.Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Output using Throw :- ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Throw will maintain entire Stack trace");
            }
            try
            {
                prg.Method4();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Output Using Throw Ex :-");
               // Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("method 5 stack trace missing ");
                Console.WriteLine("Throw ex will not maintain Stack trace");
            }
            Console.ReadKey();

        }
        public void Method4()
        {
            try
            {
                Method5();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Method5()
        {
            try
            {
                int temp = 0;
                temp = temp / temp;
            }
            catch (Exception ex)
            {
                throw ;
            }

        }
       
    }
}
