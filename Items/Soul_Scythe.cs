namespace FantasyLands.Items
{
	internal class Soul_Scythe : BaseWeapon
	{
		public override string Name { get; set; }

		public Soul_Scythe() : base(4..8, 0..1, 6)
		{
			Name = "Soul_Scythe";
		}
	}
}