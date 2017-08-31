using System;
using DataTemplateSelector.Models;

namespace DataTemplateSelector.ViewModels
{
    public class TextQuestionViewModel : BaseQuestionViewModel
    {
        private TextEntryQuestion textQuestion;

		public TextQuestionViewModel(TextEntryQuestion contactQuestion)
		{
			this.textQuestion = contactQuestion;
		}

		public string Response
		{
			get
			{
                return textQuestion.Response;
			}
			set
			{
				if (value != textQuestion.Response)
				{
					textQuestion.Response = value;
					RaisePropertyChanged();
				}
			}
		}

		public string Question
		{
			get
			{
                return textQuestion.Question;
			}
			set
			{
				if (value != textQuestion.Question)
				{
					textQuestion.Question = value;
					RaisePropertyChanged();
				}
			}
		}
    }
}
