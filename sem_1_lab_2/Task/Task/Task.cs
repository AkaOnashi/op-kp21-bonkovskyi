using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Xml.Schema;

namespace sem_1_lab_2
{
    enum state_of_site
    {
        BLOCKED = 0,
        OPEN,
        FULL,
    }
    //TODO name Site
    struct Site
    {
        public int root;
        public state_of_site state;
    }

    class Percolation
    {
        private Site[] arr;
        private int size;

        // creates n-by-n grid, with all sites initially blocked
        public Percolation(int n)
        {
            
        }

        //get element
        public Site get(int index)
        {
            return arr[index];
        }

        // opens the Site (row, col) if it is not open already
        public void open(int row, int col)
        {
            
        }

        // is the Site (row, col) open?
        public bool isOpen(int row, int col) { return arr[(row - 1) * size + col].state == state_of_site.OPEN; }
        public bool isOpen(int index) { return arr[index].state == state_of_site.OPEN; }

        // is the Site (row, col) full?
        public bool isFull(int row, int col) { return arr[root((row - 1) * size + col)].state == state_of_site.FULL; }

        // returns the number of open sites
        public int numberOfOpenSites()
        {
            int counter = 0;
            return counter;
        }

        // does the system percolate?
        public bool percolates()
        {
            
        }

        public int root(int x)
        {
            int res = arr[x].root;
            return res;
        }


        public void union(int x, int y)
        {

            int rootX = root(x);
            int rootY = root(y);
        }
        // prints the matrix on the screen
        public void print()
        {
            Console.WriteLine("Matrix:");
        }
    }
    class Task
    {
        static void Main(String[] args)
        {
            int size;
            Percolation arr = new Percolation(size);
            Random rand = new Random();

            int choose = 0;
            Console.WriteLine("Choose the option");
            Console.WriteLine("1 - the system is percolate or not");
            Console.WriteLine("2 - unlock the ceils");
            Console.WriteLine("3 - count the open ceils");
            Console.WriteLine("4 - finish");

            choose = Int32.Parse(Console.ReadLine());
        }
    }
}