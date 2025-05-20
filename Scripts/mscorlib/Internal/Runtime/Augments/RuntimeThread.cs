using System.Threading;

namespace Internal.Runtime.Augments;

internal sealed class RuntimeThread
{
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration;

	private readonly Thread thread;

	public bool IsBackground
	{
		set
		{
		}
	}

	private RuntimeThread(Thread t)
	{
	}

	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize)
	{
		return null;
	}

	public void Start(object state)
	{
	}

	public static void Sleep(int millisecondsTimeout)
	{
	}

	public static bool Yield()
	{
		return false;
	}

	public static bool SpinWait(int iterations)
	{
		return false;
	}

	public static int GetCurrentProcessorId()
	{
		return 0;
	}
}
