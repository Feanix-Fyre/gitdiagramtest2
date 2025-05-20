namespace System.Threading;

internal static class ThreadPoolGlobals
{
	public static int processorCount;

	public static bool vmTpInitialized;

	public static bool enableWorkerTracking;

	public static readonly ThreadPoolWorkQueue workQueue;
}
