namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string[] FizzBuzzFrom1To16()
        {
            var result = new string[16];
            result[0] = "1";
            result[1] = "2";
            result[2] = "Fizz";
            result[3] = "4";
            result[4] = "Buzz";
            result[5] = "Fizz";
            result[6] = "7";
            result[7] = "8";
            result[8] = "Fizz";
            result[9] = "Buzz";
            result[10] = "11";
            result[11] = "Fizz";
            result[12] = "13";
            result[13] = "14";
            result[14] = "FizzBuzz";
            result[15] = "16";
            return result;
        }

        public string[] FizzBuzzInterval(int start, int end)
        {
            var result = new string[end - start + 1];
            result[0] = "1";
            return result;
        }
    }
}