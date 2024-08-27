using FantasyLands.Items;

namespace FantasyLands.Characters
{
	internal class Player : Character
	{
		public IWeapon? CurrentWeapon { get; set; }

		public Player(string name, int health) : base(name, health)
		{
		}

		public override int GetDamage()
		{
			if (CurrentWeapon == null)
				return 1;
			return CurrentWeapon.GetDamage();
		}

		public override void TakeDamage(int damage)
		{
			Health -= damage;
		}

		public int GetHealing()
		{
			int healing = CurrentWeapon is null ? 0 : CurrentWeapon.GetHealing();
			Health += healing;
			return healing;
		}
	}
}
