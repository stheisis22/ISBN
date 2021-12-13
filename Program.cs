using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. ISBN 10");
            Console.WriteLine("2. ISBN 13");
            int opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case (1):
                    Console.WriteLine("Validacion formato 10;");

                    int ISBN10;
                    int[] digit = new int[10];

                    for (int i = 0; i < 10; i++)
                    {
                        digit[i] = int.Parse(Console.ReadLine());
                        if(digit[i]>9 || digit[i]<0) 
                        {
                            Console.WriteLine("Valor invalido");
                        }
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(digit[j]);
                    }

                    ISBN10 = ((digit[0] * 10) + (digit[1] * 9) + (digit[2] * 8) + (digit[3] * 7) + (digit[4] * 6) + (digit[5] * 5) + (digit[6] * 4) + (digit[7] * 3) + (digit[8] * 2) + (digit[9] * 1) %11);

                    if (ISBN10 !=0)
                    {
                        Console.WriteLine("ISBN invalidado");
                    }
                    else if (ISBN10 == 0)
                    {
                        Console.WriteLine("ISBN valido");
                    }
                    Console.ReadKey();
                    break;

                case (2):
                    Console.WriteLine("Validacion formato 13;");
                    int ISBN13;
                    int[] digit13 = new int[13];

                    for (int i = 0; i < 13; i++)
                    {
                        digit13[i] = int.Parse(Console.ReadLine());
                        if (digit13[i] >9 || digit13[i]<0)
                        {
                            Console.WriteLine("Valor invalidado");
                        }
                    }
                    for (int j = 0; j < 13; j++)
                    {
                        Console.WriteLine(digit13[j]);
                    }

                    ISBN13 = ((digit13[0] * 1) + (digit13[1] * 3) + (digit13[2] * 1) + (digit13[3] * 3) + (digit13[4] * 1) + (digit13[5] * 3) + (digit13[6] * 1) + (digit13[7] * 3) + (digit13[8] * 1) + (digit13[9] * 3) + (digit13[10] * 1) + (digit13[11] * 3) + (digit13[12] * 1) %10);

                    if (ISBN13 !=0)
                    {
                        Console.WriteLine("ISBN invalidado");
                    }
                    else if (ISBN13 ==0)
                    {
                        Console.WriteLine("ISBN valido");
                    }
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}
