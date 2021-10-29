using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
   public partial class MainForm : Form {
      private Sign _currentPlayer = Sign.X;
      private Game _game;

      public MainForm() {
         InitializeComponent();
         FillBtnTags();

         _game = new Game();
      }

      private void FillBtnTags() {
         btn0.Tag = 0;
         btn1.Tag = 1;
         btn2.Tag = 2;
         btn3.Tag = 3;
         btn4.Tag = 4;
         btn5.Tag = 5;
         btn6.Tag = 6;
         btn7.Tag = 7;
         btn8.Tag = 8;
      }

      private void DisableAllBtns() {
         btn0.Enabled = false;
         btn1.Enabled = false;
         btn2.Enabled = false;
         btn3.Enabled = false;
         btn4.Enabled = false;
         btn5.Enabled = false;
         btn6.Enabled = false;
         btn7.Enabled = false;
         btn8.Enabled = false;
      }

      private void button1_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button2_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button3_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button4_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button5_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button6_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button7_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button8_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void button9_Click(object sender, EventArgs e) {
         ButtonClick(sender, e);
      }

      private void ButtonClick(object sender, EventArgs e) {
         int tag = (int)((Button)sender).Tag;
         _game.Board.Cells[tag].Sign = _currentPlayer;
         ((Button)(sender)).Text = _currentPlayer.ToString();
         ((Button)(sender)).Enabled = false;
         if (_game.CheckWin()) {
            foreach (int n in _game.WinningLine) {
               Control button = Controls.Find($"btn{n}", true).First();
               button.BackColor = Color.Green;
               lblResult.Text = _game.Winner.Value + " Wins";
            }

            DisableAllBtns();
         } else if (_game.AllCellsFilled) {
            lblResult.Text = "Draw";
         }
         ChangeActivePlayer();
      }

      private void ChangeActivePlayer() {
         if (_currentPlayer == Sign.X) {
            _currentPlayer = Sign.O;
         } else {
            _currentPlayer = Sign.X;
         }
      }
   }
}
