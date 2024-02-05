namespace Sparky;

public class StringSparky
{
    public int Discont = 15;
    public string GenerateName { get; set; }
    public int totalorder { get; set; }

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

    public CustomerType GetCustomerDatails()
    {
        if (totalorder<100)
        {
            return new BasicCustomer();
        }

        return new PlatformCustomer();
    }
}

public class CustomerType
{
}

public class BasicCustomer : CustomerType
{
}

public class PlatformCustomer : CustomerType
{
}