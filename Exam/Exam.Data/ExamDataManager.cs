using System;
using Exam.Domain;

namespace Exam.Data {

  public class ExamDataManager : DataManager<int, Test> {

    public ExamDataManager() : base(FileManager.Exams) {
    }

    #region Question Methods

    public void AddQuestion(Question question, Test targetExam) {
      targetExam.Questions.Add(question);
    }

    public void EditQuestion(Question question, Test targetExam) {
      if (FindQuestion(question.ID, targetExam) != null) {
        RemoveQuestion(question, targetExam);
        targetExam.Questions.Add(question);
      }
    }

    public void RemoveQuestion(Question question, Test targetExam) {
      targetExam.Questions.Remove(question);
    }

    public Question FindQuestion(int QuestionID, Test targetExam) {
      foreach (var question in targetExam.Questions) {
        if (question.ID.Equals(QuestionID)) {
          return question;
        }
      }
      return default;
    }

    #endregion Question Methods

    #region Answer Methods

    public void AddAnswer(Answer answer, Question targetQuestion) {
      targetQuestion.Answers.Add(answer);
    }

    public void RemoveAnswer(int answerID, Question targetQuestion) {
      targetQuestion.Answers.Remove(FindAnswer(answerID, targetQuestion));
    }

    public void EditAnswer(Answer answer, Question targetQuestion) {
      if (FindAnswer(answer.ID, targetQuestion) != null) {
        RemoveAnswer(answer.ID, targetQuestion);
        targetQuestion.Answers.Add(answer);
      }
    }

    public Answer FindAnswer(int answerID, Question targetQuestion) {
      foreach (var answer in targetQuestion.Answers) {
        if (answer.ID.Equals(answerID)) {
          return answer;
        }
      }
      return default;
    }

    #endregion Answer Methods
  }
}