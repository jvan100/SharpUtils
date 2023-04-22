using System;

namespace SharpUtils;

public static class IntUtils
{
	public static string ToBinaryString(this int source) => source.ToStringOfBase(2);
	
	public static string ToPaddedBinaryString(this int source, int totalLength) => source.ToBinaryString().PadLeft(totalLength, '0');
	
	public static string ToStringOfBase(this int source, int toBase) => Convert.ToString(source, toBase);
}