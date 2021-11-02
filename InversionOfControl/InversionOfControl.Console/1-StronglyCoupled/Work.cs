using System;

namespace InversionOfControl.Console
{
    public class Work : IWork
    {
        public string DoSomeWork()
        {
            return "Doing some work.";
        }
    }
}