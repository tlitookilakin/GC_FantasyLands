namespace FantasyLands.Items
{
	internal class Sword : BaseWeapon
	{
		public override string Name { get; set; }

		public Sword() : base(2..4, 0)
		{
			Name = "Sword";
		}
	}
}
