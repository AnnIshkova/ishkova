using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace kollect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAY");
            array array = new array();
            array.dobav(2);
            array.dobav(3);
            array.dobav(4);
            array.vyvod();
            Console.ReadLine();
            array.poluch(0);
            Console.ReadLine();
            array.dlinn();
            array.udal(1);
            array.vyvod();
            Console.ReadLine();

            Console.WriteLine("LIST");
            list listt = new list();
            listt.dobav(1);
            listt.dobav(2);
            listt.dobav(3);
            listt.vyvod();
            Console.ReadLine();
            listt.poluch(2);
            Console.ReadLine();
            listt.dlinn();
            listt.udal(1);
            listt.vyvod();
            Console.ReadLine();

            Console.WriteLine("STACK");
            stack stackt = new stack();
            stackt.dobav(1);
            stackt.dobav(2);
            stackt.dobav(3);
            stackt.dobav(4);
            Console.ReadLine();
            stackt.dlin();
            stackt.udal();
            Console.ReadLine();

            Console.WriteLine("QUEUE");
            queue queuet = new queue();
            queuet.dobav(1);
            queuet.dobav(2);
            queuet.dobav(3);
            Console.ReadLine();
            queuet.dlin();
            queuet.udal();
            Console.ReadLine();

        }
    }
    class array
    {
        public ArrayList arrayy;

        public void vyvod()
        {
            for (int i = 0; i < this.arrayy.Count; i++)
            {
                Console.WriteLine(this.arrayy[i]);
            }
        }

        public void dobav(int a)
        {
            this.arrayy.Add(a);
        }
        public void udal(int a)
        {
            this.arrayy.RemoveAt(a);
        }
        public void poluch(int a)
        {
            Console.WriteLine(this.arrayy[a]);
        }
        public void dlinn()
        {
            Console.WriteLine(this.arrayy.Count);
        }

        public array()
        {
            arrayy = new ArrayList();
        }
    }
    class list
    {
        public List<int> listt;

        public void vyvod()
        {
            for (int i = 0; i < this.listt.Count; i++)
            {
                Console.WriteLine(this.listt[i]);
            }
        }

        public void dobav(int a)
        {
            this.listt.Add(a);
        }
        public void udal(int a)
        {
            this.listt.RemoveAt(a);
        }
        public void poluch(int a)
        {
            Console.WriteLine(this.listt[a]);
        }
        public void dlinn()
        {
            Console.WriteLine(this.listt.Count);
        }
        public list()
        {
            listt = new List<int> { 0 };
        }

    }
    class stack
    {
        public Stack<int> stackt;


        public void dobav(int a)
        {
            this.stackt.Push(a);
        }
        public void udal()
        {
            this.stackt.Pop();
        }
        public void poluc()
        {
            this.stackt.Peek();
        }
        public void dlin()
        {
            Console.WriteLine(this.stackt.Count);
        }
        public stack()
        {
            stackt = new Stack<int>();
        }

    }
    class queue
    {
        public Queue<int> queuet;

        public void dobav(int a)
        {
            this.queuet.Enqueue(a);
        }
        public void udal()
        {
            this.queuet.Dequeue();
        }
        public void poluc()
        {
            this.queuet.Peek();
        }
        public void dlin()
        {
            Console.Write(this.queuet.Count);
        }
        public queue()
        {
            queuet = new Queue<int>();
        }
    }

}
