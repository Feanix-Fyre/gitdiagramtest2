namespace System.Runtime.CompilerServices;

/// <summary>A class whose static <see cref="M:System.Runtime.CompilerServices.RuntimeFeature.IsSupported(System.String)" /> method checks whether a specified feature is supported by the common language runtime.</summary>
public static class RuntimeFeature
{
	public static bool IsDynamicCodeSupported => false;
}
