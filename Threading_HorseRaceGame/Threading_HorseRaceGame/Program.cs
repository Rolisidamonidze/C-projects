using System;


namespace Threading_HorseRaceGame {
	class Program {
		static void Main() {
			Race race1 = new Race(100);
			race1.AddHorse(new Horse(1));
			race1.AddHorse(new Horse(2));
			race1.AddHorse(new Horse(3));
			race1.AddHorse(new Horse(4));
			race1.AddHorse(new Horse(5));
			race1.AddHorse(new Horse(6));
			race1.AddHorse(new Horse(7));
			race1.AddHorse(new Horse(8));
			race1.AddHorse(new Horse(9));
			race1.AddHorse(new Horse(10));

			race1.Start();


			Console.ReadKey(true);
		}
	}
}
