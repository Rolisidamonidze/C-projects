using EngineGroup;
using System;

namespace Porsche {
	internal class Porsche911 {
		private const int MAX_SPEED = 320;
		private SpeedController _speedController;
		private int _currentSpeed;

		public Porsche911() {
			_speedController = new SpeedController();
			_speedController.OnSpeedExceed += Warning;
		}

		public void Accelerate(int kmh) {
			if (_currentSpeed + kmh < MAX_SPEED) {
				_currentSpeed += kmh;
			}
			else {
				_currentSpeed = MAX_SPEED;
			}
			_speedController.CurrentSpeed = this._currentSpeed;
			Console.WriteLine($"Current speed: {_currentSpeed}");
		}
		public string Model => "Porsche 911";
		public void Warning(int exceededSpeed) {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Slow down! You exceeded by {exceededSpeed}kmph");
			Console.ResetColor();
		}
	}
}
