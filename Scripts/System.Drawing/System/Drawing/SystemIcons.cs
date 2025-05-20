namespace System.Drawing;

/// <summary>Each property of the <see cref="T:System.Drawing.SystemIcons" /> class is an <see cref="T:System.Drawing.Icon" /> object for Windows system-wide icons. This class cannot be inherited.</summary>
public sealed class SystemIcons
{
	private static Icon[] icons;

	/// <summary>Gets an <see cref="T:System.Drawing.Icon" /> object that contains the system error icon (WIN32: IDI_ERROR).</summary>
	/// <returns>An <see cref="T:System.Drawing.Icon" /> object that contains the system error icon.</returns>
	public static Icon Error => null;

	/// <summary>Gets an <see cref="T:System.Drawing.Icon" /> object that contains the system information icon (WIN32: IDI_INFORMATION).</summary>
	/// <returns>An <see cref="T:System.Drawing.Icon" /> object that contains the system information icon.</returns>
	public static Icon Information => null;

	/// <summary>Gets an <see cref="T:System.Drawing.Icon" /> object that contains the system question icon (WIN32: IDI_QUESTION).</summary>
	/// <returns>An <see cref="T:System.Drawing.Icon" /> object that contains the system question icon.</returns>
	public static Icon Question => null;

	/// <summary>Gets an <see cref="T:System.Drawing.Icon" /> object that contains the system warning icon (WIN32: IDI_WARNING).</summary>
	/// <returns>An <see cref="T:System.Drawing.Icon" /> object that contains the system warning icon.</returns>
	public static Icon Warning => null;

	static SystemIcons()
	{
	}
}
