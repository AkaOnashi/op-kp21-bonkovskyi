using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int num = 1, choice = -1;
        bool flag = true;

        WorkerInfoList workerInfoList = new WorkerInfoList();

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
                    string last_name;
                    double salary, withheld;

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
                    WorkerInfo worker = new WorkerInfo(last_name, salary, withheld);
                    worker.num = num;
                    num++;
                    workerInfoList.AddWorker(worker);
                    break;

                case 2:
                    if (workerInfoList.Count == 0)
                    {
                        Console.WriteLine("You have not filled in information about workers yet.");
                        break;
                    }
                    Console.WriteLine("\nGeneral information about the workers:");
                    Console.WriteLine("\n Num - Last name - Salary,grn - Withheld,grn - Gived,grn");
                    workerInfoList.PrintGeneralInfo();

                    // counting sum
                    double sum_salary = workerInfoList.SumSalary();
                    double sum_withheld = workerInfoList.SumWithheld();
                    double sum_total_salary = workerInfoList.SumTotalSalary();
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

public class WorkerInfoList
{
    private List<WorkerInfo> workers;

    public WorkerInfoList()
    {
        workers = new List<WorkerInfo>();
    }

    public void AddWorker(WorkerInfo worker)
    {
        workers.Add(worker);
    }

    public int Count
    {
        get { return workers.Count; }
    }

    public void PrintGeneralInfo()
    {
        foreach (WorkerInfo worker in workers)
        {
            worker.PrintGeneralInfo();
        }
    }

    public double SumSalary()
    {
        return workers.Sum(worker => worker.Salary);
    }

    public double SumWithheld()
    {
        return workers.Sum(worker => worker.Withheld);
    }

    public double SumTotalSalary()
    {
        return workers.Sum(worker => worker.TotalSalary());
    }
}

public class WorkerInfo
{
    public int num;
    private string last_name;
    private double salary;
    private double withheld;

    public double Salary { get { return salary; } }
    public double Withheld { get { return withheld; } }

    public WorkerInfo(string last_name, double salary, double withheld)
    {
        this.last_name = last_name;
        this.salary = salary;
        this.withheld = withheld;
    }

    public double TotalSalary()
    {
        return this.salary - this.withheld;
    }

    public void PrintGeneralInfo()
    {
        Console.WriteLine("\n {0} --- {1} --- {2}grn --- {3}grn --- {4}grn", this.num, this.last_name, this.salary, this.withheld, this.TotalSalary());
    }
}
