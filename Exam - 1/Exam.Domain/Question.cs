using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain {

  public class Question {
    public Answer[] Answers { get; set; }
    public string Text { get; set; }
    public Answer Correct { get; set; }
  }
}