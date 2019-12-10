using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericity
{
    /* gennericity class and gennericity  method 
     
         gennericity delegate
         Func
         Action

        synx: public class ClassName<T>{......}

        T mean's it can be any type of data 
         
         */

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">T can be any data type</typeparam>
    public class MyStack<T>
    {
        private T[] stack;// create new stack
        private int stackPoint; //be used to mark locaiton in stack
        private int size;//stack size

        public MyStack(int size)
        {
            this.size = size;
            this.stack = new T[size];
            this.stackPoint = -1;
        }


        //push method
        public void Push(T item)
        {
            if (stackPoint > size)
            {
                Console.WriteLine("stack full");

            }
            else
            {
                stackPoint++;
                this.stack[stackPoint] = item;
            }
        }

        //pop method
        public T Pop()
        {
            T data = this.stack[stackPoint];
            stackPoint--;
            return data;
        }

    }
}
