namespace Sparky;

public class BankBalnce
{
    public int  Balence { get; set; }

    public BankBalnce()
    {
        Balence = 0;
    }

    public bool adddipotide(int a)
    {
        Balence += a;
        return true;
    }

    public bool Withrow(int amount)
    {
        if (Balence>amount)
        {
            Balence -= amount;
            return true;
        }

        return false;
    }
}