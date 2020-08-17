using System;

namespace IoCTutorial
{
    public interface IMyDependency
    {
        void DoWork();
    }
    public class MyDependency : IMyDependency
    {
        public MyDependency()
        {
            Console.WriteLine("Constructed MyDependency");
        }
        
        public void DoWork()
        {
            Console.WriteLine("Doing some work in MyDependency");
        }
    }
    
    // Multiple implementations of same interface example
    public class MyDependency2 : IMyDependency
    {
        public MyDependency2()
        {
            Console.WriteLine("Constructed MyDependency2");
        }
        
        public void DoWork()
        {
            Console.WriteLine("Doing some work in MyDependency2");
        }
    }
}