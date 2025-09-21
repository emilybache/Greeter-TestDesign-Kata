using Moq;
using Xunit;
using Assert = Xunit.Assert;

namespace CommunicateIntentLH;

public class Tests
{
    [Fact]
    public void GoodMorning()
    {
        var mock = new Mock<IDateTimeProvider>();
        mock.Setup(dtp => dtp.GetDateTime()).Returns(new DateTime(2000, 1, 1, 7, 0,0 ));
        var greeter = new Greeter(mock.Object);
        
        Assert.Equal("Good morning Arnau", greeter.Greet("Arnau"));
    }
    
    [Fact]
    public void GoodAfternoon()
    {
        var mock = new Mock<IDateTimeProvider>();
        mock.Setup(dtp => dtp.GetDateTime()).Returns(new DateTime(2000, 1, 1, 16, 0,0 ));
        var greeter = new Greeter(mock.Object);
        
        Assert.Equal("Good afternoon Arnau", greeter.Greet("Arnau"));
    }
    
    [Fact]
    public void GoodNight()
    {
        var mock = new Mock<IDateTimeProvider>();
        mock.Setup(dtp => dtp.GetDateTime()).Returns(new DateTime(2000, 1, 1, 0, 0,0 ));
        var greeter = new Greeter(mock.Object);
        
        Assert.Equal("Good night Arnau", greeter.Greet("Arnau"));
    }
}

public interface IDateTimeProvider
{
    DateTime GetDateTime();
}

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime GetDateTime()
    {
        return DateTime.Now;
    }
}

