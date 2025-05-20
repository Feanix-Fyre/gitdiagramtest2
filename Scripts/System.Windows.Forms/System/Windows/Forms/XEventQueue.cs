using System.Collections;
using System.Threading;

namespace System.Windows.Forms;

internal class XEventQueue
{
	public class PaintQueue
	{
		private ArrayList hwnds;

		private XEvent xevent;

		public int Count => 0;

		public PaintQueue(int size)
		{
		}

		public void Enqueue(Hwnd hwnd)
		{
		}

		public void Remove(Hwnd hwnd)
		{
		}

		public XEvent Dequeue()
		{
			return default(XEvent);
		}
	}

	private class XQueue
	{
		private XEvent[] xevents;

		private int head;

		private int tail;

		private int size;

		public int Count => 0;

		public XQueue(int size)
		{
		}

		public void Enqueue(XEvent xevent)
		{
		}

		public XEvent Dequeue()
		{
			return default(XEvent);
		}

		public XEvent Peek()
		{
			return default(XEvent);
		}

		private void Grow()
		{
		}
	}

	private XQueue xqueue;

	private XQueue lqueue;

	private PaintQueue paint;

	internal ArrayList timer_list;

	private Thread thread;

	private bool dispatch_idle;

	private static readonly int InitialXEventSize;

	private static readonly int InitialLXEventSize;

	private static readonly int InitialPaintSize;

	public int Count => 0;

	public PaintQueue Paint => null;

	public Thread Thread => null;

	public bool DispatchIdle
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public XEventQueue(Thread thread)
	{
	}

	public void EnqueueLocked(XEvent xevent)
	{
	}

	public XEvent Dequeue()
	{
		return default(XEvent);
	}

	public XEvent Peek()
	{
		return default(XEvent);
	}
}
