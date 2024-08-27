using FantasyLands.Characters;
using FantasyLands.Framework;
using FantasyLands.Items;

namespace FantasyLands;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to the Fantasy Lands battle arena, challenger!");
		Console.WriteLine("I see you brought your trusty sword- you should have no trouble dispatching 5 contest- I mean, monsters.");
		Console.WriteLine("Just a small formality before we begin- please enter your name:");

		string? name = Console.ReadLine();
		if (name is null)
			return;
		name = name.Trim().Capitalize();

		Player player = new(name, 10);
		player.CurrentWeapon = WeaponFactory.GetWeapon("sword");

		for (int round = 1; round <= 5; round++)
		{
			Monster monster = Monster.GetRandomMonster();
			if (Battle.Fight(player, monster, round))
				AwardLoot(player, monster);
			else
				Fail(player);
		}

		Utility.PromptExit($"Congratulations, {player.Name}! You won!\nWhat's that? Oh yes, you are free to go.");
	}

	static void AwardLoot(Player player, Monster monster)
	{
		IWeapon? loot = monster.GetLoot();
		if (loot is null)
			return;

		Console.WriteLine($"{monster.Name} dropped a {loot.Name}!");
		string prompt = "Would you like to equip it?";
		if (player.CurrentWeapon != null)
			prompt = $"{prompt} (Replaces your {player.CurrentWeapon.Name})";

		if (Utility.PromptYesNo(false, prompt))
			player.CurrentWeapon = loot;
	}

	static void Fail(Player player)
	{
		Utility.PromptExit($"And so, {player.Name} perished, and was forgotten in time.");
		Environment.Exit(0);
	}
}
