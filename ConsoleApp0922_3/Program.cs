using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_3
{
    public class Prime
    {
        public void Prime_Formula(int max)
        {
            int min = 2;
            int count = max;
            int[] num = new int[max];
            for (int i = min; i < max; i++)
            {
                num[i-2] = ++min;
                for (int j = min; j < i; j++)
                {
                    if (num[j-2] != i && i % num[j-2] == 0)
                    {
                        num[i-1] = num[i];
                        //i--;
                        count--;
                    }
                }
                Console.Write(num[i] + "  ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 : ");
            int.TryParse(Console.ReadLine(), out int max_value);

            Prime prime = new Prime();
            prime.Prime_Formula(max_value);
        }
    }
}
