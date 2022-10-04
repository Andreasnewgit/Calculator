namespace CalculatorTests
{
    public class xUnitTestsCalculator
    {
        [Fact]
        // Expect to pass.
        public void AdditionTest()
        {
            Assert.Equal(4, Addition(2, 2));
        }
        // Expect to fail.
        [Fact]
        public void AdditionFAIL()
        {
            Assert.Equal(5, Addition(2, 2));
            Assert.True(false, "Expected to fail.");
        }
        [Fact]
        // Expect to pass.
        public void SubtractionTest()
        {
            Assert.Equal(0, Subtraction(2, 2));
        }
        [Fact]
        // Expect to fail.
        public void SubtractionFAIL()
        {
            Assert.Equal(0, Subtraction(7, 5));
            Assert.True(false, "Expected to fail.");
        }

        [Fact]
        // Expect to pass.
        public void MultiplicationTest()
        {
            Assert.Equal(25, Multiplication(5, 5));
        }

        [Fact]
        // Expect to fail.
        public void MultiplicationFAIL()
        {
            Assert.Equal(25, Multiplication(6, 5));
            Assert.True(false, "Expected to fail.");
        }


        [Fact]
        // Expect to pass.
        public void PowerO2fTest()
        {
            Assert.Equal(25, Powerof2(5));

        }


        [Fact]
        // Expect to fail.
        public void PowerO2fFAIL()
        {
            Assert.NotEqual(26, Powerof2(5));
            Assert.True(false, "Expected to fail.");
        }

            [Fact]
        // Expect to pass.
        public void DivisionTest()
        {
            Assert.Equal(5, Division(10, 2));
        }

        [Fact]
        // Expect to fail.
        public void DivisionFAIL()
        {
            Assert.Equal(5, Division(20, 2));
        }

    
        [Fact]
        public void DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Assert.Equal(10, Divide(100, 0)));

        }


        //---------------------//
        // Methods  **********//
        //___________________//

        static int Addition(int addOne, int addTwo)
        {
            //Console.WriteLine("\nEnter the two numbers you want to add: \n");
            //addOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("+");
            //addTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("=");
            int sum = addOne + addTwo;
            //Console.WriteLine(sum + "\n");
            return sum;
        }

        static int Subtraction(int subOne, int subTwo)
        {
            //Console.WriteLine("\nEnter the two numbers you want subtracted: \n");
            //subOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-");
            //subTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("=");
            int sum = subOne - subTwo;
            //Console.WriteLine(sum + "\n");
            return sum;
        }

        static int Multiplication(int multiOne, int multiTwo)
        {
            //Console.WriteLine("\nEnter the two numbers you want multiplied: \n");
            //multiOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("*");
            //multiTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("=");
            int sum = multiOne * multiTwo;
            Console.WriteLine(sum + "\n");
            return sum;
        }

        static int Powerof2(int powOne)
        {
            //Console.WriteLine("\nEnter the number you want Squared: \n");
            //int powOne = Convert.ToInt32(Console.ReadLine());
            int sum = powOne * powOne;
            Console.WriteLine(sum);
            return sum;
        }
        static int Division(int divOne, int divTwo)
        {
            //Console.WriteLine("\nEnter the two numbers you want divided: \n");
            //divOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("/");
            //divTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("=");
            int returnValue = 0;
            try
            {
                int sum = divOne / divTwo;
                Console.WriteLine(sum + "\n");
                return sum;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by 0");
                return returnValue;
            }
        }

        public static int Divide(int input_1, int input_2)
        {

            int result = input_1 / input_2;
            return result;
        }

    }
}