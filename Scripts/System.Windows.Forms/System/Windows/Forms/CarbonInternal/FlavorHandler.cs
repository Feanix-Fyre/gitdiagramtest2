using System.Collections;
using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class FlavorHandler
{
	internal IntPtr flavorref;

	internal IntPtr dragref;

	internal IntPtr itemref;

	internal int size;

	internal uint flags;

	internal byte[] data;

	internal string fourcc;

	internal string DataString => null;

	internal byte[] DataArray => null;

	internal IntPtr DataPtr => (IntPtr)0;

	internal bool Supported => false;

	internal FlavorHandler(IntPtr dragref, IntPtr itemref, uint counter)
	{
	}

	internal void GetData()
	{
	}

	internal DataObject Convert(ArrayList flavorlist)
	{
		return null;
	}

	internal DataObject DeserializeObject(ArrayList flavorlist)
	{
		return null;
	}

	internal DataObject ConvertToObject(ArrayList flavorlist)
	{
		return null;
	}

	internal DataObject ConvertToFileDrop(ArrayList flavorlist)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	[PreserveSig]
	private static extern int GetFlavorDataSize(IntPtr dragref, IntPtr itemref, IntPtr flavorref, ref int size);

	[PreserveSig]
	private static extern int GetFlavorData(IntPtr dragref, IntPtr itemref, IntPtr flavorref, [In][Out] byte[] data, ref int size, uint offset);

	[PreserveSig]
	private static extern int GetFlavorFlags(IntPtr dragref, IntPtr itemref, IntPtr flavorref, ref uint flags);

	[PreserveSig]
	private static extern int GetFlavorType(IntPtr dragref, IntPtr itemref, uint index, ref IntPtr flavor);
}
