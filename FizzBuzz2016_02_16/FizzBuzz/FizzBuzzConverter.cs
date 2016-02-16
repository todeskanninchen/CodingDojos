namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        private const string Buzz = "Buzz";
        private const string Fizz = "Fizz";

        public string Convert(int number)
        {
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

        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
    }
}