using Evaluator;

namespace XunitTest;

public class UnitTest1
{
 [Fact]
 public void Evaluator_Should_be_Even()
 {
  const int a = 6;
  Evaluator.Evaluator evaluator = new();
  var result = evaluator.EvaluatorMethod(a);
  Assert.Equal("Even",result);
 }

 [Fact]
 public void Evaluator_Should_be_Odd(
 {
  const int a = 11;
  Evaluator.Evaluator evaluator = new();
  var actual = evaluator.EvaluatorMethod(a);
  Assert.Equal("odd",actual);
 }

 [Fact]
 public void Check_TheNumber_Was_back_to_user()
 {
  const int all = 100;
  var result = Fizz_Buzz_Game.Start(all);
  
  Assert.Equal(all,result.Count);
 }

 [Fact]
 public void Check_Fiz_in_Game()
 {
  const int all = 100;
  var result = Fizz_Buzz_Game.Start(all);
  Assert.Equal("Fizz",result[2]);
 }

 [Fact]
 public void Chack_FizBuzz_in_Game()
 {
  const int all = 100;
  var result = Fizz_Buzz_Game.Start(all);
  Assert.Equal("FizzBuzz",result[14]);
 }
 [Fact]
 public void Chack_Buzz_in_Game()
 {
  const int all = 100;
  var result = Fizz_Buzz_Game.Start(all);
  Assert.Equal("Buzz",result[4]);
 }
}