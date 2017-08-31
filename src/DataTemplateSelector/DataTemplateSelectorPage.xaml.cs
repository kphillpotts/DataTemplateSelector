using System.Collections.Generic;
using DataTemplateSelector.Models;
using Xamarin.Forms;

namespace DataTemplateSelector
{
    public partial class DataTemplateSelectorPage : ContentPage
    {
        public DataTemplateSelectorPage()
        {
            InitializeComponent();

            List<FeedItem> items = new List<FeedItem>();
            items.Add(new Models.FeedItemText() { Content="This is some text" });
			items.Add(new Models.FeedItemText());
            items.Add(new Models.FeedItemImage());
			items.Add(new Models.FeedItemText());
			items.Add(new Models.FeedItemImage());
			items.Add(new Models.FeedItemText());

            this.BindingContext = items;
		}
    }
}
