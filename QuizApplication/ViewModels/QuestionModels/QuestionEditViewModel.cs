using QuizApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.ViewModels.QuestionModels
{
    public class QuestionEditViewModel
    {
        public string Text { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<AnswerEditViewModel> PossibleAnswers { get; set; }
    }
}
