namespace DesignPattern.DecoratorPattern.Model
{
    public interface ICar
    {
        string Make { get; }

        double GetCost();
    }
}