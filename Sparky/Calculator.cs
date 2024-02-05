namespace Sparky;

public class Calculator
{
    private List<int> ListofNummber = new List<int>();

    public int AddCalculater(int a, int b)
    {
        return a + b;
    }

    public bool OddNumberCalculate(int a)
    {
        return a % 2 != 0;
    }


    public double AddDoubleCalculator(double a, double b)
    {
        return a + b;
    }

    public List<int> Add_Oddnumber_To_List(int a, int b)
    {
        ListofNummber.Clear();
        for (int i = a; i < b; i++)
        {
            if (i % 2 != 0)
            {
                ListofNummber.Add(i);
            }
        }

        return ListofNummber;
    }
    
    
}