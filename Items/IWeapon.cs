namespace FantasyLands.Items
{
	public interface IWeapon
	{
		public string Name { get; set; }

		public int GetDamage();

		public int GetHealing();

		public bool IsCritical();
	}
}
