namespace Sparky;

public class StringSparky
{
    public string SayHellow(string name, string lastname)
    {
        return $"helllow {name} {lastname}";
    }

    public string GenerateName { get; set; }

    public string FullName(string name, string lastname)
    {
        GenerateName = $"helllow {name} {lastname}";
        return GenerateName;
    }
}