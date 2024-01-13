namespace PlatformService.Exceptions
{
  public class InvalidPlatformIdException : Exception
  {
    public InvalidPlatformIdException(int platformId)
        : base($"Platform with ID {platformId} not found.")
    {
    }
  }
}