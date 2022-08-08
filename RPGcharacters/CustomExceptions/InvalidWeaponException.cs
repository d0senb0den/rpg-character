namespace RPGcharacters.CustomExceptions;

public class InvalidWeaponException : Exception
{
    public InvalidWeaponException(string message) : base(message)
    {
    }
}
