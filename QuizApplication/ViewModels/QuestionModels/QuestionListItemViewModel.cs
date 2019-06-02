using QuizApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.ViewModels.QuestionModels
{
    public class QuestionListItemViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<AnswerListItemViewModel> PossibleAnswers { get; set; }
    }
}
