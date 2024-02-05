using Moq;
using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class BankAccountnunittest
{
    private BankBalnce bankBalnce;

    [SetUp]
    public void SetUp()
    {
        bankBalnce = new BankBalnce(new Log());
    }

    [Test]
    public void BankDepoit_Add100_returnTrue()
    {
        var result = bankBalnce.adddipotide(100);
        Assert.IsTrue(result);
        ///or
        Assert.That(bankBalnce.getbalace(), Is.EqualTo(100));
    }

    [Test]
    public void BankDepoit_Add100_returnTrue_MOQ()
    {
        var MOCK = new Mock<ILog>();
        MOCK.Setup(x => x.Message(""));
        BankBalnce bankBalnce = new BankBalnce(MOCK.Object);
        var result = bankBalnce.adddipotide(100);

        Assert.IsTrue(result);
        ///or
        Assert.That(bankBalnce.getbalace(), Is.EqualTo(100));
    }
}