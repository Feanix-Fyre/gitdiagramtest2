using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Windows.Forms;

internal class Win32DnD
{
	internal struct FORMATETC
	{
		internal ClipboardFormats cfFormat;

		internal IntPtr ptd;

		internal DVASPECT dwAspect;

		internal int lindex;

		internal TYMED tymed;
	}

	internal struct STGMEDIUM
	{
		internal TYMED tymed;

		internal IntPtr hHandle;

		internal IntPtr pUnkForRelease;
	}

	internal enum DVASPECT
	{
		DVASPECT_CONTENT = 1,
		DVASPECT_THUMBNAIL = 2,
		DVASPECT_ICON = 4,
		DVASPECT_DOCPRINT = 8
	}

	internal enum TYMED
	{
		TYMED_HGLOBAL = 1,
		TYMED_FILE = 2,
		TYMED_ISTREAM = 4,
		TYMED_ISTORAGE = 8,
		TYMED_GDI = 16,
		TYMED_MFPICT = 32,
		TYMED_ENHMF = 64,
		TYMED_NULL = 0
	}

	internal class ComIDataObject
	{
		internal static STGMEDIUM medium;

		internal static uint QueryInterface(IntPtr @this, ref Guid riid, IntPtr ppvObject)
		{
			return 0u;
		}

		internal static uint AddRef(IntPtr @this)
		{
			return 0u;
		}

		internal static uint Release(IntPtr @this)
		{
			return 0u;
		}

		internal static uint GetData(IntPtr this_, ref FORMATETC pformatetcIn, IntPtr pmedium)
		{
			return 0u;
		}

		internal static uint GetDataHere(IntPtr @this, ref FORMATETC pformatetc, ref STGMEDIUM pmedium)
		{
			return 0u;
		}

		internal static uint QueryGetData(IntPtr @this, ref FORMATETC pformatetc)
		{
			return 0u;
		}

		internal static uint GetCanonicalFormatEtc(IntPtr @this, ref FORMATETC pformatetcIn, IntPtr pformatetcOut)
		{
			return 0u;
		}

		internal static uint SetData(IntPtr this_, ref FORMATETC pformatetc, ref STGMEDIUM pmedium, bool release)
		{
			return 0u;
		}

		internal static uint EnumFormatEtc(IntPtr this_, uint direction, IntPtr ppenumFormatEtc)
		{
			return 0u;
		}

		internal static uint DAdvise(IntPtr this_, ref FORMATETC pformatetc, uint advf, IntPtr pAdvSink, ref uint pdwConnection)
		{
			return 0u;
		}

		internal static uint DUnadvise(IntPtr this_, uint pdwConnection)
		{
			return 0u;
		}

		internal static uint EnumDAdvise(IntPtr this_, IntPtr ppenumAdvise)
		{
			return 0u;
		}
	}

	internal class ComIDropSource
	{
		internal static uint QueryInterface(IntPtr @this, ref Guid riid, IntPtr ppvObject)
		{
			return 0u;
		}

		internal static uint AddRef(IntPtr @this)
		{
			return 0u;
		}

		internal static uint Release(IntPtr @this)
		{
			return 0u;
		}

		internal static uint QueryContinueDrag(IntPtr @this, bool fEscapePressed, uint grfkeyState)
		{
			return 0u;
		}

		internal static uint GiveFeedback(IntPtr @this, uint pdwEffect)
		{
			return 0u;
		}
	}

	internal class ComIDropTarget
	{
		internal struct IDropTarget
		{
			internal IntPtr vtbl;

			internal IntPtr Window;

			internal QueryInterfaceDelegate QueryInterface;

			internal AddRefDelegate AddRef;

			internal ReleaseDelegate Release;

			internal DragEnterDelegate DragEnter;

			internal DragOverDelegate DragOver;

			internal DragLeaveDelegate DragLeave;

			internal DropDelegate Drop;
		}

		internal static IntPtr GetUnmanaged(IntPtr Window)
		{
			return (IntPtr)0;
		}

		internal static uint QueryInterface(IntPtr @this, ref Guid riid, IntPtr ppvObject)
		{
			return 0u;
		}

		internal static uint AddRef(IntPtr @this)
		{
			return 0u;
		}

		internal static uint Release(IntPtr @this)
		{
			return 0u;
		}

		internal static uint DragEnter(IntPtr @this, IntPtr pDataObj, uint grfkeyState, IntPtr pt_x, IntPtr pt_y, IntPtr pdwEffect)
		{
			return 0u;
		}

		internal static uint DragOver(IntPtr @this, uint grfkeyState, IntPtr pt_x, IntPtr pt_y, IntPtr pdwEffect)
		{
			return 0u;
		}

		internal static uint DragLeave(IntPtr @this)
		{
			return 0u;
		}

		internal static uint Drop(IntPtr @this, IntPtr pDataObj, uint grfkeyState, IntPtr pt_x, IntPtr pt_y, IntPtr pdwEffect)
		{
			return 0u;
		}
	}

	internal delegate uint QueryInterfaceDelegate(IntPtr @this, ref Guid riid, IntPtr ppvObject);

	internal delegate uint AddRefDelegate(IntPtr @this);

