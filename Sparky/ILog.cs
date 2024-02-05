namespace Sparky;
public interface ILog
{
    void Message(string message);
}

public class Log:ILog
{
    public void Message(string message)
    {
      Console.WriteLine(message);
    }
}
public class Fork:ILog
{
    public void Message(string message)
    {
        Console.WriteLine(message);
    }
}