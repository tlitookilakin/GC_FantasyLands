using FantasyLands.Characters;

namespace FantasyLands.Framework
{
	internal static class Battle
	{
		public static bool Fight(Character hero, Character enemy, int round)
		{
			Console.Clear();
			Console.WriteLine($"Round {round}: {enemy.Name}!\n");
			Console.WriteLine("Press any key when ready.");

			Console.ReadKey();
			Console.Clear();
			Console.WriteLine($"Round {round}: {enemy.Name}!\n");
			Console.WriteLine("\tBEGIN!\n");

			while (hero.Health > 0 && enemy.Health > 0)
			{
				Console.WriteLine($"{hero.Name}: {hero.Health} HP \t {enemy.Name}: {enemy.Health} HP");

				Strike(hero, enemy);
				Strike(enemy, hero);

				Console.WriteLine("Press enter to continue");
				Console.ReadLine();
			}

			return hero.Health > 0;
		}

		private static void Strike(Character attacker, Character defender)
		{
			Console.WriteLine($"{attacker.Name} strikes {defender.Name}!");

			int damage = Math.Max(0, attacker.GetDamage());

			if (damage > 0)
				Console.WriteLine($"{defender.Name} takes {damage} damage!");
			else
				Console.WriteLine($"{attacker.Name} couldn't scratch {defender.Name}!");

			defender.TakeDamage(damage);

			if (defender.Health > 0)
				Console.WriteLine($"{defender.Name} has {defender.Health} HP remaining!");
			else
				Console.WriteLine($"{defender.Name} is down for the count!");

			if (attacker is Player player)
			{
				int healing = player.GetHealing();
				string weaponName = player.CurrentWeapon?.Name ?? "bare hands";
				if (healing > 0)
					Console.WriteLine($"{attacker.Name} revitalized themselves with their {weaponName} and gained {healing} HP!");
			}
		}
	}
}
