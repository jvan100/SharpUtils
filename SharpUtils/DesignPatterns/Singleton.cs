using System;

namespace SharpUtils.DesignPatterns;

public abstract class Singleton<T> where T : Singleton<T>
{
	private static readonly object _lock = new();
	private static T? _instance;

	public static T? GetInstance(params object?[]? args)
	{
		if (_instance is null)
		{
			lock (_lock)
			{
				_instance ??= (T?)Activator.CreateInstance(typeof(T), args);
			}
		}

		return _instance;
	}
}