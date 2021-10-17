using System;

namespace Open_closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new PermanentEmp(1, "vishal");
            Console.WriteLine(e1.CalculateSalary(1000).ToString());
            employee e2 = new Contract(1, "vishal");
            Console.WriteLine(e2.CalculateSalary(1000).ToString());
        }
    }
    abstract class employee
    {
        public int id;
        public string name;
        public employee() { }
        public employee(int EMPNO, string EmployeeName)
        {
            this.id = EMPNO;
            this.name = EmployeeName;
        }
        public abstract double CalculateSalary( int salaru);
    }
    class PermanentEmp : employee
    {
        public PermanentEmp(int EMPNO, string EmployeeName)
        {
            id = EMPNO;
            name = EmployeeName;
        }
        
        public override double CalculateSalary( int salaru)
        {
            return salaru * 0.1;
        }
    }
    class Contract : employee
    {
        public Contract(int EMPNO, string EmployeeName)
        {
            id = EMPNO;
            name = EmployeeName;
        }
        public override double CalculateSalary(int salaru)
        {
            return salaru * 0.07;
        }
    }
}
