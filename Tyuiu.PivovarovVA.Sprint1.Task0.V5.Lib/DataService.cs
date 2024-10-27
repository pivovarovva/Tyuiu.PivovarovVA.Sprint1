namespace Tyuiu.PivovarovVA.Sprint1.Task0.V5.Lib
{
    public interface ISprint1Task0V5
    {
        double CalculateExpression();
    }

    public class MathService : ISprint1Task0V5
    {
        public double CalculateExpression()
        {
            return (1 + 2) * (1 + 9.0 / 3);
        }
    }
}
