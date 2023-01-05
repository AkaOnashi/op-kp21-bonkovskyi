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
            int counter = 1;
            size = n;
            arr = new Site[n * n + 1];
            arr[0].state = state_of_site.FULL;
            for (int i = 1; i <= n * n; i++)
            {
                arr[i].state = state_of_site.BLOCKED;
                arr[i].root = counter;
                counter++;
            }
        }

        //get element
        public Site get(int index)
        {
            return arr[index];
        }

        // opens the Site (row, col) if it is not open already
        public void open(int row, int col)
        {
            int index = (row - 1) * size + col;
            arr[index].state = state_of_site.OPEN;
            if (row == 1)
                union(0, index);

            if (row + 1 <= size && (isOpen(row + 1, col) || isFull(row + 1, col)))
                union(index, index + size);


            if (col - 1 >= 1 && (isOpen(row, col - 1) || isFull(row, col - 1)))
                union(index, index - 1);


            if (col + 1 <= size && (isOpen(row, col + 1) || isFull(row, col + 1)))
                union(index, index + 1);


            if (row - 1 >= 1 && (isOpen(row - 1, col) || isFull(row - 1, col)))
                union(index, index - size);
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
            for (int i = 1; i <= size * size; i++)
            {
                if (isOpen(i))
                    counter++;

            }
            return counter;
        }

        // does the system percolate?
        public bool percolates()
        {
            for (int i = 0; i <= size; i++)
            {
                if (arr[root(arr[size * (size - 1) + i].root)].state == state_of_site.FULL) { return true; }
            }
            return false;
        }

        public int root(int x)
        {
            int res = arr[x].root;
            while (res != arr[res].root)
            {
                arr[res].root = arr[arr[res].root].root;
                res = arr[res].root;
            }

            return res;
        }


        public void union(int x, int y)
        {

            int rootX = root(x);
            int rootY = root(y);
            if (rootX > rootY)
                arr[rootX] = arr[rootY];
            else
                arr[rootY] = arr[rootX];

        }
        // prints the matrix on the screen
        public void print()
        {

            Console.WriteLine("Matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    int state = (int)arr[root(i * size + j)].state;
                    switch (state)
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.DarkGray;

                            Console.Write("  ");
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("  ");
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Write("  ");
                            break;
                    }

                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
    class Task
    {
        static void Main(String[] args)
        {
            int size;
            Console.WriteLine("Enter the size of the matrix: ");
            while (true)
            {
                try
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    if (size < 1) throw new Exception();
                    break;
                }
                catch
                {
                    Console.WriteLine("Was inputed the wrong data");
                }
            }

            Percolation arr = new Percolation(size);
            Random rand = new Random();

            for (int i = 0; i <= size * size * 0.8; i++)
            {
                int row = rand.Next(1, size + 1);
                int col = rand.Next(1, size + 1);
                arr.open(row, col);
            }
            arr.print();

            int choose = 0;
            while (choose != 4)
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("1 - the system is percolate or not");
                Console.WriteLine("2 - unlock the ceils");
                Console.WriteLine("3 - count the open ceils");
                Console.WriteLine("4 - finish");

                choose = Int32.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        if (arr.percolates())
                        {
                            Console.WriteLine("System is percolate");
                        }
                        else
                            Console.WriteLine("System is not percolate");
                        break;

                    case 2:
                        Console.Write("Write row: ");
                        int row = input(size);
                        Console.Write("Write column: ");
                        int col = input(size);
                        arr.open(row, col);
                        arr.print();
                        break;
                    case 3:
                        Console.WriteLine($"Number of open sites: {arr.numberOfOpenSites()}");
                        break;
                }
            }

            Console.WriteLine("Want to run tests?\nYes - 1 or No - 0");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                /*Test*/
                unit_test();
            }
        }
        static int input(int size)
        {
            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 0 || number > size) throw new Exception();
                    break;
                }
                catch
                {
                    Console.WriteLine($"Input data is incorrect\nEnter number a greater than 0 and less than {size}");
                }
            }
            return number;
        }

        static void unit_test()
        {
            int size_t = 8;
            bool count = true;
            if (!open_test(size_t))
                count = false;
            if (!isOpen_test(size_t))
                count = false;
            if (!isFull_test(size_t))
                count = false;
            if (!root_test(size_t))
                count = false;
            if (count)
                Console.WriteLine("All tests are successful!");

        }
        static bool open_test(int size_t)
        {
            Percolation test_arr = new Percolation(size_t);
            test_arr.open(5, 5); //index = 37
            test_arr.open(2, 7); //index = 15
            test_arr.open(3, 0); //index = 16
            if (test_arr.get(37).state != state_of_site.OPEN)
            {
                Console.WriteLine("Test 1 function open Failed");
                return false;
            }
            if (test_arr.get(15).state != state_of_site.OPEN)
            {
                Console.WriteLine("Test 2 function open Failed");
                return false;
            }
            if (test_arr.get(16).state != state_of_site.OPEN)
            {
                Console.WriteLine("Test 3 function open Failed");
                return false;
            }
            Console.WriteLine("Open test is successful!");
            return true;

        }
        static bool isOpen_test(int size_t)
        {
            Percolation test_arr = new Percolation(size_t);

            test_arr.open(7, 5);  // open sites
            test_arr.open(8, 7);
            test_arr.open(3, 4); //index = 20
            if (!test_arr.isOpen(7, 5))
            {
                Console.WriteLine("Test 1 function isOpen Failed");
                return false;
            }
            if (!test_arr.isOpen(8, 7))
            {
                Console.WriteLine("Test 2 function isOpen Failed");
                return false;
            }
            if (!test_arr.isOpen(20))
            {
                Console.WriteLine("Test 3 function isOpen Failed");
                return false;
            }
            Console.WriteLine("isOpen test is successful!");
            return true;
        }
        static bool isFull_test(int size_t)
        {
            Percolation test_arr = new Percolation(size_t);
            // open sites
            test_arr.open(4, 3); //index =  27
            test_arr.union(0, 27);
            test_arr.open(2, 1); //index =  9
            test_arr.union(0, 9);
            test_arr.open(7, 6); //index =  54
            test_arr.union(0, 54);
            if (!test_arr.isFull(4, 3))
            {
                Console.WriteLine("Test 1 function isFull Failed");
                return false;
            }
            if (!test_arr.isFull(2, 1))
            {
                Console.WriteLine("Test 2 function isFull Failed");
                return false;
            }
            if (!test_arr.isFull(7, 6))
            {
                Console.WriteLine("Test 3 function isFull Failed");
                return false;
            }
            Console.WriteLine("isFull test is successful!");
            return true;
        }
        static bool root_test(int size_t)
        {
            Percolation test_arr = new Percolation(size_t);
            //index from 1 to 64 
            test_arr.union(21, 34); //root(34)= 21, root(21)= 21
            test_arr.union(15, 4); //root(15)= 4, root(4) = 4
            test_arr.union(7, 9); //
            test_arr.union(2, 7); // root(2) = 2, root(7) = 2, root(9) = 2
            if (test_arr.root(34) != 21 && test_arr.root(21) != 21)
            {
                Console.WriteLine("Test 1 function root Failed");
                return false;
            }
            if (test_arr.root(15) != 4 && test_arr.root(4) != 4)
            {
                Console.WriteLine("Test 2 function root Failed");
                return false;
            }
            if (test_arr.root(2) != 2 && test_arr.root(7) != 2 && test_arr.root(9) != 2)
            {
                Console.WriteLine("Test 3 function root Failed");
                return false;
            }
            Console.WriteLine("root test is successful!");
            return true;
        }
    }
}