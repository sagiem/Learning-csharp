using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Link a = new Link();
            a.Add(3);
            Link b = new Link();
            b.Add(4);
            Link c = new Link();
            c.Add(5);

            Link.Display();
            Console.ReadKey();
        }
    }
}

class Link
{
    private Link next;
    private int num;
    static Link beg;

    
    public void Add(int numb)
    { 
        this.num = numb; 
        if(beg == null)
        {
            beg = this;
            return;
        }

        Link temp = beg;
        while(temp != null)
        {
            temp = temp.next;
        }
        temp.next = this;
    }

    public static void Display()
    {
        Link temp = beg;
        while(temp != null)
        {
            Console.Write(" " + temp.next);
            temp=temp.next;
        }
    }
}
