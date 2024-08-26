namespace FantasyLands.Items
{
	internal class Dagger : BaseWeapon
	{
		public override string Name { get; set; }

		public Dagger() : base(1..3, 0, 7)
		{
			Name = "Dagger";
		}
	}
}