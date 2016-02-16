namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        private const string Fizz = "Fizz";

        public string Convert(int number)
        {
            if (IsFizz(number))
            { 
                return Fizz;
            }

            return number.ToString();
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
    }
}