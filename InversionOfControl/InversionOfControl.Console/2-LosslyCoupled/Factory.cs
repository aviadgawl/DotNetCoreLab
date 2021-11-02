namespace InversionOfControl.Console
{
    public class Factory
    {
        public static IWork GetWorkObject()
        {
            return new Work();
        }
    }
}