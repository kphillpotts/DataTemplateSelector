using System;
using DataTemplateSelector.Models;
using Xamarin.Forms;

namespace DataTemplateSelector
{
    public class FeedItemSelector : Xamarin.Forms.DataTemplateSelector
    {
		public DataTemplate TextTemplate { get; set; }
		public DataTemplate ImageTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
            if (item is FeedItemText)
                return TextTemplate;

            if (item is FeedItemImage)
                return ImageTemplate;

            throw new InvalidOperationException($"No template specified for type {item.GetType().ToString()}");
		}
    }
}
