namespace HowCommon.Infrastructure.Services;

public abstract class AbstractSharedUserService
{
    protected event EventHandler<string> OnLoggerEvent;

    protected AbstractSharedUserService(EventHandler<string> onLoggerEvent)
    {
        OnLoggerEvent = onLoggerEvent;
    }

    protected bool ValidateUserId(int userId)
    {
        if (userId < 1)
        {
            OnLoggerEvent?.Invoke(this, $"Invalid User Id: {userId}");
            return false;
        }
        return true;
    }

    protected bool ValidateUserId(int[] userIds)
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
