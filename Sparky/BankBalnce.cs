namespace Sparky;

public class BankBalnce
{
    public int Balence { get; set; }
    private readonly ILog _log;

    public BankBalnce(ILog log)
    {
        _log = log;
        Balence = 0;
    }

    public bool adddipotide(int a)
    {
        _log.Message("thsi is adddipotide");
        Balence += a;
        return true;
    }

    public bool Withrow(int amount)
    {
        if (Balence > amount)
        {
            _log.Message("thsi is Withrow");
            Balence -= amount;
            return true;
        }

        return false;
    }

    public int getbalace()
    {
        return Balence;
    }
}