namespace FantasyLands.Items
{
	internal class Moonlit_Spear : BaseWeapon
	{
		public override string Name { get; set; }

		public Moonlit_Spear() : base(3, 2)
		{
			Name = "Moonlit_Spear";
		}
	}
}