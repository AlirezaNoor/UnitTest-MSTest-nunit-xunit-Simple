namespace TDD_Fizz_Buzz;

public class FizzBuzzClass
{
    public List<string> FizzBuzzMethod(int a)
    {
        List<string> result = new List<string>();
        for (int i = 1; i <= a; i++)
        {
            if (i%15==0)
            {
                result.Add("FizzBuzz");  
            }
            else if (i % 3 == 0)
            {
                result.Add("Fizz");
            }


            else if (i % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString());
            }

          
        }

        return result;
    }
}