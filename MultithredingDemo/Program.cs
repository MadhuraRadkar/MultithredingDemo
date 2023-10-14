using System;
using System.Collections.Generic;
using System.Threading;

namespace MultithredingDemo
{
    public class MultiThreding
    {
        // Task 1
        public void First()
        {   
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        // Task 2
        public void Second()
        { 
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            MultiThreding first = new MultiThreding();
            //create thread
            // allocate method ref to the ThreadStart delegate
            Thread t1 = new Thread(new ThreadStart(first.First));
            Thread t2 = new Thread(new ThreadStart(first.Second));
            // Request to the CPU to set the priority.
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.AboveNormal;
            t1.Start();
           // t1.Join();  -- To join t1 & t1. print t1 first then t1
           t1.Join(2000);  // To set duration 2 sec. 
            t2.Start();

        }
    }
    
}
