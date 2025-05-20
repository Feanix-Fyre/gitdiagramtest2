namespace System.Windows.Forms;

/// <summary>Encapsulates the information needed when creating a control.</summary>
public class CreateParams
{
	private string caption;

	private string class_name;

	private int class_style;

	private int ex_style;

	private int x;

	private int y;

	private int height;

	private int width;

	private int style;

	private object param;

	private IntPtr parent;

	internal Menu menu;

	internal Control control;

	/// <summary>Gets or sets the control's initial text.</summary>
	/// <returns>The control's initial text.</returns>
	public string Caption
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the name of the Windows class to derive the control from.</summary>
	/// <returns>The name of the Windows class to derive the control from.</returns>
	public string ClassName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a bitwise combination of class style values.</summary>
	/// <returns>A bitwise combination of the class style values.</returns>
	public int ClassStyle
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a bitwise combination of extended window style values.</summary>
	/// <returns>A bitwise combination of the extended window style values.</returns>
	public int ExStyle
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the initial left position of the control.</summary>
	/// <returns>The numeric value that represents the initial left position of the control.</returns>
	public int X
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the top position of the initial location of the control.</summary>
	/// <returns>The numeric value that represents the top position of the initial location of the control.</returns>
	public int Y
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the initial width of the control.</summary>
	/// <returns>The numeric value that represents the initial width of the control.</returns>
	public int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the initial height of the control.</summary>
	/// <returns>The numeric value that represents the initial height of the control.</returns>
	public int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a bitwise combination of window style values.</summary>
	/// <returns>A bitwise combination of the window style values.</returns>
	public int Style
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets additional parameter information needed to create the control.</summary>
	/// <returns>The <see cref="T:System.Object" /> that holds additional parameter information needed to create the control.</returns>
	public object Param
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the control's parent.</summary>
	/// <returns>An <see cref="T:System.IntPtr" /> that contains the window handle of the control's parent.</returns>
	public IntPtr Parent
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	internal bool HasWindowManager => false;

	internal WindowExStyles WindowExStyle
	{
		get
		{
			return default(WindowExStyles);
		}
		set
		{
		}
	}

	internal WindowStyles WindowStyle
	{
		get
		{
			return default(WindowStyles);
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.CreateParams" /> class.</summary>
	public CreateParams()
	{
	}

	internal bool IsSet(WindowStyles Style)
	{
		return false;
	}

	internal bool IsSet(WindowExStyles ExStyle)
	{
		return false;
	}

	internal static bool IsSet(WindowStyles Style, WindowStyles Option)
	{
		return false;
	}

	/// <summary>Returns a string that represents the current object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
