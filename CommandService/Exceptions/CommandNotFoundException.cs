namespace CommandsService.Exceptions
{
  public class InvalidCommandIdException : Exception
  {
    public InvalidCommandIdException(int platformId, int command)
        : base($"Command with ID {command} for {platformId} platform not found.")
    {
    }
  }
}