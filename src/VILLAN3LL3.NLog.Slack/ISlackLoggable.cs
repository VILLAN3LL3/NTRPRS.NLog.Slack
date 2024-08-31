using NLog;
using VILLAN3LL3.NLog.Slack.Models;

namespace VILLAN3LL3.NLog.Slack
{
    /// <summary>
    /// Implement this interface to have custom Attachment for your object
    /// </summary>
    public interface ISlackLoggable
    {
        Attachment ToAttachment(LogEventInfo info);
    }
}
