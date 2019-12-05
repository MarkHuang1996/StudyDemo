using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {

        //#region Thread One
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Thread Test 1");

        //    for(int i = 0;i < 10; i++)
        //    {
        //        Thread thread = new Thread(work);

        //        thread.Start();
        //    }

        //    Console.Read();
        //}

        //private static  void work()
        //{
        //    Console.WriteLine("Thread started ");

        //    Thread.Sleep(1000);

        //    Console.WriteLine("Thread dead");
        //}

        //#endregion


        #region Thread Two

        // static void Main()
        // {
        //     Console.WriteLine("Start Thread Test ");

        //     //create  a new Thread 
        //     Thread thread1 = new Thread(work1);

        //     PrintState(thread1);

        //     //Start thread 
        //     Console.WriteLine("Thread Start ");

        //     thread1.Start();

        //     PrintState(thread1);

        //     //Thread Sleeping
        //     Console.WriteLine("Thread Sleeping");

        //     Thread.Sleep(3*1000);

        //     //Thread Suspend

        //     Console.WriteLine("Thread Suspending");

        //     thread1.Suspend();

        //     Thread.Sleep(10000);
        //     PrintState(thread1);

        //     //Thread Resume
        //     Console.WriteLine("Thread Resume");

        //     thread1.Resume();

        //     PrintState(thread1);

        //     //Thread abort

        //     Console.WriteLine("Thread Aborting ");

        //     thread1.Abort();

        //     PrintState(thread1);

        //     Thread.Sleep(1000);

        //     PrintState(thread1);

        //     Console.WriteLine("------------------------------------------------------------");

        //     Console.WriteLine("Start Test Thread 2");

        //     Thread thread2 = new Thread(work2);

        //     PrintState(thread2);

        //     //Start Thread

        //     thread2.Start();

        //     Thread.Sleep(2 * 1000);

        //     PrintState(thread2);
        //     Thread.Sleep(10 * 1000);

        //     PrintState(thread2);

        //     Console.ReadKey();

        // }


        // private static void PrintState(Thread thread)
        // {
        //     Console.WriteLine("Thread State is " + thread.ThreadState.ToString());
        // }
        // #endregion


        // private static void work1()
        // {
        //     Console.WriteLine("Thread Running:");

        //     while (true) ;
        // }

        //private static void work2()
        // {
        //     Console.WriteLine("Thread start sleep");

        //     //10s sleep

        //     Thread.Sleep(10 * 1000);
        //     Console.WriteLine("Thread resume");
        // }

        #endregion


        #region Thread Pool

    static void Main()
        {
            string taskinfo = "Runing 10s";

            bool result = ThreadPool.QueueUserWorkItem(DoWork, taskinfo);

            if (!result)
            {
                Console.WriteLine("分配线程失败");
            }
            else
            {
                Console.WriteLine("Press entry key to stop  ");
            }

            Console.Read();
        }


       private static void DoWork(object state)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Worker Thread  {0}", state);
                Thread.Sleep(1000);
            }
        }
      

        

        
        #endregion  

    }
}
