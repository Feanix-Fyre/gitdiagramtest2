using System.Threading;

namespace System.Drawing;

internal class AnimateEventArgs : EventArgs
{
	private int frameCount;

	private int activeFrame;

	private Thread thread;

	public Thread RunThread
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AnimateEventArgs(Image image)
	{
	}

	public int GetNextFrame()
	{
		return 0;
	}
}
