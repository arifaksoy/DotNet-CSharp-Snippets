public class Calculator
{
    public virtual int SquareRoot(int number)
    {
        return (int)Math.Sqrt(number);
    }
}

public class SafeCalculator : Calculator
{
    public override int SquareRoot(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Sayı negatif olamaz!");
        }
        return base.SquareRoot(number);
    }
}

Calculator calc = new SafeCalculator();
Console.WriteLine(calc.SquareRoot(-4)); // Temel sınıfta çalışırken, alt sınıfta patlar!
