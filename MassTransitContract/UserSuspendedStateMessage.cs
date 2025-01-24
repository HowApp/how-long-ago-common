using System;

namespace HowCommon.MassTransitContract;

public class UserSuspendedStateMessage
{
    public int UserId { get; set; }
    public bool IsSuspended { get; set; }
}
