using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IBank//contract
    {
        
        void Credit();
        void Debit();
        void CheckBalance();
        int IntialBalance { get; set; }//auto implement properties
        
        
    }
    interface IRBI
    {
        void IntrestRate();
    }
    public class SBI:IBank,IRBI
    {
        
        public void Credit()
             {
            Console.WriteLine("Credit method from SBI");
        }

        public void Debit()
        {
            Console.WriteLine("Debit method from SBI");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Check balance method from SBI");
        }

        private int _intialBalance;
        public int IntialBalance
        {
            get
            {
                return _intialBalance;
            }
            set
            {
                if (value > 100)
                {
                     _intialBalance = value;
                }
                else
                {
                    Console.WriteLine("Initial balance must be greater than 1000");
                    _intialBalance = 100;
                }
            }
        }

        public void IntrestRate()
        {
            throw new NotImplementedException();
        }
    }
    class IDBI : IBank,IRBI
    {
        public void Credit()
        {
            Console.WriteLine("Credit method from IDBI");
        }
         public void Debit()
        {
            Console.WriteLine("Debit method from IDBI");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Check balance method from IDBI");
        }

        public int IntialBalance
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void IntrestRate()
            {
            throw new NotImplementedException();
        }
    }

    interface IFoo
    {
        void Print();
      
    }
    interface IFoo1
    {
        void Print();
    }

    class ImplemetFoo : IFoo, IFoo1
    {
        void IFoo.Print()//interfacename.methodname
        {
            Console.WriteLine("A call from IFoo print");
         }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //SBI s = new SBI();
            //s.Credit();
            //s.Debit();
            //s.CheckBalance();

            //IDBI i = new IDBI();
            //i.Credit();
            //i.CheckBalance();
            //i.Debit();

            //IBank obj = new SBI();// a object of my interface can create a instance of the class where it is implemented Credit() Debit() CheckBlance()
            //IRBI rbi = new SBI();//IntrestRate()

            IFoo f1 = new ImplemetFoo();
            f1.Print();

            IFoo1 f2 = new ImplemetFoo();
            f2.Print();
                    }
    }
}


   
