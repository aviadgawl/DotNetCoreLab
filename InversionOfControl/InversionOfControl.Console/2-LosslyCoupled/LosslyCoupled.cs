namespace InversionOfControl.Console
{
    public class LosslyCoupled
    {
        public IWork DependancyWorkObject { get; set; }
        public LosslyCoupled(IWork work)
        {
            DependancyWorkObject = work;
        }

        public string DoSomeWork()
        {
            return DependancyWorkObject.DoSomeWork();
        }
    }

}