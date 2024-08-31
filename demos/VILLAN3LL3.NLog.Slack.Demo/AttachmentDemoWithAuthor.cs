using NLog;
using VILLAN3LL3.NLog.Slack.Models;

namespace VILLAN3LL3.NLog.Slack.Demo
{
    /// <summary>
    /// Demonstration of the implementation of ISlackLoggable
    /// </summary>
    public class AttachmentDemoWithAuthor : ISlackLoggable
    {

        public readonly string CustomText;

        public AttachmentDemoWithAuthor(string customText)
        {
            CustomText = customText;
        }

        public Attachment ToAttachment(LogEventInfo info)
        {
            return new Attachment
            {
                Title = "I'm a custom object",
                Text = CustomText, 
                AuthorName = "Bill Gates",
                AuthorIcon = "https://raw.githubusercontent.com/VILLAN3LL3/VILLAN3LL3.NLog.Slack/master/res/author_icon.png",
                AuthorLink = "https://fr.wikipedia.org/wiki/Bill_Gates",
                ImageUrl = "https://raw.githubusercontent.com/VILLAN3LL3/VILLAN3LL3.NLog.Slack/master/res/lenna.png",
                ThumbUrl = "https://raw.githubusercontent.com/VILLAN3LL3/VILLAN3LL3.NLog.Slack/master/res/lenna_thumb.gif",
                Color = "#FF1493" // pink is the new black
            };
        }
    }
}
