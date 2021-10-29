using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Domain;
using Exam.Data;

namespace Exam.Core {

  public class Process {
    public User _user;
    public Test _test;
    public Question _currentQuestion;
    private int _currentQuestionIndex = 0;
    public int _score;

    public Process() {
      ExamDataManager examDataManager = new ExamDataManager();
      UserDataManager userDataManager = new UserDataManager();
      _user = userDataManager.LoadUser();
      _test = examDataManager.LoadTest();
      _user.Test = _test;
      _currentQuestion = _test.Questions[0];
      _score = 0;
    }

    public bool Authorize(string username, string password) {
      if (username == _user.Username &&
        password == _user.Password) {
        return true;
      }
      return false;
    }

    public bool CheckAnswer(Answer answer) {
      if (answer.Equals(_currentQuestion.Correct)) {
        _score++;
        return true;
      }
      return false;
    }

    public Question GetNextQuestion() {
      if (!Finish()) {
        _currentQuestionIndex++;
        _currentQuestion = _test.Questions[_currentQuestionIndex];
        return _currentQuestion;
      }
      return null;
    }

    public bool Finish() {
      if (_currentQuestion.Equals(_test.Questions[_test.Questions.Length - 1])) {
        return true;
      }
      return false;
    }
  }
}