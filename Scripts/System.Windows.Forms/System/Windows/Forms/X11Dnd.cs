using System.IO;

namespace System.Windows.Forms;

internal class X11Dnd
{
	private enum DragState
	{
		None = 0,
		Beginning = 1,
		Dragging = 2,
		Entered = 3
	}

	private interface IDataConverter
	{
		void GetData(X11Dnd dnd, IDataObject data, ref XEvent xevent);

		void SetData(X11Dnd dnd, object data, ref XEvent xevent);
	}

	private class MimeHandler
	{
		public string Name;

		public string[] Aliases;

		public IntPtr Type;

		public IntPtr NonProtocol;

		public IDataConverter Converter;

		public MimeHandler(string name, IDataConverter converter)
		{
		}

		public MimeHandler(string name, IDataConverter converter, params string[] aliases)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	private class SerializedObjectConverter : IDataConverter
	{
		public void GetData(X11Dnd dnd, IDataObject data, ref XEvent xevent)
		{
		}

		public void SetData(X11Dnd dnd, object data, ref XEvent xevent)
		{
		}
	}

	private class HtmlConverter : IDataConverter
	{
		public void GetData(X11Dnd dnd, IDataObject data, ref XEvent xevent)
		{
		}

		public void SetData(X11Dnd dnd, object data, ref XEvent xevent)
		{
		}
	}

	private class TextConverter : IDataConverter
	{
		public void GetData(X11Dnd dnd, IDataObject data, ref XEvent xevent)
		{
		}

		public void SetData(X11Dnd dnd, object data, ref XEvent xevent)
		{
		}
	}

	private class UriListConverter : IDataConverter
	{
		public void GetData(X11Dnd dnd, IDataObject data, ref XEvent xevent)
		{
		}

		public void SetData(X11Dnd dnd, object data, ref XEvent xevent)
		{
		}
	}

	private class DragData
	{
		public DragState State;

		public object Data;

		public IntPtr Action;

		public IntPtr[] SupportedTypes;

		public DragDropEffects AllowedEffects;

		public IntPtr LastTopLevel;

		public bool WillAccept;

		public void Reset()
		{
		}
	}

	private MimeHandler[] MimeHandlers;

	private static readonly IntPtr[] XdndVersion;

	private IntPtr display;

	private DragData drag_data;

	private IntPtr XdndAware;

	private IntPtr XdndSelection;

	private IntPtr XdndEnter;

	private IntPtr XdndLeave;

	private IntPtr XdndPosition;

	private IntPtr XdndDrop;

	private IntPtr XdndFinished;

	private IntPtr XdndStatus;

	private IntPtr XdndTypeList;

	private IntPtr XdndActionCopy;

	private IntPtr XdndActionMove;

	private IntPtr XdndActionLink;

	private IntPtr XdndActionList;

	private int converts_pending;

	private bool position_recieved;

	private bool status_sent;

	private IntPtr target;

	private IntPtr source;

	private IntPtr toplevel;

	private IDataObject data;

	private Control control;

	private int pos_x;

	private int pos_y;

	private DragDropEffects allowed;

	private DragEventArgs drag_event;

	private Cursor CursorNo;

	private Cursor CursorCopy;

	private Cursor CursorMove;

	private Cursor CursorLink;

	private bool tracking;

	private bool dropped;

	public X11Dnd(IntPtr display, X11Keyboard keyboard)
	{
	}

	public void SetAllowDrop(Hwnd hwnd, bool allow)
	{
	}

	public bool HandleClientMessage(ref XEvent xevent)
	{
		return false;
	}

	public bool HandleSelectionNotifyEvent(ref XEvent xevent)
	{
		return false;
	}

	public bool HandleSelectionRequestEvent(ref XEvent xevent)
	{
		return false;
	}

	private bool QueryContinue(bool escape, DragAction action)
	{
		return false;
	}

	private void RestoreDefaultCursor()
	{
	}

	private void GiveFeedback(IntPtr action)
	{
	}

	private void SetProperty(ref XEvent xevent, IntPtr data, int length)
	{
	}

	private void Reset()
	{
	}

	private void ResetSourceData()
	{
	}

	private void ResetTargetData()
	{
	}

	private bool Accepting_HandleEnterEvent(ref XEvent xevent)
	{
		return false;
	}

	private bool Accepting_HandlePositionEvent(ref XEvent xevent)
	{
		return false;
	}

	private void Finish()
	{
	}

	private bool Accepting_HandleDropEvent(ref XEvent xevent)
	{
		return false;
	}

	private bool Accepting_HandleLeaveEvent(ref XEvent xevent)
	{
		return false;
	}

	private bool HandleStatusEvent(ref XEvent xevent)
	{
		return false;
	}

	private bool HandleFinishedEvent(ref XEvent xevent)
	{
		return false;
	}

	private DragDropEffects EffectsFromX11Source(IntPtr source, IntPtr action_atom)
	{
		return default(DragDropEffects);
	}

	private DragDropEffects EffectFromAction(IntPtr action)
	{
		return default(DragDropEffects);
	}

	private IntPtr ActionFromEffect(DragDropEffects effect)
	{
		return (IntPtr)0;
	}

	private bool ConvertData(ref XEvent xevent)
	{
		return false;
	}

	private void SetDataWithFormats(object value)
	{
	}

	private MimeHandler FindHandler(IntPtr atom)
	{
		return null;
	}

	private void SendStatus(IntPtr source, DragDropEffects effect)
	{
	}

	private void SendDrop(IntPtr handle, IntPtr from, IntPtr time)
	{
	}

	private void SendLeave(IntPtr handle, IntPtr from)
	{
	}

	private void SendFinished()
	{
	}

	private void Init()
	{
	}

	private IntPtr[] SourceSupportedList(ref XEvent xevent)
	{
		return null;
	}

	private string GetText(ref XEvent xevent, bool unicode)
	{
		return null;
	}

	private MemoryStream GetData(ref XEvent xevent)
	{
		return null;
	}

	private Control MwfWindow(IntPtr window)
	{
		return null;
	}
}