	internal delegate uint ReleaseDelegate(IntPtr @this);

	internal delegate uint GetDataDelegate(IntPtr @this, ref FORMATETC pformatetcIn, IntPtr pmedium);

	internal delegate uint GetDataHereDelegate(IntPtr @this, ref FORMATETC pformatetc, ref STGMEDIUM pmedium);

	internal delegate uint QueryGetDataDelegate(IntPtr @this, ref FORMATETC pformatetc);

	internal delegate uint GetCanonicalFormatEtcDelegate(IntPtr @this, ref FORMATETC pformatetcIn, IntPtr pformatetcOut);

	internal delegate uint SetDataDelegate(IntPtr @this, ref FORMATETC pformatetc, ref STGMEDIUM pmedium, bool release);

	internal delegate uint EnumFormatEtcDelegate(IntPtr @this, uint direction, IntPtr ppenumFormatEtc);

	internal delegate uint DAdviseDelegate(IntPtr @this, ref FORMATETC pformatetc, uint advf, IntPtr pAdvSink, ref uint pdwConnection);

	internal delegate uint DUnadviseDelegate(IntPtr @this, uint pdwConnection);

	internal delegate uint EnumDAdviseDelegate(IntPtr @this, IntPtr ppenumAdvise);

	internal delegate uint QueryContinueDragDelegate(IntPtr @this, bool fEscapePressed, uint grfkeyState);

	internal delegate uint GiveFeedbackDelegate(IntPtr @this, uint pdwEffect);

	internal delegate uint DragEnterDelegate(IntPtr @this, IntPtr pDataObj, uint grfkeyState, IntPtr pt_x, IntPtr pt_y, IntPtr pdwEffect);

	internal delegate uint DragOverDelegate(IntPtr @this, uint grfkeyState, IntPtr pt_x, IntPtr pt_y, IntPtr pdwEffect);

	internal delegate uint DragLeaveDelegate(IntPtr @this);

	internal delegate uint DropDelegate(IntPtr @this, IntPtr pDataObj, uint grfkeyState, IntPtr pt_x, IntPtr pt_y, IntPtr pdwEffect);

	private static QueryInterfaceDelegate DOQueryInterface;

	private static AddRefDelegate DOAddRef;

	private static ReleaseDelegate DORelease;

	private static GetDataDelegate GetData;

	private static GetDataHereDelegate GetDataHere;

	private static QueryGetDataDelegate QueryGetData;

	private static GetCanonicalFormatEtcDelegate GetCanonicalFormatEtc;

	private static SetDataDelegate SetData;

	private static EnumFormatEtcDelegate EnumFormatEtc;

	private static DAdviseDelegate DAdvise;

	private static DUnadviseDelegate DUnadvise;

	private static EnumDAdviseDelegate EnumDAdvise;

	private static QueryInterfaceDelegate DSQueryInterface;

	private static AddRefDelegate DSAddRef;

	private static ReleaseDelegate DSRelease;

	private static QueryContinueDragDelegate QueryContinueDrag;

	private static GiveFeedbackDelegate GiveFeedback;

	private static QueryInterfaceDelegate DTQueryInterface;

	private static AddRefDelegate DTAddRef;

	private static ReleaseDelegate DTRelease;

	private static DragEnterDelegate DragEnter;

	private static DragOverDelegate DragOver;

	private static DragLeaveDelegate DragLeave;

	private static DropDelegate Drop;

	private static DragEventArgs DragDropEventArgs;

	private static GiveFeedbackEventArgs DragFeedbackEventArgs;

	private static QueryContinueDragEventArgs DragContinueEventArgs;

	private static ArrayList DragFormats;

	private static FORMATETC[] DragFormatArray;

	private static ArrayList DragMediums;

	private static readonly Guid IID_IUnknown;

	private static readonly Guid IID_IDataObject;

	private static readonly Guid IID_IDropSource;

	private static readonly Guid IID_IDropTarget;

	static Win32DnD()
	{
	}

	internal static bool HandleWMDropFiles(ref MSG msg)
	{
		return false;
	}

	private static int FindFormat(FORMATETC pformatetc)
	{
		return 0;
	}

	internal static bool UnregisterDropTarget(IntPtr Window)
	{
		return false;
	}

	internal static bool RegisterDropTarget(IntPtr Window)
	{
		return false;
	}

	[PreserveSig]
	private static extern uint Win32RegisterDragDrop(IntPtr Window, IntPtr pDropTarget);

	[PreserveSig]
	private static extern int Win32RevokeDragDrop(IntPtr Window);

	[PreserveSig]
	private static extern int Win32OleInitialize(IntPtr pvReserved);

	[PreserveSig]
	private static extern int Win32DragQueryFile(IntPtr hDrop, int iFile, IntPtr lpszFile, int cch);

	[PreserveSig]
	private static extern int Win32DragQueryFile(IntPtr hDrop, int iFile, StringBuilder lpszFile, int cch);

	[PreserveSig]
	private static extern uint Win32SHCreateStdEnumFmtEtc(uint cfmt, FORMATETC[] afmt, ref IntPtr ppenumFormatEtc);
}
