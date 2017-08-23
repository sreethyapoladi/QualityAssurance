using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding_overloading
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public string Add(string s, string s1)
        {
            return s1 + s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int sum = c.Add(10, 11, 15);
            string fullname= c.Add("A","N");
            Console.WriteLine("sum is {0}", sum);
              
        }
    }
}
