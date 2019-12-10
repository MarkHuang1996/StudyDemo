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

    #region kw: default

    class MyGenericClass1<T1, T2>
    {
        private T1 obj1;

        private MyGenericClass1()
        {
            //kw default
            obj1 = default(T1);//if t1 is reference type  
        }
    }
    #endregion


    #region genericity with limit
    class MyGenericClass2<T1, T2, T3>
        where T1:struct//T1 must be the value type
        where T2:class//T2  must be the refe type
        where T3: new()//T3 must be have less one constraucter without no prame
    {
        //Product  list
        public List<T2> ProductList { get; set; }
        //Publisher
        public T3 Publisher { get; set; }
        public MyGenericClass2()
        {
            ProductList = new List<T2>();
            Publisher = new T3();
        }


        public T2 Buy(T1 num)
        {
            dynamic a = num;

            return ProductList[a];
        }
    }

    #endregion

    class Course
    {
        public string Name { get; set; }
        public int Period { get; set; }
    }

    class Teacher
    {
        public string TeacherName { get; set; }

        public int ClassCount { get; set; }
    }

    class MyGenericClass3<T1, T2, T3>
        where T1:struct
        where T2:Course
        where T3:Teacher
    {
        public T1 num { get; set; }

        public T2 Course { get; set; }
        public T3 Teacher { get; set; }

    }
}
