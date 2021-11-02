using InversionOfControl.Console;

namespace InversionOfControl
{
    public class MockWork : IWork
    {
        public string DoSomeWork()
        {
            return "Pretend to work.";
        }
    }
}