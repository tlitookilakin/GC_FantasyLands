namespace FantasyLands.Characters
{
	public abstract class Character
	{
		public virtual string Name { get; set; }
		public virtual int Health { get; set; }

		public Character(string name, int health)
		{
			Name = name;
			Health = health;
		}

		public abstract int GetDamage();
		public abstract void TakeDamage(int damage);
	}
}
