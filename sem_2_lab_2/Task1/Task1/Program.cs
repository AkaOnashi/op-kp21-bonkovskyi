using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string last_name = null;
        int num = 1, choice = -1; 
        double salary = 0, withheld = 0, total_salary, sum_salary = 0, sum_withheld = 0, sum_total_salary = 0;
        bool flag = true;

        List<SalaryInfo> workers = new List<SalaryInfo>();

        Console.WriteLine("\nGood afternoon!");
        while (flag)
        {
            Console.WriteLine("\n Choose the option:");
            Console.WriteLine("\n 1 - Fill in information about the worker.\n 2 - See the general info \n 3 - Stop the program.");
            try
            {
                Console.Write("\nEnter the number of option: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, enter the NUMBER of option from the list.");
                break;
            }

            switch (choice)
            {
                case 1:
                    try
                    {
                        Console.Write("Enter the worker's last name: ");
                        last_name = Console.ReadLine();
                        Console.Write("Enter the worker's salary: ");
                        salary = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the worker's withheld: ");
                        withheld = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)  
                    {
                        Console.WriteLine("Please, enter the CORRECT information about the worker.");
                        break;
                    }
                    
                    Console.WriteLine("The information about {0} was filled. Thanks!", last_name);
                    SalaryInfo worker = new SalaryInfo(last_name, salary, withheld);
                    total_salary = worker.TotalSalary();
                    worker.num = num;
                    num++;
                    workers.Add(worker);
                    break;
                
                case 2:
                    if(workers.Count == 0)
                    {
                        Console.WriteLine("You have not filled in information about workers yet.");
                        break;
                    }
                    Console.WriteLine("\nGeneral information about the workers:");
                    Console.WriteLine("\n Num - Last name - Salary,grn - Withheld,grn - Gived,grn");
                    for(int i = 0; i < workers.Count; i++)
                    {
                        workers[i].PrintGeneralInfo();
                    }

                    // counting sum
                    for (int i = 0; i < workers.Count; i++)
                    {
                        sum_salary += workers[i].Salary;
                        sum_withheld += workers[i].Withheld;
                        sum_total_salary += workers[i].Total_Salary;
                    }

                    Console.WriteLine("\n Total salary: {0} \n Total withheld: {1}\n Total wgived: {2}", sum_salary, sum_withheld, sum_total_salary);
                    break;

                case 3: 
                    flag = false;
                    Console.WriteLine("\nGoodbye!");
                    break;
                case -1:
                    break;
                default:
                    Console.WriteLine("Please, enter the number of option from the list! ");
                    break;
            }
        }
    }

}

public class SalaryInfo
{
    public int num;
    private string last_name;
    private double salary;
    private double withheld;
    private double total_salary;

    public double Salary { get { return salary; } }
    public double Withheld { get { return withheld; } }
    public double Total_Salary { get { return total_salary; } }

    public SalaryInfo(string last_name, double salary, double withheld)
    {
        this.last_name = last_name;
        this.salary = salary;
        this.withheld = withheld;
    }

    public double TotalSalary()
    {
        this.total_salary = this.salary - this.withheld;
        return this.total_salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine("{0}'s salary is {1}grn. Were withheld {2}grn. And the total salary is {3}grn", this.last_name, this.salary, this.withheld, this.total_salary);
    }

    public void PrintGeneralInfo()
    {
        Console.WriteLine("\n {0} --- {1} --- {2}grn --- {3}grn --- {4}grn", this.num, this.last_name, this.salary, this.withheld, this.total_salary);
    }
}