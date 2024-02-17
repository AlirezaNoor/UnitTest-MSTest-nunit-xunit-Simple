using Xunit;

namespace TDD_Even_odd;

public class EvaliuatorTest
{
    [Fact]
    public void Evaliuator_MustBe_pass_even_when_passEnvennuber_to_method()
    {
        const int iput = 10;
        var result=Evaliuator.checker(10);
        Assert.Equal("Even",result);
    }
    [Fact]
    public void Evalitor_MustBe_pass_odd_when_pass_odd_number_to_methd()
    {
        const int input = 11;
 
        var result=Evaliuator.checker(input);
        Assert.Equal("odd",result);
    }
}