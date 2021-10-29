using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
   public class Board {
      public Board() {
         Cells = new List<Cell>();
         for (int i = 0; i < 9; i++) {
            Cells.Add(new Cell
            {
               Sign = Sign.Empty
            });
         }
      }
      public List<Cell> Cells { get; set; }
   }
}
