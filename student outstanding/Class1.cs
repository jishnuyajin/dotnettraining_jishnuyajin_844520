using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class professor : common
    {
        public int noofpaper;
        public professor(int x, string sname, int sage, int np):base(x,sname,sage)
        {
            noofpaper = np;
        }
        public void validate()
        {
            if(noofpaper>4)
            {
                Console.WriteLine("Outstanding");
            }
        }
    }
public class student : common
{
    public int mark_scored;
    public student(int x,string sname,int sage,int np):base(x,sname,sage)
        {
            mark_scored = np;
        }
        public void validate()
        {
            if(mark_scored>85)
            {
                Console.WriteLine("Outstanding");
            }
        }

    }
    public class common
    {
        public int id;
        public string name;
        public int age;
    public common(int x, string sname, int sage)
    {
        id = x;
        name = sname;
        age = sage;
    }
        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

    }

}
