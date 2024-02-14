namespace Evaluator;

public class Fizz_Buzz_Game
{
    public static List<string> Start(int numberRanod)
    {
        List<string> Result = new List<string>();
        for (int i = 1; i <= numberRanod; i++)
        {
            var output = i % 3 == 0 ? "Fizz" : "";
            output += i % 5 == 0 ? "Buzz" : "";
            output += output == string.Empty ? i.ToString() : string.Empty;
            Result.Add(output);
        }

        return Result;
    }
}