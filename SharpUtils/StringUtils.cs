using System;
using System.Collections.Generic;

namespace SharpUtils;

public static class StringUtils
{
	public static IEnumerable<string> ChunksUpTo(this string source, int maxChunkSize)
	{
		for (int i = 0; i < source.Length; i += maxChunkSize)
		{
			yield return source.Substring(i, Math.Min(maxChunkSize, source.Length - i));
		}
	}
}