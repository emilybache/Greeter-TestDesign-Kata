namespace CommunicateIntentLH;

internal class Greeter
{
    private readonly IDateTimeProvider _datetimeProvider;

    public Greeter(IDateTimeProvider datetimeProvider)
    {
        _datetimeProvider = datetimeProvider;
    }
    
    public string Greet(string name)
    {
        var hour = _datetimeProvider.GetDateTime().Hour;
        string template = string.Empty;
        if (hour.IsBetween(7, 13))
        {
            template = "Good morning {0}";
        }
        if (hour.IsBetween(14,19))
        {
            template = "Good afternoon {0}";
        }
        if (hour.IsBetween(20, 6))
        {
            template = "Good night {0}";
        }
        return String.Format(template, name);
    }
}