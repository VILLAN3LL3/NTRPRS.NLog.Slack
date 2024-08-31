using NLog.Common;

namespace VILLAN3LL3.NLog.Slack.Tests
{
    public class TestableSlackTarget : SlackTarget
    {
        public void Initialize()
        {
            InitializeTarget();
        }
        
        public new void Write(AsyncLogEventInfo eventInfo)
        {
            base.Write(eventInfo);
        }
    }
}