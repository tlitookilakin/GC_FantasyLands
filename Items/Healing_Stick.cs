namespace FantasyLands.Items
{
	internal class Healing_Stick : BaseWeapon
	{
		public override string Name { get; set; }

		public Healing_Stick() : base(2, 2, 9)
		{
			Name = "Healing_Stick";
		}
	}
}
