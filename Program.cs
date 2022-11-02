using System;
using System.Collections.Generic;

namespace Lab_8___Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objects
            Employee Emp1 = new Employee() { Id = 101, Name = "Anas", Gender = "Male", Salary = 20000 };
            Employee Emp2 = new Employee() { Id = 102, Name = "Hanna", Gender = "Female", Salary = 30000 };
            Employee Emp3 = new Employee() { Id = 103, Name = "Tobias", Gender = "Male", Salary = 40000 };
            Employee Emp4 = new Employee() { Id = 104, Name = "Sara", Gender = "Female", Salary = 40000 };
            Employee Emp5 = new Employee() { Id = 105, Name = "Anna", Gender = "Female", Salary = 50000 };

            // Stack
            Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(Emp1);
            EmpStack.Push(Emp2);
            EmpStack.Push(Emp3);
            EmpStack.Push(Emp4);
            EmpStack.Push(Emp5);

            // Loops through and Types out the objects
            foreach (Employee Emp in EmpStack)
            {
                Console.WriteLine($"{Emp.Id} - {Emp.Name} - {Emp.Gender} - {Emp.Salary}");
                Console.WriteLine("Items left in the Stack = " + EmpStack.Count);
            }
            
            Console.WriteLine("-----------------------------------------------------------");

            // Count down the objects
            while (EmpStack.Count > 0)
            {
                Employee Em = EmpStack.Pop();
                Console.WriteLine($"{Em.Id} - {Em.Name} - {Em.Gender} - {Em.Salary}");
                Console.WriteLine("Items left in the Stack = " + EmpStack.Count);
            }
            EmpStack.Push(Emp1);
            EmpStack.Push(Emp2);
            EmpStack.Push(Emp3);
            EmpStack.Push(Emp4);
            EmpStack.Push(Emp5);

            Console.WriteLine("-----------------------------------------------------------");

            // Peeks 2 objects
            Employee Emplo = EmpStack.Peek();                                  
            Console.WriteLine($"{Emplo.Id} - {Emplo.Name} - {Emplo.Gender} - {Emplo.Salary}");
            Console.WriteLine("Items left in the Stack = " + EmpStack.Count);

            Employee Employ = EmpStack.Peek();
            Console.WriteLine($"{Employ.Id} - {Employ.Name} - {Employ.Gender} - {Employ.Salary}");
            Console.WriteLine("Items left in the Stack = " + EmpStack.Count);

            Console.WriteLine("-----------------------------------------------------------");

            if (EmpStack.Contains(Emp3))
            {
                Console.WriteLine("Emp3 is in the stack.");
            }

            Console.WriteLine("-----------------------------------------------------------");

            // ************************ Part 2 *************************

            List<Employee> listEmployee = new List<Employee>();

            listEmployee.Add(Emp1);
            listEmployee.Add(Emp2);
            listEmployee.Add(Emp3);
            listEmployee.Add(Emp4);
            listEmployee.Add(Emp5);

            if (listEmployee.Contains(Emp2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }
            Console.WriteLine();

            // Find the first object in the list with Gender Male
            Employee Employe = listEmployee.Find(es => es.Gender == "Male");
            Console.WriteLine($"{Employe.Id} - {Employe.Name} - {Employe.Gender} - {Employe.Salary}");
            Console.WriteLine();

            // Find all objects in the list with Gender Male
            List<Employee> employee = listEmployee.FindAll(es => es.Gender == "Male");
            
            foreach (Employee e in employee)
            {
                Console.WriteLine($"{e.Id} - {e.Name} - {e.Gender} - {e.Salary}");
            }

            Console.ReadKey();
        }
    }
}
