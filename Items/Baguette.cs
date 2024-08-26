namespace FantasyLands.Items
{
	internal class Baguette : BaseWeapon
	{
		public override string Name { get; set; }

		public Baguette() : base(1, 2..8)
		{
			Name = "Baguette";
		}
	}
}