public class PolynomialEquation
{
    private double A { get; set; }
    private double B { get; set; }
    private double C { get; set; }

    public PolynomialEquation(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double [] CalculatePolynomialEquation()
    {
        double [] polynomialEquation = { CalculateX1(), CalculateX2() };
        return polynomialEquation;
    }

    private double CalculateDelta() => ((Math.Pow(B, 2)) - (4 * (A * C)));

    private double CalculateX1() => (-(B) + Math.Sqrt(CalculateDelta())) / (2 * A);

    private double CalculateX2() => (-(B) - Math.Sqrt(CalculateDelta())) / (2 * A);
}