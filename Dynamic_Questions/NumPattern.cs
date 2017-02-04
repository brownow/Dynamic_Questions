using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Questions
{
    class NumPattern
    {
        // Starting number
        int s;
        // Factors
        int f1, f2, f3;
        // Collection holding pattern
        int[] arr;
        // Type of numerical pattern
        String type;
        // Random object
        Random r = new Random();
        // Blank - index of array number not displayed to user
        int blank;

        // Default Numpattern class
        // 5 numbers
        // 1 difference
        // 1 type
        public NumPattern(String type)
        {
            arr = new int[5];
            f1 = r.Next(25);
            s = r.Next(10);
            this.type = type;
            blank = r.Next(this.arr.Length - 1);
        }

        public void init()
        {
            int num;
            switch(this.type){
                // Case : Addition
                // Add the first factor to the starting number and the subsequent sums for the entire array
                case "+":
                    num = s;
                    for (int i = 0; i < this.arr.Length; i++)
                    {
                        num = num + f1;
                        this.arr[i] = num;
                    }
                    break;

                case "-":
                    num = s;
                    for (int i = 0; i < this.arr.Length; i++)
                    {
                        num = num - f1;
                        this.arr[i] = num;
                    }
                    break;

                case "*":
                    num = s;
                    for (int i = 0; i < this.arr.Length; i++)
                    {
                        num = num * f1;
                        this.arr[i] = num;
                    }
                    break;
            }

        }

        public void displayPattern()
        {
            // Randomly select a number in the pattern to leave blank for the user
            
            for (int i=0; i<this.arr.Length; i++)
            {
                if (i != blank) Console.Write(arr[i] + "\t");
                else
                {
                    Console.Write("_\t");
                }
            }
            Console.Write("\n");
        }

        public void getUserInput()
        {
            DateTime start = DateTime.Now;
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(answer);
            DateTime finish = DateTime.Now;
            if (answer == arr[blank]) Console.Write("Correct!");
            else
            {
                Console.Write("Incorrect!");
            }
            Console.WriteLine("The answer is: " + arr[blank]);
            Console.WriteLine("Time taken for question:\t" + (finish.Subtract(start)));
            Console.ReadKey();
        }

    }
}
