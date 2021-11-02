namespace InversionOfControl.Console
{
    public class StronglyCoupled
    {
        public Work DependancyWorkObject { get; set; }
        public StronglyCoupled(){
            DependancyWorkObject = new Work();
        }
        public string DoSomeWork()
        {
            return DependancyWorkObject.DoSomeWork();
        }
    }
}