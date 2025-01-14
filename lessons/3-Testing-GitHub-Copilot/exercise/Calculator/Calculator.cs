namespace Calculator
{
	public class Calculator
	{
		public double Add(double a, double b)
		{
			return a + b;
		}

		public double Subtract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Modulus(double a, double b)
		{
			if (b == 0)
				throw new DivideByZeroException("Cannot divide by zero for modulus operation.");
			return a % b;
		}

        public double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Cannot calculate the square root of a negative number.");
            return Math.Sqrt(a);
        }

		public bool IsPrime(int number)
		{
			if (number <= 1) return false;
			if (number == 2) return true;
			if (number % 2 == 0) return false;

			var boundary = (int)Math.Floor(Math.Sqrt(number));

			for (int i = 3; i <= boundary; i += 2)
			{
				if (number % i == 0) return false;
			}

			return true;
		}
        
        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }      
	}
}
