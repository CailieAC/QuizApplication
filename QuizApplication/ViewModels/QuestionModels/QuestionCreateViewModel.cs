using QuizApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.ViewModels.QuestionModels
{
    public class QuestionCreateViewModel
    {
        public string Text { get; set; }
        public QuestionType QuestionType { get; set; }
    }
}
