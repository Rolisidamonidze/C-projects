using System;
using System.Collections.Generic;


namespace Threading_HorseRaceGame {
	class Race {
		private List<Horse> _horses;
		private int _distance;
		private int _finished;

		public Race(int distance) {
			Console.CursorVisible = false;
			_distance = distance;
			_horses = new List<Horse>();
			_finished = 0;
		}

		public void AddHorse(Horse horse) {
			_horses.Add(horse);
		}

		public void Start() {
			foreach (var horse in _horses) {
				horse.Thread.Start();
			}
			while (FinishCheck() != _horses.Count) {
				Display();
			}
			Results();
		}

		private void Display() {
			for (int i = 1; i < _horses.Count + 1; i++) {
				Console.SetCursorPosition(0, i - 1);
				Console.Write(i);
				Console.SetCursorPosition(_distance, i - 1);
				Console.Write("|");
			}
			foreach (var horse in _horses) {
				Console.SetCursorPosition(2, horse.Row - 1);
				Console.Write(horse.Behind);
				Console.SetCursorPosition(horse.Position, horse.Row - 1);
				Console.WriteLine("-");
			}
		}

		private void Results() {
				foreach (var horse in _horses) {
				if (horse.Rating != null) {
					if(horse.Rating == 1) {
						Console.SetCursorPosition(_distance / 2, horse.Row - 1);
						Console.Write($"Winner!!!");
					}else if(horse.Rating == 2){
						Console.SetCursorPosition(_distance / 2, horse.Row - 1);
						Console.Write($"{horse.Rating}nd");
					}
					else if (horse.Rating == 3) {
						Console.SetCursorPosition(_distance / 2, horse.Row - 1);
						Console.Write($"{horse.Rating}rd");
					}
					//else {
					//	Console.SetCursorPosition(_distance / 2, horse.Row - 1);
					//	Console.Write($"Rating: {horse.Rating}");
					//}
				}
			}
		}

		private int FinishCheck() {
			foreach (var horse in _horses) {
				if (!horse.Finished && horse.Position > _distance) {
					_finished++;
					horse.Rating = _finished;
					horse.Finished = true;
				}
			}
			return _finished;
		}
	}
}