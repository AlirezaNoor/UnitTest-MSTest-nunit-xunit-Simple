using Xunit;

namespace TDD_Fizz_Buzz;

public class FizzBuzzTest
{
    [Fact]
    public void Return_Fizz_when_we_Pass_nummber_That_Divable_To_3()
    {
        const int input = 100;
        var element = 2;
        FizzBuzzClass fizzBuzzClass = new();
        var result = fizzBuzzClass.FizzBuzzMethod(input);
        Assert.Equal("Fizz", result[element]);
    }

    [Fact]
    public void Return_Fizz_When_We_pass_nummber_that_divable_to_5()
    {
        const int input = 100;
        var element = 4;
        FizzBuzzClass fizzBuzzClass = new();
        var result = fizzBuzzClass.FizzBuzzMethod(input);
        Assert.Equal("Buzz", result[element]);
    }
    [Fact]
    public void Return_Fizz_When_We_pass_nummber_that_divable_to_5_And_3()
    {
        const int input = 100;
        var element = 14;
        FizzBuzzClass fizzBuzzClass = new();
        var result = fizzBuzzClass.FizzBuzzMethod(input);
        Assert.Equal("FizzBuzz", result[element]);
    }
}