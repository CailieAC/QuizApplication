using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Models
{
    public enum QuestionType
    {
        TrueFalse,
        MultipleChoice,
        CheckBox
    }

    public class BaseQuestion
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> PossibleAnswers { get; set; }
        protected Response ExpectedResponse { get; set; }     

        public virtual bool GradeResponse(Response response)
        {
            return this.ExpectedResponse == response;
        }
    }
}
