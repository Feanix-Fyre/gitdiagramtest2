namespace System.Drawing;

internal class WorkerThread
{
	private EventHandler frameChangeHandler;

	private AnimateEventArgs animateEventArgs;

	private int[] delay;

	public WorkerThread(EventHandler frmChgHandler, AnimateEventArgs aniEvtArgs, int[] delay)
	{
	}

	public void LoopHandler()
	{
	}
}
