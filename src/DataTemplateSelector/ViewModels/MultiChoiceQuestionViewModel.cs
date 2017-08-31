using System;
using DataTemplateSelector.Models;

namespace DataTemplateSelector.ViewModels
{
    public class MultiChoiceQuestionViewModel : BaseQuestionViewModel
    {
        MultiChoiceQuestion question;
        public MultiChoiceQuestionViewModel(MultiChoiceQuestion question)
        {
            this.question = question;
        }

		public string Question
		{
			get
			{
				return question.Question;
			}
			set
			{
				if (value != question.Question)
				{
					question.Question = value;
					RaisePropertyChanged();
				}
			}
		}

		public string Option1Text
		{
			get
			{
                return question.Option1Text;
			}
			set
			{
				if (value != question.Option1Text)
				{
					question.Option1Text = value;
					RaisePropertyChanged();
				}
			}
		}

		public bool Option1Value
		{
			get
			{
				return question.Option1Value;
			}
			set
			{
				if (value != question.Option1Value)
				{
					question.Option1Value = value;
					RaisePropertyChanged();
				}
			}
		}

		public string Option2Text
		{
			get
			{
				return question.Option2Text;
			}
			set
			{
				if (value != question.Option2Text)
				{
					question.Option2Text = value;
					RaisePropertyChanged();
				}
			}
		}

		public bool Option2Value
		{
			get
			{
				return question.Option2Value;
			}
			set
			{
				if (value != question.Option2Value)
				{
					question.Option2Value = value;
					RaisePropertyChanged();
				}
			}
		}

		public string Option3Text
		{
			get
			{
				return question.Option3Text;
			}
			set
			{
				if (value != question.Option3Text)
				{
					question.Option3Text = value;
					RaisePropertyChanged();
				}
			}
		}

		public bool Option3Value
		{
			get
			{
				return question.Option3Value;
			}
			set
			{
				if (value != question.Option3Value)
				{
					question.Option3Value = value;
					RaisePropertyChanged();
				}
			}
		}
    }
}
