using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericity
{
    class Program
    {

        #region  genericity Push and Pop
        //static void Main(string[] args)
        //{


        //    //[1] create genericity object 

        //    MyStack<int> myStack = new MyStack<int>(5);
        //    MyStack<string> myStack1 = new MyStack<string>(3);

        //    //Push
        //    myStack.Push(1);
        //    myStack.Push(2);
        //    myStack.Push(3);
        //    myStack.Push(4);
        //    myStack.Push(5);


        //    //Pop
        //    Console.WriteLine(myStack.Pop());
        //    Console.WriteLine(myStack.Pop());
        //    Console.WriteLine(myStack.Pop());
        //    Console.WriteLine(myStack.Pop());
        //    Console.WriteLine(myStack.Pop());

        //    Console.Read();


        //    //


        //}

        #endregion

        static void Main(string[] args)
        {
            //Test for  limited genercity class
            //[1] instance of class 
            MyGenericClass3<int, Course, Teacher> myClass = new MyGenericClass3<int, Course, Teacher>();

            myClass.Teacher = new Teacher() { TeacherName = "Ken", ClassCount = 2 };

            myClass.Course = new Course() { Name = ".net", Period = 25 };
        }
    }
}
