using System;
namespace DataTemplateSelector.Models
{
    public class FeedItem
    {
        public FeedItem()
        {
        }

        public string Title
        {
            get;
            set;
        }

        public FeedItemType ItemType
        {
            get;set;
        }
    }
}
