Console.Clear();
Console.WriteLine("Polynomial Equation");

Console.Write("Enter a value for a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter a value for b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter a value for c: ");
double c = Convert.ToDouble(Console.ReadLine());

PolynomialEquation polynomialEquation = new PolynomialEquation(a, b, c);
double [] result = polynomialEquation.CalculatePolynomialEquation();
Console.WriteLine($"x1: {result[0].ToString()}");
Console.WriteLine($"x2: {result[1].ToString()}");

Console.WriteLine("Press any key to exit...");
Console.ReadKey();