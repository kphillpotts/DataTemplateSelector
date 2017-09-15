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
            this.BindingContext = CreateQuestions();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        ObservableCollection<BaseQuestionViewModel> CreateQuestions()
        {
            // dummy up some questions
            ObservableCollection<BaseQuestionViewModel> questions = new ObservableCollection<BaseQuestionViewModel>
            {
                new ContactQuestionViewModel(new Models.ContactQuestion()
                {
                    Question = "Your Name",
                }),

                new MultiChoiceQuestionViewModel(new Models.MultiChoiceQuestion()
                {
                    Question = "Languages spoken?",
                    Option1Text = "German",
                    Option2Text = "Spanish",
                    Option3Text = "Other"
                }),

                new ContactQuestionViewModel(new Models.ContactQuestion()
                {
                    Question = "Partners Name",
                }),

                new ContactQuestionViewModel(new Models.ContactQuestion()
                {
                    Question = "Mothers Name",
                }),

                new TextQuestionViewModel(new Models.TextEntryQuestion()
                {
                    Question = "Tell me about your mother?",
                }),
                new ContactQuestionViewModel(new Models.ContactQuestion()
                {
                    Question = "Fathers Name",
                }),

                new TextQuestionViewModel(new Models.TextEntryQuestion()
                {
                    Question = "Tell me about your father?",
                })
            };

            return questions;
        }
    }
}
