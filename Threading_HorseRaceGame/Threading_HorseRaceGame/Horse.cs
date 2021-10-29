using System;
using System.Threading;


namespace Threading_HorseRaceGame {
	class Horse {
		public Horse(int row) {
			Position = 2;
			Behind = "";
			Row = row;
			Thread = new Thread(Run);
		}

		public Thread Thread { get; private set; }
		public int Row { get; set; }
		public int Position { get; private set; }
		public bool Finished { get; set; }
		public int? Rating { get; set; }
		public string Behind { get; private set; }

		public void Run() {
			while (!Finished) {
				Position++;
				Behind += " ";
				Thread.Sleep(new Random().Next(20, 120));
			}
		}
	}
}
