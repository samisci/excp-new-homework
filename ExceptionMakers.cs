using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class ExceptionMakers
    {
        public int GetNumber()
        {
            if (int.TryParse(Console.ReadLine(), out int N)) return N;
            throw new HackerUFormatException("BAD FORMAT");
        }

        public int[] GetNumbers()
        {
            int[] numbers = new int[4];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("<" + i + ">");
                if (i == numbers.Length)
                {
                    Console.ReadLine();
                    throw new HackerUIndexOutOfRangeException("RANGE VIOLATION");
                }
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

        public void DivideByZero()
        {
            int x = 0;
            if (x == 0) throw new HackerUDivideByZeroException("Divided by zero err");
            x = 10 / x;
        }
    }
}
