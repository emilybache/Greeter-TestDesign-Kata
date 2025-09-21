namespace CommunicateIntentLH;

internal static class HourExtensions
{
    internal static bool IsBetween(this int value, int minimum, int maximum)
    {
        if (minimum > maximum)
            return value <= maximum || value >= minimum;
            
        return value >= minimum && value <= maximum;
    }
}