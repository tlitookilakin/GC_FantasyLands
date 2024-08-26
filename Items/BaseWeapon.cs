using FantasyLands.Framework;

namespace FantasyLands.Items
{
	public abstract class BaseWeapon : IWeapon
	{
		protected static readonly Random random = new();

		protected Range Damage { get; init; }

		protected Range Healing { get; init; }

		protected int? Critical { get; init; }

		public abstract string Name { get; set; }

		public BaseWeapon(Range damage, Range healing, int? critical = null)
		{
			Damage = damage.MakeInclusive();
			Healing = healing.MakeInclusive();
			Critical = critical;
		}

		public BaseWeapon(int damage, Range healing, int? critical = null) : 
			this(damage..damage, healing, critical) { }

		public BaseWeapon(Range damage, int healing, int? critical = null) : 
			this(damage, healing..healing, critical) { }

		public BaseWeapon(int damage, int healing, int? critical = null) : 
			this(damage..damage, healing..healing, critical) { }

		public virtual int GetDamage()
		{
			return random.Next(Damage);
		}

		public virtual int GetHealing()
		{
			return random.Next(Healing);
		}

		public virtual bool IsCritical()
		{
			if (!Critical.HasValue)
				return false;

			return random.Next(1..11) >= Critical.Value;
		}
	}
}
