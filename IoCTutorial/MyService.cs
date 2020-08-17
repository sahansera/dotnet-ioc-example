using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCTutorial
{
    public interface IMyService
    {
        void DoSomething();
    }
    
    public class MyService : IMyService
    {
        private readonly IMyDependency _myDependency;
        
        public MyService(IMyDependency myDependency)
        {
            Console.WriteLine("Constructed MyService");
            _myDependency = myDependency;
        }
        
        // Multiple Dependencies example
        // private readonly IEnumerable<IMyDependency> _myDependencies;
        // public MyService(IMyDependency myDependency)
        // {
        //     Console.WriteLine("Constructed MyService");
        //     _myDependency = myDependency;
        // }
        
        public void DoSomething()
        {
            _myDependency.DoWork();

            // Multiple Dependencies example
            // foreach (var dependency in _myDependencies)
            // {
            //     dependency.DoWork();
            // }
            //
            // _myDependencies
            //     .FirstOrDefault(x => x.GetType() == typeof(MyDependency))?.DoWork();
        }
    }
}