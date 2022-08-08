namespace RPGcharacters.CustomExceptions;

public class InvalidArmorException : Exception
{
    public InvalidArmorException(string message) : base(message)
    {
    }
}