using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace QuizApplication.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BaseQuestion> Questions { get; set; }
    }
}
