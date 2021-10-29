using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator {
	internal class Calculator : Form {
		private const int WIDTH = 336;
		private const int HEIGHT = 440;
		private const int BUTTON_HEIGHT = 60;
		private const int BUTTON_WIDTH = 80;
		private List<MyButton> _buttons;
		private RichTextBox _screen;
		private RichTextBox _operation;
		private int _screenHeight;
		private string _currentOperation;
		private bool _operationIsClicked = false;
		private double? _firstNumber;
		private double? _secondNumber;

		public Calculator() {
			Application.EnableVisualStyles();
			MaximizeBox = false;
			Size = new Size(WIDTH, HEIGHT);
			BackColor = Color.FromArgb(106, 90, 205);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Render();
		}

		public void Render() {
			AddScreen();
			AddButtons();
			NameButtons();
			SetPositions();
			AddFunctions();
			_screen.Text = "0";
			_screen.SelectionStart = _screen.Text.Length;
		}
		private void Clear(object sender, EventArgs e) {
			_firstNumber = null;
			_secondNumber = null;
			_screen.Text = "0";
			_operation.Text = "";
		}
		private void DisplayButtonText(object sender, EventArgs e) {
			if (_screen.Text[0] == '0') {
				_screen.Text = ((MyButton)sender).Text;
			}
			else if (!_operationIsClicked) {
				_screen.Text += ((MyButton)sender).Text;
			}
			else {
				_screen.Text = "";
				_screen.Text += ((MyButton)sender).Text;
				_operationIsClicked = false;
			}
		}
		private void Sum(object sender, EventArgs e) {
			if (!_operationIsClicked) {
				MakeOperation(sender, e);
			}
		}
		private void Substract(object sender, EventArgs e) {
			if (!_operationIsClicked) {
				MakeOperation(sender, e);
			}
		}
		private void Multiply(object sender, EventArgs e) {
			if (!_operationIsClicked) {
				MakeOperation(sender, e);
			}
		}
		private void Divide(object sender, EventArgs e) {
			if (!_operationIsClicked) {
				MakeOperation(sender, e);
			}
		}
		private void Remainder(object sender, EventArgs e) {
			if (!_operationIsClicked) {
				MakeOperation(sender, e);
			}
		}
		private void Negate(object sender, EventArgs e) {
			double.TryParse(_screen.Text, out double n);
			_screen.Text = (-n).ToString();
		}
		private void Backspace(object sender, EventArgs e) {
			if (_screen.Text.Length > 1) {
				_screen.Text = _screen.Text.Substring(0, _screen.Text.Length - 1);
			}
			else if (_screen.Text.Length == 1) {
				_screen.Text = "0";
			}
		}
		private void FloatPointControl(object sender, EventArgs e) {
			if (!_screen.Text.Contains(".") && !_operationIsClicked) {
				DisplayButtonText(sender, e);
			}
		}
		private void MakeOperation(object sender, EventArgs e) {
			_operation.Text = ((MyButton)sender).Text;
			double.TryParse(_screen.Text, out double parsedNumber);
			if (_firstNumber == null) {
				_firstNumber = parsedNumber;
				_currentOperation = ((MyButton)sender).Text;
			}
			else {
				_secondNumber = parsedNumber;
				_firstNumber = MyExtension.Operator(_currentOperation, _firstNumber, _secondNumber);
				_secondNumber = null;
				_screen.Text = _firstNumber.ToString();
				_currentOperation = ((MyButton)sender).Text;
			}
			_operationIsClicked = true;
		}

		public void EqualOperation(object sender, EventArgs e) {
			if (!_operationIsClicked) {
				MakeOperation(sender, e);
			}
		}

		public void AddScreen() {
			_screen = new RichTextBox {
				BackColor = Color.FromArgb(187, 191, 202),
				Height = 60,
				Location = new Point(0, 0),
				BorderStyle = BorderStyle.None
			};
			_operation = new RichTextBox {
				BackColor = Color.FromArgb(187, 191, 202),
				Height = 40,
				Location = new Point(0, 60),
				BorderStyle = BorderStyle.None
			};
			_screenHeight = _screen.Height + _operation.Height;
			_screen.Size = new Size(4 * BUTTON_WIDTH, _screen.Height);
			_operation.Size = new Size(4 * BUTTON_WIDTH, _operation.Height);
			_screen.SelectionAlignment = HorizontalAlignment.Right;
			_operation.SelectionAlignment = HorizontalAlignment.Right;
			_screen.Font = new Font("Helvetica", 35, FontStyle.Bold, GraphicsUnit.Point);
			_operation.Font = new Font("Helvetica", 25, FontStyle.Bold, GraphicsUnit.Point);
			Controls.Add(_screen);
			Controls.Add(_operation);
		}
		public void AddButtons() {
			_buttons = new List<MyButton>();
			for (int i = 0; i < 20; i++) {
				_buttons.Add(new MyButton());
				Controls.Add(_buttons[i]);
			}
		}
		public void AddFunctions() {
			for (int i = 0; i < 20; i++) {
				if (i == 0) {
					_buttons[i].Click += Remainder;
				}
				else if (i == 1) {
					_buttons[i].Click += Clear;
				}
				else if (i == 2) {
					_buttons[i].Click += Backspace;
				}
				else if (i == 3) {
					_buttons[i].Click += Sum;
				}
				else if (i == 7) {
					_buttons[i].Click += Substract;
				}
				else if (i == 11) {
					_buttons[i].Click += Multiply;
				}
				else if (i == 15) {
					_buttons[i].Click += Divide;
				}
				else if (i == 16) {
					_buttons[i].Click += Negate;
				}
				else if(i == 18) {
					_buttons[i].Click += FloatPointControl;
				}
				else if (i == 19) {
					_buttons[i].Click += EqualOperation;
				}
				else {
					_buttons[i].Click += DisplayButtonText;
				}
			}
		}
		public void SetPositions() {
			int x = 0;
			int y = _screenHeight;
			for (int i = 0; i < _buttons.Count; i++) {
				_buttons[i].Location = new Point(x, y);
				x += BUTTON_WIDTH;
				if (x >= 4 * BUTTON_WIDTH) {
					y += BUTTON_HEIGHT;
					x = 0;
				}
			}
		}
		public void NameButtons() {
			_buttons[0].Text = "%";
			_buttons[1].Text = "C";
			_buttons[2].Text = "⌫";
			_buttons[3].Text = "+";
			_buttons[4].Text = "7";
			_buttons[5].Text = "8";
			_buttons[6].Text = "9";
			_buttons[7].Text = "-";
			_buttons[8].Text = "4";
			_buttons[9].Text = "5";
			_buttons[10].Text = "6";
			_buttons[11].Text = "*";
			_buttons[12].Text = "1";
			_buttons[13].Text = "2";
			_buttons[14].Text = "3";
			_buttons[15].Text = "/";
			_buttons[16].Text = "±";
			_buttons[17].Text = "0";
			_buttons[18].Text = ".";
			_buttons[19].Text = "=";
		}

		private class MyButton : Button {
			public MyButton() {
				Height = BUTTON_HEIGHT;
				Width = BUTTON_WIDTH;
				BackColor = Color.FromArgb(238, 238, 238);
				Font = new Font("Helvetica", 10, FontStyle.Bold, GraphicsUnit.Point);
			}
		}
	}
	public static class MyExtension {
		public static double? Operator(this string logic, double? x, double? y) {
			switch (logic) {
				case "+": return x + y;
				case "-": return x - y;
				case "*": return x * y;
				case "/": return x / y;
				case "%": return x % y;
				default: throw new Exception("invalid logic");
			}
		}
	}
}




