using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Good afternoon!\n Choose the option:");
        Console.WriteLine(" 1 - Fill in information about the worker.\n 2 - See the info of a specific worker.\n 3 - See the general info. \n 4 - Stop the program.");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: 
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
        }
    }

}

public class SalaryInfo
{
    private int num;
    private string last_name;
    private double salary;
    private double withheld;
    private double salary_total;

    public SalaryInfo(string last_name)
    {
        this.last_name = last_name;
    }

    public SalaryInfo(string last_name, double salary, double withheld)
    {
        this.last_name = last_name;
        this.salary = salary;
        this.withheld = withheld;
    }

    public double CountTotalSalary(int a)
    {
        return salary - withheld;
    }

}