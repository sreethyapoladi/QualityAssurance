using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
     class Employee
    {
        private int _empid;

        public int Empid
        {
            get 
            {
                return _empid; 
            }
            set 
            {
                if (value > 0)
                {
                    _empid = value;
                }
                else
                {
                    Console.WriteLine("Please enter positive values only otherwise empid will be 0");
                    _empid = 0;
                }
                
            }
             }
        private string _empname;

        public string Empname
        {
            get 
            { 
                return _empname; 
            }
            set 
            {
                if (value != "")
                {
                    _empname = value;
                }
                else
                {
                    Console.WriteLine("Please enter a name");
                    _empname = "default";
                }
            }
        }
        private int _salary;
         

        public int Salary
        {
            get 
            {
                return _salary; 
            }
            set 
            {
                if (value > 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Please enter positive value for salary otherwise salary will be 0");
                    _salary = 0;
                }
            }
        }
        //private int _age;

        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
         //}
        private int _bonus = 10;

        public int Bonus
        {
           // get { return _bonus; }
             set { _bonus = value; }
        }
        //private int _bonus = 10;
        //public int Bonus(int val)
        //{
        //    _bonus = val;
        //    return _bonus;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Please enter empid");
            emp.Empid = int.Parse(Console.ReadLine()); //int bonus = 11;
            emp.Bonus = 11;
            //Console.WriteLine("Please enter name");
            //emp.EmpName = Console.ReadLine();
            //Console.WriteLine("Please enter salary");
            //emp.salary = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter age");
            //emp.Age = int.Parse(Console.ReadLine());
           // Console.WriteLine("EmpId={0}\nEmpName={1}\nSalary={2}\nAge={3}", emp.Empid, emp.EmpName, emp.salary, emp.Age);
            Console.WriteLine("EmpId={0}", emp.Bonus);

        }
    }
}
    