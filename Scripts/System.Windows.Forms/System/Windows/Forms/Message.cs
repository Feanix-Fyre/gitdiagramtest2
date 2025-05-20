namespace System.Windows.Forms;

/// <summary>Implements a Windows message.</summary>
public struct Message
{
	private int msg;

	private IntPtr hwnd;

	private IntPtr lParam;

	private IntPtr wParam;

	private IntPtr result;

	/// <summary>Gets or sets the window handle of the message.</summary>
	/// <returns>The window handle of the message.</returns>
	public IntPtr HWnd
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	/// <summary>Specifies the <see cref="P:System.Windows.Forms.Message.LParam" /> field of the message.</summary>
	/// <returns>The <see cref="P:System.Windows.Forms.Message.LParam" /> field of the message.</returns>
	public IntPtr LParam
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the ID number for the message.</summary>
	/// <returns>The ID number for the message.</returns>
	public int Msg
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Specifies the value that is returned to Windows in response to handling the message.</summary>
	/// <returns>The return value of the message.</returns>
	public IntPtr Result
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="P:System.Windows.Forms.Message.WParam" /> field of the message.</summary>
	/// <returns>The <see cref="P:System.Windows.Forms.Message.WParam" /> field of the message.</returns>
	public IntPtr WParam
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	/// <summary>Creates a new <see cref="T:System.Windows.Forms.Message" />.</summary>
	/// <param name="hWnd">The window handle that the message is for.</param>
	/// <param name="msg">The message ID.</param>
	/// <param name="wparam">The message <paramref name="wparam" /> field.</param>
	/// <param name="lparam">The message <paramref name="lparam" /> field.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.Message" /> that represents the message that was created.</returns>
	public static Message Create(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam)
	{
		return default(Message);
	}

	/// <summary>Determines whether the specified object is equal to the current object.</summary>
	/// <param name="o">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified object is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a <see cref="T:System.String" /> that represents the current <see cref="T:System.Windows.Forms.Message" />.</summary>
	/// <returns>A <see cref="T:System.String" /> that represents the current <see cref="T:System.Windows.Forms.Message" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
