using FantasyLands.Items;

namespace FantasyLands.Framework
{
	public static class WeaponFactory
	{
		public static IWeapon GetWeapon(string type)
		{
			return type.ToLowerInvariant() switch
			{
				"sword" => new Sword(),
				"dagger" => new Dagger(),
				"healing_stick" => new Healing_Stick(),
				"flame_dagger" => new Flame_Dagger(),
				"moonlit_spear" => new Moonlit_Spear(),
				"soul_scythe" => new Soul_Scythe(),
				"baguette" => new Baguette(),
				_ => throw new ArgumentException("Type not found in factory")
			};
		}
	}
}
