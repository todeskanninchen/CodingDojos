namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        private const int BuzzNumber = 5;
        private const int FizzNumber = 3;
        private const int FizzBuzzNumber = FizzNumber * BuzzNumber;

        private const string Buzz = "Buzz";
        private const string Fizz = "Fizz";

        public string Convert(int number)
        {
            if (IsFizzBuzz(number))
            {
                return Fizz + Buzz;
            }

            if (IsFizz(number))
            { 
                return Fizz;
            }

            if (IsBuzz(number))
            {
                return Buzz;
            }

            return number.ToString();
        }

        private bool IsFizzBuzz(int number)
        {
            return number % FizzBuzzNumber == 0;
        }

        private bool IsBuzz(int number)
        {
            return number % BuzzNumber == 0;
        }

        private bool IsFizz(int number)
        {
            return number % FizzNumber == 0;
        }
    }
}