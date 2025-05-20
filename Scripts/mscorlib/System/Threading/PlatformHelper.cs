namespace System.Threading;

internal static class PlatformHelper
{
	private static int s_processorCount;

	private static int s_lastProcessorCountRefreshTicks;

	internal static readonly bool IsSingleProcessor;

	internal static int ProcessorCount => 0;
}
