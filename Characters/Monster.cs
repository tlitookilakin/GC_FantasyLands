using FantasyLands.Framework;
using FantasyLands.Items;

namespace FantasyLands.Characters
{
	internal class Monster : Character
	{
		public int MaxDamage { get; set; }
		public int MinDamage { get; set; }
		public List<string> Loot { get; set; }

		public Monster(string name, int health, int minDamage, int maxDamage, List<string> loot) : base(name, health)
		{
			Loot = loot;
			MaxDamage = maxDamage;
			MinDamage = minDamage;
		}

		public Monster(Monster copyFrom) : this(copyFrom.Name, copyFrom.Health, copyFrom.MinDamage, copyFrom.MaxDamage, copyFrom.Loot)
		{

		}

		public override int GetDamage()
		{
			return random.Next(MinDamage, MaxDamage + 1);
		}

		public override void TakeDamage(int damage)
		{
			Health -= damage;
		}

		public IWeapon? GetLoot()
		{
			string? drop = random.SelectFrom(Loot);
			if (drop == null)
				return null;
			return WeaponFactory.GetWeapon(drop);
		}

		#region static

		private static readonly Random random = new();

		public static List<Monster> Monsters = [
			new("Goblin", 4, 1, 3, ["Sword", "Dagger", "Baguette"]),
			new("Chef", 2, 1, 1, ["Baguette"]),
			new("Theif", 5, 2, 4, ["Dagger", "Flame Dagger"]),
			new("Wizard", 5, 2, 6, ["Healing_Stick", "Baguette"]),
			new("Fighter", 7, 3, 5, ["Sword", "Dagger", "Flame_Dagger", "Moonlit_Spear"]),
			new("Reaper", 10, 4, 8, ["Soul_Scythe"])
		];

		public static Monster GetRandomMonster()
		{
			Monster which = random.SelectFrom(Monsters)!;
			return new Monster(which);
		}

		#endregion static
	}
}
