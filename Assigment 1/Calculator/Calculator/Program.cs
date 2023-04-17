using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        int sum(int num1, int num2);
        int sum(params int[] num);
        int sub(int num1, int num2);
        int sub(int[] num);
        int mul(int num1, int num2);
        int mul(params int[] num);
        int div(int num1, int num2);
        int div(params int[] num);


    }
    class Program : ICalculator
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int choice = 0;
            do
            {
                Console.WriteLine("Choose the opertaion \n 1 addition \n 2 substraction \n 3 multiplication \n 4 division \n 5 Exit");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter size ");
                int size = int.Parse(Console.ReadLine());
                int num1=0, num2=0;
                int [] num = new int[size];
                if (size == 2)
                {
                    Console.WriteLine("Enter two variable");
                    num1 = int.Parse(Console.ReadLine());
                    num2= int.Parse(Console.ReadLine());
                    
                }
                else
                {
                    Console.WriteLine("Enter " + size + " number");
                    for(int i = 0; i < size; i++)
                    {
                        num[i]= int.Parse(Console.ReadLine());
                    }
                }
                if (size<= 1) {
                    Console.WriteLine("Please enter valid size");
                    choice=5;
                }

                switch (choice)
                {
                    case 1:
                        if (size == 2)
                        {
                            Console.WriteLine(p.sum(num1, num2));
                            
                        }
                        else
                        {
                            Console.WriteLine(p.sum(num));
                        }

                        break;

                    case 2:
                        if (size == 2)
                        {
                            Console.WriteLine(p.sub(num1, num2));

                        }
                        else
                        {
                            Console.WriteLine(p.sub(num));
                        }
                        break;

                    case 3:
                        if (size == 2)
                        {
                            Console.WriteLine(p.mul(num1, num2));

                        }
                        else
                        {
                            Console.WriteLine(p.mul(num));
                        }
                        break;

                    case 4:
                        if (size == 2)
                        {
                            Console.WriteLine(p.div(num1, num2));

                        }
                        else
                        {
                            Console.WriteLine(p.div(num));
                        }

                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;

                }

            } while (choice != 5);
            Console.WriteLine("---------------Thank you------------------");
            Console.ReadKey();


        }

        public int div(int num1, int num2)
        {
            return num1 / num2;
        }

        public int div(params int[] num)
        {
            int temp = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                temp = temp / num[i];
            }
            return temp;
        }

        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int mul(params int[] num)
        {
            int temp = 1;
            for (int i = 0; i < num.Length; i++)
            {
                temp = temp * num[i];
            }
            return temp;
        }

        public int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int sub(int[] num)
        {
            int temp=num[0];
            for(int i = 1; i < num.Length; i++)
            {
                temp = temp - num[i];
            }
            return temp;
        }

        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int sum(params int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                temp = temp + num[i];
            }
            return temp;
        }
    }
}
