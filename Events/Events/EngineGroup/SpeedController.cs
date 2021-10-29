using System;

namespace EngineGroup {
	internal class SpeedController {
		private Action<int>_speedAlert;
		private int _currentSpeed;
		public SpeedController() {
			MaxSpeed = new Random().Next(100, 150);
		}

		public event Action<int> OnSpeedExceed {
			add {
				Console.WriteLine("Subscribe");
				_speedAlert += value;
			}
			remove {
				Console.WriteLine("Unsubscribe");
				_speedAlert -= value;
			}
		}

		public int MaxSpeed { get; private set; }
		public int ExceededSpeed { 
			get {
				return _currentSpeed - MaxSpeed;
			} 
		}
		public int CurrentSpeed {
			get => _currentSpeed;
			set {
				_currentSpeed = value;
				if (value > MaxSpeed) {
					if (_speedAlert != null) {
						_speedAlert(ExceededSpeed);
					}
					else {
						Warning();
					}
				}
			}
		}

		private void Warning() {
			Console.WriteLine("Slow down!");
		}
	}
}
