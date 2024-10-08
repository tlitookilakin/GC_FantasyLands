﻿namespace FantasyLands.Framework
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

		public static T? SelectFrom<T>(this Random rand, IReadOnlyList<T> items)
		{
			if (items.Count == 0)
				return default;

			return items[rand.Next(items.Count)];
		}

		public static string Capitalize(this string str)
			=> str is null || str.Length == 0 ? "" : char.ToUpper(str[0]) + str[1..];
	}
}
