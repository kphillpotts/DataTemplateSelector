using System;
using DataTemplateSelector.Models;

namespace DataTemplateSelector.ViewModels
{
    public class ContactQuestionViewModel : BaseQuestionViewModel
    {
        private ContactQuestion contactQuestion;

        public ContactQuestionViewModel(ContactQuestion contactQuestion)
        {
            this.contactQuestion = contactQuestion;
        }

        public string FirstName
        {
            get 
            { 
                return contactQuestion.FirstName; 
            }
            set
            {
                if  (value != contactQuestion.FirstName)
                {
                    contactQuestion.FirstName = value;
                    RaisePropertyChanged();
                }
            }
        }

		public string LastName
		{
			get
			{
				return contactQuestion.LastName;
			}
			set
			{
				if (value != contactQuestion.LastName)
				{
					contactQuestion.LastName = value;
					RaisePropertyChanged();
				}
			}
		}

		public string Question
		{
			get
			{
				return contactQuestion.Question;
			}
			set
			{
				if (value != contactQuestion.Question)
				{
					contactQuestion.Question = value;
					RaisePropertyChanged();
				}
			}
		}
    }
}
