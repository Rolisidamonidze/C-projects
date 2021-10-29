using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ExpressionSolver {

   public partial class ExpressionSolver : Form {
      private string _inputText;
      private string[] _bracketlessExpressions;
      private string[] _operations = new string[] { "^", "*", "/", "+", "-" };
      private string[] _numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
      private List<string[]> bracketlessExpressionNumbers = new List<string[]>();

      public ExpressionSolver() {
         InitializeComponent();
      }

      private void btnSolve_Click(object sender, EventArgs e) {
         _inputText = _textBox.Text;
         RemoveBrackets();
         SolveExponents();
      }

      private void RemoveBrackets() {
         string[] brackets = new string[] { "(", ")" };
         _bracketlessExpressions = _inputText.Split(brackets, StringSplitOptions.RemoveEmptyEntries);
      }

      private void SolveExponents() {
      }

      private void GetBracketlessExpressionNumbers() {
         foreach (var bracketlessExpression in _bracketlessExpressions) {
            bracketlessExpressionNumbers.Add(bracketlessExpression.Split(_operations, StringSplitOptions.RemoveEmptyEntries));
         }
      }

      private void GetBracketlessExpressionOperations() {
         foreach (var bracketlessExpression in _bracketlessExpressions) {
            bracketlessExpressionNumbers.Add(bracketlessExpression.Split(_operations, StringSplitOptions.RemoveEmptyEntries));
         }
      }

      private bool ContainsOperation(string expression, char operation) => expression.Contains(operation);
   }
}