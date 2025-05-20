namespace System.Windows.Forms;

/// <summary>Provides methods to place data on and retrieve data from the system Clipboard. This class cannot be inherited.</summary>
public sealed class Clipboard
{
	private static bool ConvertToClipboardData(ref int type, object obj, out byte[] data)
	{
		data = null;
		return false;
	}

	private static bool ConvertFromClipboardData(int type, IntPtr data, out object obj)
	{
		obj = null;
		return false;
	}

	/// <summary>Retrieves the data that is currently on the system Clipboard.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.IDataObject" /> that represents the data currently on the Clipboard, or <see langword="null" /> if there is no data on the Clipboard.</returns>
	/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Data could not be retrieved from the Clipboard. This typically occurs when the Clipboard is being used by another process.</exception>
	/// <exception cref="T:System.Threading.ThreadStateException">The current thread is not in single-threaded apartment (STA) mode and the <see cref="P:System.Windows.Forms.Application.MessageLoop" /> property value is <see langword="true" />. Add the <see cref="T:System.STAThreadAttribute" /> to your application's <see langword="Main" /> method.</exception>
	public static IDataObject GetDataObject()
	{
		return null;
	}

	/// <summary>Clears the Clipboard and then places nonpersistent data on it.</summary>
	/// <param name="data">The data to place on the Clipboard.</param>
	/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Data could not be placed on the Clipboard. This typically occurs when the Clipboard is being used by another process.</exception>
	/// <exception cref="T:System.Threading.ThreadStateException">The current thread is not in single-threaded apartment (STA) mode. Add the <see cref="T:System.STAThreadAttribute" /> to your application's <see langword="Main" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">The value of <paramref name="data" /> is <see langword="null" />.</exception>
	public static void SetDataObject(object data)
	{
	}

	/// <summary>Clears the Clipboard and then places data on it and specifies whether the data should remain after the application exits.</summary>
	/// <param name="data">The data to place on the Clipboard.</param>
	/// <param name="copy">
	///   <see langword="true" /> if you want data to remain on the Clipboard after this application exits; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Data could not be placed on the Clipboard. This typically occurs when the Clipboard is being used by another process.</exception>
	/// <exception cref="T:System.Threading.ThreadStateException">The current thread is not in single-threaded apartment (STA) mode. Add the <see cref="T:System.STAThreadAttribute" /> to your application's <see langword="Main" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">The value of <paramref name="data" /> is <see langword="null" />.</exception>
	public static void SetDataObject(object data, bool copy)
	{
	}

	internal static void SetDataObjectImpl(object data, bool copy)
	{
	}

	private static bool IsDataSerializable(object obj)
	{
		return false;
	}

	/// <summary>Clears the Clipboard and then attempts to place data on it the specified number of times and with the specified delay between attempts, optionally leaving the data on the Clipboard after the application exits.</summary>
	/// <param name="data">The data to place on the Clipboard.</param>
	/// <param name="copy">
	///   <see langword="true" /> if you want data to remain on the Clipboard after this application exits; otherwise, <see langword="false" />.</param>
	/// <param name="retryTimes">The number of times to attempt placing the data on the Clipboard.</param>
	/// <param name="retryDelay">The number of milliseconds to pause between attempts.</param>
	/// <exception cref="T:System.Threading.ThreadStateException">The current thread is not in single-threaded apartment (STA) mode. Add the <see cref="T:System.STAThreadAttribute" /> to your application's <see langword="Main" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="data" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="retryTimes" /> is less than zero.  
	/// -or-  
	/// <paramref name="retryDelay" /> is less than zero.</exception>
	/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Data could not be placed on the Clipboard. This typically occurs when the Clipboard is being used by another process.</exception>
	public static void SetDataObject(object data, bool copy, int retryTimes, int retryDelay)
	{
	}

	internal static IDataObject GetDataObject(bool primary_selection)
	{
		return null;
	}
}
