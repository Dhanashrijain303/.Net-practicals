// See https://aka.ms/new-console-template for more information
/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;

class Program
{
    static void Main()
    {
        List<Employee> employees=new List<Employee>();
        while (true)
        {
            Console.WriteLine("Welcome to Emp System");
            Console.WriteLine("1.Add Employee");
            Console.WriteLine("2.View Employee");
            Console.WriteLine("3.Search Employee by id");
            Console.WriteLine("4.Exist");

            Console.WriteLine("Enter choice 1-4");

            try
            {
                int choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                      Console.Write("Enter id: ");
                      int id =Console.ToInt32(Console.ReadLine());
                      bool exists = false;
                      foreach(Employee emp in employees)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter salary: ");
                            double salary=Convert.ToDouble(Console.ReadLine());
                            Employee employee=new Employee(id,name,salary);
                            employees.Add(employee);
                            Console.WriteLine("Employee added");
                            break;
                    case 2:
                            if(employees.Count == 0)
                                {
                                    Console.WriteLine("No Employe");
                                }
                                else
                                {
                                    foreach(Employee emp in employees)
                                    {
                                        emp.Display();
                                    }
                                }
                                break;
                    case 3:
                           Console.Write("Enter Employee Id ");
                           int SearchId = Convert.ToInt32(Console.ReadLine());
                           bool found = false;
                           foreach(Employee emp in employees)
                                {
                                    if(emp.Id == SearchId)
                                    {
                                        emp.Display();
                                        found = true;
                                        break;


                                    }
                                }if(!found)
                                {
                                    Console.WriteLine("Employee not Found.");
                                }
                                break;
                    case 4:
                        return;
                    
                    default:
                    Console.WriteLine("Invalid Choice");
                    break;
                }

            }
        }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }

}*/

using System;
using System.Collections.Generic;

/*class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        List<Manager> managers =new List<Manager>();

        while (true)
        {
            Console.WriteLine("\n===== Employee Management System =====");
            Console.WriteLine("3. View Employees");
            Console.WriteLine("3. View Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Employee ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Employee ID already exists.");
                        }
                        else
                        {
                            Console.Write("Enter Employee Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Salary: ");
                            double salary = Convert.ToDouble(Console.ReadLine());

                            Employee employee = new Employee(id, name, salary);
                            employees.Add(employee);

                            Console.WriteLine("Employee Added Successfully.");
                        }

                        break;

                    case 2:

                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No Employees Found.");
                        }
                        else
                        {
                            foreach (Employee emp in employees)
                            {
                                emp.Display();
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Enter Employee ID to Search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee Not Found.");
                        }

                        break;

                    case 4:

                        Console.WriteLine("Thank You!");
                        return;

                    default:

                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
*/

//Genericseg<int> n =new Genericseg<int>();
//n.print(100)

//Genericseg<int> n =new Genericseg<int>();
//n.print(100)

//Genericseg<int> n =new Genericseg<int>();
//n.print(100)


//string empname