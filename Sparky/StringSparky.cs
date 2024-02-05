namespace Sparky;

public class StringSparky
{
    public int Discont = 15;
    public string GenerateName { get; set; }
    public string SayHellow(string name, string lastname)
    {
        return $"helllow {name} {lastname}";
    }
    public string FullName(string name, string lastname)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Empty first Name"); 
        }
        GenerateName = $"helllow {name} {lastname}";
        Discont = 20;
        return GenerateName;
    }
}