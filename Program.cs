using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();
            Console.WriteLine(o4.getNetSalary());
            //Employee o1 = new Employee();
            //Employee o2 = new Employee();
            //Employee o3 = new Employee();
            Console.WriteLine(o4.PempNo);
            Console.WriteLine(o1.PempNo);
            Console.WriteLine(o2.PempNo);
            Console.WriteLine(o3.PempNo);

            Console.WriteLine(o3.PempNo);
            Console.WriteLine(o2.PempNo);
            Console.WriteLine(o1.PempNo);
            Console.WriteLine(o4.PempNo);

        }
    }
    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private short deptNo;
        public static int auto;

        static Employee()
        {
            int auto = 0;
        }
        public Employee()
        {
            Console.WriteLine("no parameter ctr called");
            auto++;
            this.empNo = auto;

        }
        public Employee(string name)
        {
            auto++;
            this.empNo = auto;

            this.name = name;
        }
        public Employee(string name, decimal basic)
        {
            auto++;
            this.empNo = auto;

            this.name = name;
            this.basic = basic;

        }
        public Employee(string name, decimal basic, short depNo)
        {
            auto++;
            this.empNo = auto;

            this.name = name;
            this.basic = basic;
            this.deptNo = depNo;
        }

        #region property
        public string Pname
        {
            set
            {

                if (value.Length != 0)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return name;
            }
        }

        public int PempNo
        {
            get
            {
                return empNo;
            }
        }

        public decimal Pbasic
        {
            set
            {
                if (value >= 25000 && value <= 100000)
                {
                    this.basic = value;

                }
                else
                {
                    Console.WriteLine("enter basic between 25000 to 35000");
                }
            }
            get
            {
                return basic;
            }
        }

        public short PdeptNo
        {
            set
            {
                if (value > 0)
                {
                    this.deptNo = value;
                }
                else
                {
                    Console.WriteLine("deptno must be above 0");
                }
            }
            get
            {
                return deptNo;
            }
        }

        #endregion

        public decimal getNetSalary()
        {
            decimal ta = 3000;
            decimal da = 2000;
            decimal hra = 3000;
            return this.Pbasic + ta + da + hra;
        }
    }
}