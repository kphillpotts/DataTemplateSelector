using System;
namespace DataTemplateSelector.Models
{
    public class MultiChoiceQuestion : BaseQuestion
    {
		public string Option1Text { get; set; }
		public bool Option1Value { get; set; }

		public string Option2Text { get; set; }
		public bool Option2Value { get; set; }

		public string Option3Text { get; set; }
		public bool Option3Value { get; set; }
    }
}
