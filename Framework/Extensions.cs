namespace FantasyLands.Framework
{
	public static class Extensions
	{
		public static int Next(this Random rand, Range range)
		{
			var (offset, len) = range.GetOffsetAndLength(int.MaxValue);
			return rand.Next(len) + offset;
		}

		public static Range MakeInclusive(this Range range)
		{
			int offset = range.End.IsFromEnd ? -1 : 1;
			return new Range(range.Start, new(range.End.Value + offset, range.End.IsFromEnd));
		}
	}
}
