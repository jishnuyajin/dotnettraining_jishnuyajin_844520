using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number of student");
            n = int.Parse(Console.ReadLine());
            student[] students = new student[n];
            int m;
            Console.WriteLine("Enter number of professor");
            m = int.Parse(Console.ReadLine());
            professor[] professors = new professor[m];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter details of student " + (i + 1));
                Console.WriteLine("Enter id of student " + (i + 1));
                int id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of student " + (i + 1));
                string name = Console.ReadLine();
                Console.WriteLine("Enter age of student " + (i + 1));
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter mark of student " + (i + 1));
                int marks = int.Parse(Console.ReadLine());
                students[i] = new student(id, name, age, marks);
                students[i].validate();
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Enter details for professor " + (i + 1));
                Console.WriteLine("Enter id of professor " + (i + 1));
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of professor " + (i + 1));
                string name = Console.ReadLine();
                Console.WriteLine("Enter age of professor " + (i + 1));
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter no of papers of professor " + (i + 1));
                int nop = int.Parse(Console.ReadLine());
                professors[i] = new professor(id, name, age, nop);
                professors[i].validate();
            }
            /*student c1 = new student(1,"Gopi",21,88);
            
            c1.display();
            c1.validate();
            professor c2 = new professor(2,"jishnu",31,5);
            c2.display();
            c2.validate();*/

        }
    }
}
