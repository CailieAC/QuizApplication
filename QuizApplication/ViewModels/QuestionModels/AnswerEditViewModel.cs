namespace QuizApplication.ViewModels.QuestionModels
{
    public class AnswerEditViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public bool IsExpectedAnswer { get; set; }
    }
}