using System;
using Porsche;

namespace Events {
	class Program {
		static void Main() {
			Porsche911 porsche911 = new Porsche911();

			for (int i = 0; i < 20; i++) {
				porsche911.Accelerate(20);
				Console.ReadKey(true);
			}
		}
	}
}
