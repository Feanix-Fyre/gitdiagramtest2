namespace System.Windows.Forms;

/// <summary>Provides <see langword="static" />, predefined <see cref="T:System.Windows.Forms.Clipboard" /> format names. Use them to identify the format of data that you store in an <see cref="T:System.Windows.Forms.IDataObject" />.</summary>
public class DataFormats
{
	/// <summary>Represents a Clipboard format type.</summary>
	public class Format
	{
		private static readonly object lockobj;

		private static Format formats;

		private string name;

		private int id;

		private Format next;

		internal bool is_serializable;

		/// <summary>Gets the ID number for this format.</summary>
		/// <returns>The ID number for this format.</returns>
		public int Id => 0;

		/// <summary>Gets the name of this format.</summary>
		/// <returns>The name of this format.</returns>
		public string Name => null;

		internal Format Next => null;

		internal static Format List => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DataFormats.Format" /> class with a Boolean that indicates whether a <see langword="Win32" /> handle is expected.</summary>
		/// <param name="name">The name of this format.</param>
		/// <param name="id">The ID number for this format.</param>
		public Format(string name, int id)
		{
		}

		internal static Format Add(string name)
		{
			return null;
		}

		internal static Format Find(int id)
		{
			return null;
		}

		internal static Format Find(string name)
		{
			return null;
		}
	}

	/// <summary>Specifies a Windows bitmap format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Bitmap;

	/// <summary>Specifies a comma-separated value (CSV) format, which is a common interchange format used by spreadsheets. This format is not used directly by Windows Forms. This <see langword="static" /> field is read-only.</summary>
	public static readonly string CommaSeparatedValue;

	/// <summary>Specifies the Windows device-independent bitmap (DIB) format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Dib;

	/// <summary>Specifies the Windows Data Interchange Format (DIF), which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Dif;

	/// <summary>Specifies the Windows enhanced metafile format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string EnhancedMetafile;

	/// <summary>Specifies the Windows file drop format, which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string FileDrop;

	/// <summary>Specifies text in the HTML Clipboard format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Html;

	/// <summary>Specifies the Windows culture format, which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Locale;

	/// <summary>Specifies the Windows metafile format, which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string MetafilePict;

	/// <summary>Specifies the standard Windows original equipment manufacturer (OEM) text format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string OemText;

	/// <summary>Specifies the Windows palette format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Palette;

	/// <summary>Specifies the Windows pen data format, which consists of pen strokes for handwriting software; Windows Forms does not use this format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string PenData;

	/// <summary>Specifies the Resource Interchange File Format (RIFF) audio format, which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Riff;

	/// <summary>Specifies text consisting of Rich Text Format (RTF) data. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Rtf;

	/// <summary>Specifies a format that encapsulates any type of Windows Forms object. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Serializable;

	/// <summary>Specifies the Windows Forms string class format, which Windows Forms uses to store string objects. This <see langword="static" /> field is read-only.</summary>
	public static readonly string StringFormat;

	/// <summary>Specifies the Windows symbolic link format, which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string SymbolicLink;

	/// <summary>Specifies the standard ANSI text format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Text;

	/// <summary>Specifies the Tagged Image File Format (TIFF), which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string Tiff;

	/// <summary>Specifies the standard Windows Unicode text format. This <see langword="static" /> field is read-only.</summary>
	public static readonly string UnicodeText;

	/// <summary>Specifies the wave audio format, which Windows Forms does not directly use. This <see langword="static" /> field is read-only.</summary>
	public static readonly string WaveAudio;

	private static object lock_object;

	private static bool initialized;

	internal static bool ContainsFormat(int id)
	{
		return false;
	}

	/// <summary>Returns a <see cref="T:System.Windows.Forms.DataFormats.Format" /> with the Windows Clipboard numeric ID and name for the specified ID.</summary>
	/// <param name="id">The format ID.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.DataFormats.Format" /> that has the Windows Clipboard numeric ID and the name of the format.</returns>
	public static Format GetFormat(int id)
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Windows.Forms.DataFormats.Format" /> with the Windows Clipboard numeric ID and name for the specified format.</summary>
	/// <param name="format">The format name.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.DataFormats.Format" /> that has the Windows Clipboard numeric ID and the name of the format.</returns>
	/// <exception cref="T:System.ComponentModel.Win32Exception">Registering a new <see cref="T:System.Windows.Forms.Clipboard" /> format failed.</exception>
	public static Format GetFormat(string format)
	{
		return null;
	}

	private static void Init()
	{
	}
}
