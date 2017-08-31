using System;
using DataTemplateSelector.Models;
using DataTemplateSelector.ViewModels;
using Xamarin.Forms;

namespace DataTemplateSelector
{
    public class QuestionSelector : Xamarin.Forms.DataTemplateSelector
    {
		public DataTemplate TextTemplate { get; set; }
		public DataTemplate ContactTemplate { get; set; }
		public DataTemplate MultichoiceTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
            if (item is TextQuestionViewModel)
                return TextTemplate;

            if (item is ContactQuestionViewModel)
                return ContactTemplate;

            if (item is MultiChoiceQuestionViewModel)
                return MultichoiceTemplate;

            throw new InvalidOperationException($"No template specified for type {item.GetType().ToString()}");
		}
    }
}
