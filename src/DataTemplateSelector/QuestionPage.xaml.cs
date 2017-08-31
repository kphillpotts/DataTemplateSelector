using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DataTemplateSelector.ViewModels;
using Xamarin.Forms;

namespace DataTemplateSelector
{
    public partial class QuestionPage : ContentPage
    {
        public QuestionPage()
        {
            InitializeComponent();

            ObservableCollection<BaseQuestionViewModel> questions = new ObservableCollection<BaseQuestionViewModel>();

            questions.Add(
                new ContactQuestionViewModel(new Models.ContactQuestion()
                {
                    Question = "Your Name",
                }));

			questions.Add(
			new MultiChoiceQuestionViewModel(new Models.MultiChoiceQuestion()
			{
				Question = "Languages spoken?",
				Option1Text = "German",
				Option2Text = "Spanish",
				Option3Text = "Other"
			}));

            questions.Add(
		    new ContactQuestionViewModel(new Models.ContactQuestion()
		    {
		        Question = "Partners Name",
		    }));

            questions.Add(
		    new ContactQuestionViewModel(new Models.ContactQuestion()
		    {
		        Question = "Mothers Name",
		    }));

			questions.Add(
			new TextQuestionViewModel(new Models.TextEntryQuestion()
			{
			    Question = "Tell me about your mother?",
			}));
            questions.Add(
			new ContactQuestionViewModel(new Models.ContactQuestion()
			{
			    Question = "Fathers Name",
			}));

			questions.Add(
			new TextQuestionViewModel(new Models.TextEntryQuestion()
			{
                Question = "Tell me about your father?",
			}));



            this.BindingContext = questions;
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }
    }
}
