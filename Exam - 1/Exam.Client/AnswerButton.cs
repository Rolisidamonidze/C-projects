using Exam.Domain;
using System.Windows.Forms;

namespace Exam.Client {
  class AnswerButton : Button {
    public Answer Answer { get; set; }
    public bool IsCorrect { get; set; }
  }
}
