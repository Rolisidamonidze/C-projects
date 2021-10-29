using Exam.Core;
using Exam.Domain;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exam.Client {

  public partial class ExamForm : Form {
    private Core.Process _process;
    private Answer _chosenAnswer;
    private AnswerButton _correctButton;
    private List<AnswerButton> _otherButtons;
    private Button _checkButton;
    private Button _nextButton;

    public ExamForm() {
      InitializeComponent();
      _process = new Process();
      _otherButtons = new List<AnswerButton>();
      Display();
    }

    private void Display() {
      DisplayQuestion();
      AddAnswerButtons();
      AddCheckButton();
      AddNextButton();
    }

    private void DisplayQuestion() {
      Controls.Add(new Label() {
        Text = Question().Text,
        Size = new Size(600, 30),
        Font = new Font(new FontFamily("Helvetica"), 16),
      });
    }

    private AnswerButton AnswerButton(int i, int position) {
      return new AnswerButton() {
        Answer = Answers()[i],
        Text = Answers()[i].Text,
        Size = new Size(200, 50),
        AutoSizeMode = AutoSizeMode.GrowAndShrink,
        Font = new Font(new FontFamily("Helvetica"), 16),
        Location = new Point(300, position),
      };
    }

    private void AddAnswerButtons() {
      int position = 100;
      for (int i = 0; i < Answers().Length; i++) {
        if (Answers()[i].Equals(Question().Correct)) {
          _correctButton = AnswerButton(i, position);

          _correctButton.Click += (s, e) => {
            _correctButton.BackColor = Color.DarkOrange;
            _chosenAnswer = ((AnswerButton)s).Answer;
          };
          _correctButton.LostFocus += (s, e) => {
            _correctButton.BackColor = Color.Transparent;
          };
          Controls.Add(_correctButton);
        }
        else {
          _otherButtons.Add(AnswerButton(i, position));
        }
        foreach (var button in _otherButtons) {
          button.Click += (s, e) => {
            button.BackColor = Color.DarkOrange;
            _chosenAnswer = ((AnswerButton)s).Answer;
          };
          button.LostFocus += (s, e) => {
            button.BackColor = Color.Transparent;
          };
          Controls.Add(button);
        }
        position += 60;
      }
    }

    private void DisableButtons() {
      _correctButton.Enabled = false;
      foreach (var button in _otherButtons) {
        button.Enabled = false;
      }
    }

    private void EnableButtons() {
      _correctButton.Enabled = true;
      foreach (var button in _otherButtons) {
        button.Enabled = true;
      }
    }

    private void AddCheckButton() {
      _checkButton = CheckAndNextButton("სწორი პასუხი");
      _checkButton.Click += (s, e) => {
        if (_chosenAnswer != null) {
          if (_process.CheckAnswer(_chosenAnswer)) {
            _correctButton.BackColor = Color.Green;
          }
          else {
            _correctButton.BackColor = Color.Red;
          }
          DisableButtons();
          _checkButton.Hide();
          _nextButton.Show();
        }
      };
      Controls.Add(_checkButton);
    }

    private void AddNextButton() {
      _nextButton = CheckAndNextButton("შემდეგი");
      _nextButton.Click += (s, e) => {
        _chosenAnswer = null;
        _otherButtons = new List<AnswerButton>();
        _checkButton = null;
        Controls.Clear();
        if (!Finished()) {
          NextQuestion();
          Display();
        }
        else {
          Controls.Add(new Label() {
            Text = Result(),
            Font = new Font(new FontFamily("Helvetica"), 16),
            Location = new Point(200, 200),
            ForeColor = Color.Blue,
          });
        }
      };
      Controls.Add(_nextButton);
    }

    private Button CheckAndNextButton(string text) {
      return new Button() {
        Text = text,
        Size = new Size(200, 50),
        Font = new Font(new FontFamily("Helvetica"), 16),
        Location = new Point(550, 380),
      };
    }

    private Question Question() {
      return _process._currentQuestion;
    }

    private void NextQuestion() {
      _process.GetNextQuestion();
    }

    private bool Finished() {
      return _process.Finish();
    }

    public string Result() {
      return $"ტესტი დასრულდა";
      //{_process._score}  / {_process._test.Questions.Length}
    }

    private Answer[] Answers() {
      return Question().Answers;
    }

    private void ExamForm_FormClosing(object sender, FormClosingEventArgs e) {
      var result = Dialog.ExitDialog();
      if (result == DialogResult.No) {
        e.Cancel = true;
      }
    }
  }
}