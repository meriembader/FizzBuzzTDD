
using System;

namespace FizzBuzzKata
{

    public class FizzBuzz
    {
        public string Compute(int input)
        {
            string result = string.Empty;

            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (input % 3 == 0 && input != 0)
            {
                return "Fizz";
            }
            if( input % 5 == 0 && input != 0)
            {
                return "Buzz";
            }
            if (result == string.Empty)
            {
                result=  input.ToString();
            }
            return result;

            
        }

       
    }
   
}
