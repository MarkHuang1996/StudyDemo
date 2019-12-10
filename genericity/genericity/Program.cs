using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericity
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1] create genericity object 

            MyStack<int> myStack = new MyStack<int>(5);
            MyStack<string> myStack1 = new MyStack<string>(3);

            //Push
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            

            //Pop
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            Console.Read();

        }
    }
}
