using QuizApplication.ViewModels.QuestionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.ViewModels.QuizModels
{
    public class QuizEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<QuestionListItemViewModel> Questions { get; set; }
    }
}
