using System;
using System.Windows.Forms;

namespace EquationSolverApp {
	public partial class EquationSolverApp : Form {
		private string[] _operations = new string[] { "*", "/", "+", "-" };
		private char[] _operationChars = new char[] { '*', '/', '+', '-' };
		private char[] _numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
		private string[] _currentOperations;
		private string _expressionString;
		private string _simpleExpression;
		private int _openBracketIndex;
		private int _closeBracketIndex;
		private string[] _currentNumbers;
		bool _solved = false;
		public EquationSolverApp() {
			InitializeComponent();
		}

		private void solveButton_Click(object sender, EventArgs e) {
			_expressionString = equationInput.Text;
			while (!_solved) {
				_simpleExpression = FindSimpleEquation();
				_expressionString = _expressionString.Replace(_simpleExpression, SimpleExpressionSolve(_simpleExpression));
			}
			result.Text = _expressionString;
			_solved = false;
		}

		private string FindSimpleEquation() {
			if (ContainsBracket()) {
				FindOpenBracketIndex();
				FindCloseBracketIndex();
				_simpleExpression = _expressionString.Substring(_openBracketIndex, _closeBracketIndex - _openBracketIndex + 1);
			}
			else {
				_simpleExpression = _expressionString;
				_solved = true;
			}
			return _simpleExpression;
		}

		private bool ContainsBracket() {
			if (_expressionString.Contains("(")) {
				return true;
			}
			return false;
		}

		private void FindOpenBracketIndex() {
			for (int i = 0; i < _expressionString.Length; i++) {
				if (_expressionString[i] == '(') {
					_openBracketIndex = i;
				}
			}
		}

		private void FindCloseBracketIndex() {
			for (int i = _openBracketIndex; i < _expressionString.Length; i++) {
				if (_expressionString[i] == ')') {
					_closeBracketIndex = i;
					break;
				}
			}
		}

		private string SimpleExpressionSolve(string expression) {
			expression = expression.Trim('(', ')');
			for (int i = 0; i < 2; i++) {
				while (expression.Contains(_operations[i])) {
					double.TryParse(NumberBeforeOperation(expression, _operations[i]), out double x);
					double.TryParse(NumberAfterOperation(expression, _operations[i]), out double y);
					if (NumberBeforeOperation(expression, _operations[i]) == "") {
						break;
					}
					string old = string.Concat(x, _operations[i], y);
					double result = MatchOperation(_operations[i], x, y);
					expression = expression.Replace(old, result.ToString());
				}
			}

			//_currentNumbers = expression.Split('+', '-');
			//_currentOperations = expression.Split(_numbers, '.');

			//double num = 0;
			//for (int i = 0; i < _currentNumbers.Length; i++) {
			//	if (_currentOperations[i] == "i") {
			//		num = _currentNumbers[i] + _currentNumbers[i + 1];
			//	}
			//}

			return expression;
		}

		private string NumberAfterOperation(string text, string operation) {
			string numberAfterOperation = "";
			for (int i = text.IndexOf(operation) + 1; i < text.Length; i++) {
				if (char.IsDigit(text[i]) || text[i] == '.') {
					numberAfterOperation += text[i];
				}
				else {
					break;
				}
			}
			return numberAfterOperation;
		}

		private string NumberBeforeOperation(string text, string operation) {
			string numberBeforeOperation = "";
			for (int i = text.IndexOf(operation) - 1; i > -1; i--) {
				if (char.IsDigit(text[i]) || text[i] == '.') {
					numberBeforeOperation = numberBeforeOperation.Insert(0, text[i].ToString());
				}
				else {
					break;
				}
			}
			return numberBeforeOperation;
		}

		private double MatchOperation(string operation, double x, double y) {
			switch (operation) {
				case "*": return x * y;
				case "/": return x / y;
				case "+": return x + y;
				case "-": return x - y;
				default: throw new Exception("Invalid Operation");
			}
		}
	}
}
