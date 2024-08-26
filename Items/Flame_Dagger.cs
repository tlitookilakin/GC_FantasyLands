namespace FantasyLands.Items
{
	internal class Flame_Dagger : BaseWeapon
	{
		public override string Name { get; set; }

		public Flame_Dagger() : base(3..5, 0, 8)
		{
			Name = "Flame_Dagger";
		}
	}
}