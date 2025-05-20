namespace System.Runtime.InteropServices;

/// <summary>Provides information about the .NET runtime installation.</summary>
public static class RuntimeInformation
{
	private static readonly Architecture _osArchitecture;

	private static readonly Architecture _processArchitecture;

	private static readonly OSPlatform _osPlatform;

	static RuntimeInformation()
	{
	}

	private static string GetRuntimeArchitecture()
	{
		return null;
	}

	private static string GetOSName()
	{
		return null;
	}

	/// <summary>Indicates whether the current application is running on the specified platform.</summary>
	/// <param name="osPlatform">A platform.</param>
	/// <returns>
	///   <see langword="true" /> if the current app is running on the specified platform; otherwise, <see langword="false" />.</returns>
	public static bool IsOSPlatform(OSPlatform osPlatform)
	{
		return false;
	}
}
