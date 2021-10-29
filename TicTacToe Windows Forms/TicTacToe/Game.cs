using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
   public class Game {
      public Board Board { get; set; } = new Board();
      public Sign? Winner { get; set; }
      public int[] WinningLine { get; set; } = new int[3];


      public bool CheckWin() {
         if (CheckHorizontal(Sign.X)) {
            Winner = Sign.X;
            return true;
         }
         if (CheckHorizontal(Sign.O)) {
            Winner = Sign.O;
            return true;
         }
         if (CheckVertical(Sign.X)) {
            Winner = Sign.X;
            return true;
         }
         if (CheckVertical(Sign.O)) {
            Winner = Sign.O;
            return true;
         }
         if (CheckDiagonal(Sign.X)) {
            Winner = Sign.X;
            return true;
         }
         if (CheckDiagonal(Sign.O)) {
            Winner = Sign.O;
            return true;
         }
         return false;
      }

      public bool AllCellsFilled => Board.Cells.Count == 9;

      private bool CheckHorizontal(Sign sign) {
         if (Board.Cells[0].Sign == sign &&
            Board.Cells[1].Sign == sign &&
            Board.Cells[2].Sign == sign) {
            WinningLine[0] = 0;
            WinningLine[1] = 1;
            WinningLine[2] = 2;

            return true;
         }
         if (Board.Cells[3].Sign == sign &&
            Board.Cells[4].Sign == sign &&
            Board.Cells[5].Sign == sign) {
            WinningLine[0] = 3;
            WinningLine[1] = 4;
            WinningLine[2] = 5;
            return true;
         }
         if (Board.Cells[6].Sign == sign &&
            Board.Cells[7].Sign == sign &&
            Board.Cells[8].Sign == sign) {
            WinningLine[0] = 6;
            WinningLine[1] = 7;
            WinningLine[2] = 8;
            return true;
         }
         return false;
      }

      private bool CheckVertical(Sign sign) {
         if (Board.Cells[0].Sign == sign &&
            Board.Cells[3].Sign == sign &&
            Board.Cells[6].Sign == sign) {
            WinningLine[0] = 0;
            WinningLine[1] = 3;
            WinningLine[2] = 6;
            return true;
         }
         if (Board.Cells[1].Sign == sign &&
            Board.Cells[4].Sign == sign &&
            Board.Cells[7].Sign == sign) {
            WinningLine[0] = 1;
            WinningLine[1] = 4;
            WinningLine[2] = 7;
            return true;
         }
         if (Board.Cells[2].Sign == sign &&
            Board.Cells[5].Sign == sign &&
            Board.Cells[8].Sign == sign) {
            WinningLine[0] = 2;
            WinningLine[1] = 5;
            WinningLine[2] = 8;
            return true;
         }
         return false;
      }

      private bool CheckDiagonal(Sign sign) {
         if (Board.Cells[0].Sign == sign &&
            Board.Cells[4].Sign == sign &&
            Board.Cells[8].Sign == sign) {
            WinningLine[0] = 0;
            WinningLine[1] = 4;
            WinningLine[2] = 8;
            return true;
         }
         if (Board.Cells[2].Sign == sign &&
            Board.Cells[4].Sign == sign &&
            Board.Cells[6].Sign == sign) {
            WinningLine[0] = 2;
            WinningLine[1] = 4;
            WinningLine[2] = 6;
            return true;
         }
         return false;
      }
   }
}
