using System;

namespace InterfaceAssessment
{
    public interface IEmployee
    {
        //Interface allows only auto properties
        int empId { get; set; }
        string empName { set;  get; }
        double empSalary { set; get; }

        // By default interface methods are abstract and public
        void EmployeeExperience(int yearsOfExperience);
        void DisplayEmployeeInfo();
    }

    //Implementaaion of IEmployee interface
    public class Developer : IEmployee
    {
        public int empId { get; set; }
        public string empName { set; get; }
        public double empSalary { set; get; }

        //Display Employee Experience
        public void EmployeeExperience(int yearsOfExperience)
        {
            Console.WriteLine("Experience : " + yearsOfExperience);
        }

        //Display Employee Information
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Developer Id : " + empId + " Name : " + empName + " Salary : " + empSalary);
        }
    }

    //Implementaaion of IEmployee interface
    public class Tester : IEmployee
    {
        public int empId { get; set; }
        public string empName { set; get; }
        public double empSalary { set; get; }

        //Display Employee Experience
        public void EmployeeExperience(int yearsOfExperience)
        {
            Console.WriteLine("Experience : " + yearsOfExperience);
        }

        //Display Employee Information
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Tester Id : " + empId + " Name : " + empName + " Salary : " + empSalary);
        }
    }

    public class InterfaceMain
    {
        public static void Main(string[] args)
        {
            //Dynamic polymorphism technique usage, dynamically it gets the object at runtime
            // and it access the methods/properties only from interface which are implemented
            IEmployee employee = new Developer();
            employee.empId = 1;
            employee.empName = "Aneesh";
            employee.empSalary = 75000.0;    

            //Display Developer information
            employee.DisplayEmployeeInfo();
            employee.EmployeeExperience(5);

            //Assigning Tester obj
            employee = new Tester();
            employee.empId = 2;
            employee.empName = "Mahipal";
            employee.empSalary = 70000.0;

            //Display Tester Information
            employee.DisplayEmployeeInfo();
            employee.EmployeeExperience(4);
        }
    }
}