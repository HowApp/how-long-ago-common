namespace HowCommon.Infrastructure.Helpers;

public sealed class UserIdHelper
{
    private event EventHandler<string> OnLoggerEvent;

    public UserIdHelper(EventHandler<string> onLoggerEvent)
    {
        OnLoggerEvent = onLoggerEvent;
    }

    public bool ValidateUserId(int userId)
    {
        if (userId < 1)
        {
            OnLoggerEvent?.Invoke(this, $"Invalid User Id: {userId}");
            return false;
        }
        return true;
    }

    public bool ValidateUserId(int[] userIds)
    {
        if (userIds is null)
        {
            OnLoggerEvent?.Invoke(this,"User Id collection is invalid");
            return false;
        }

        if (userIds.Any(id => id < 1))
        {
            OnLoggerEvent?.Invoke(this,"Invalid User Id in collection");
            return false;
        }

        return true;
    }
}
