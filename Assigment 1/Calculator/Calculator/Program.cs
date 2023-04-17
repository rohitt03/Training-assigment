using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        int sum(int a, int b);
        int sum(params int[] a);
        int sub(int a, int b);
        int mul(int a, int b);
        int mul(params int[] a);
        int div(int a, int b);

    }
    class Program:ICalculator
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.sum(1, 2));
            Console.WriteLine(p.sum(1, 2, 3));
            Console.WriteLine(p.sub(5,4));
            Console.WriteLine(p.mul(2, 3));
            Console.WriteLine(p.mul(2, 3, 4, 5));
            Console.WriteLine(p.div(6, 3));
            Console.ReadKey();

        }

        public int div(int a, int b)
        {
            return a / b;
        }

        public int mul(int a, int b)
        {
            return a * b;
        }

        public int mul(params int[] a)
        {
            int temp=1;
            for(int i = 0; i < a.Length; i++)
            {
                temp = temp * a[i];
            }
            return temp;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sum(params int[] a)
        {
            int temp=0;
            for(int i = 0; i < a.Length; i++)
            {
                temp = temp + a[i];
            }
            return temp;
        }
    }
}
