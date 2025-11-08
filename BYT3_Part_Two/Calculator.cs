namespace BYT3_Part_Two
{
    public class Calculator
    {
        private readonly double A;
        private readonly double B;
        private readonly string Operation;

        public Calculator(double a, double b, string operation)
        {
            A = a;
            B = b;
            Operation = operation;
        }

        public double Calculate()
        {
            return Operation switch
            {
                "+" => A + B,
                "-" => A - B,
                "*" => A * B,
                "/" => B != 0 ? A / B : throw new DivideByZeroException("Cannot divide by zero"),
                _ => throw new InvalidOperationException("Unknown operation")
            };
        }
    }
}