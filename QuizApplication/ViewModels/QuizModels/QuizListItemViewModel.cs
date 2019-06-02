using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.ViewModels.QuizModels
{
    public class QuizListItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuestionNumber { get; set; }
        public string CreatedBy { get; set; }
    }
}
