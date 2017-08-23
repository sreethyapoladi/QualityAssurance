using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class car
    {
         public int price;
        public string modelname;
        public string company;
        public int yom;
        public void start()
        {
            Console.WriteLine("car is started");
        }
        public void stop()
        {
            Console.WriteLine("car stopped");
        }
        public car()
        {
            Console.WriteLine("a call from derived class deafault constructor");
        }
        class Maruthi : car
        {
            public void accelerate()
            {
                Console.WriteLine("this car accelerates at 25kmph");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Maruthi ob = new Maruthi();
                ob.start();
                ob.accelerate();
                ob.stop();

            }
        }
    }
}
