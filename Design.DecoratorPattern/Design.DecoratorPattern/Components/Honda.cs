namespace Design.DecoratorPattern.Components
{
    public class Honda : ICar
    {
        public string Make => "Accord";

        public double GetCost()
        {
            return 80000;
        }
    }
}
