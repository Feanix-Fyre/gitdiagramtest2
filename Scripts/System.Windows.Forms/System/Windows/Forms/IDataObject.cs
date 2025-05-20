using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides a format-independent mechanism for transferring data.</summary>
[ComVisible(true)]
public interface IDataObject
{
	/// <summary>Retrieves the data associated with the specified data format.</summary>
	/// <param name="format">The format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <returns>The data associated with the specified format, or <see langword="null" />.</returns>
	object GetData(string format);

	/// <summary>Retrieves the data associated with the specified data format, using a Boolean to determine whether to convert the data to the format.</summary>
	/// <param name="format">The format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <param name="autoConvert">
	///   <see langword="true" /> to convert the data to the specified format; otherwise, <see langword="false" />.</param>
	/// <returns>The data associated with the specified format, or <see langword="null" />.</returns>
	object GetData(string format, bool autoConvert);

	/// <summary>Determines whether data stored in this instance is associated with, or can be converted to, the specified format.</summary>
	/// <param name="format">The format for which to check. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <returns>
	///   <see langword="true" /> if data stored in this instance is associated with, or can be converted to, the specified format; otherwise <see langword="false" />.</returns>
	bool GetDataPresent(string format);

	/// <summary>Returns a list of all formats that data stored in this instance is associated with or can be converted to.</summary>
	/// <returns>An array of the names that represents a list of all formats that are supported by the data stored in this object.</returns>
	string[] GetFormats();

	/// <summary>Stores the specified data in this instance, using the class of the data for the format.</summary>
	/// <param name="data">The data to store.</param>
	void SetData(object data);

	/// <summary>Stores the specified data and its associated format in this instance.</summary>
	/// <param name="format">The format associated with the data. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <param name="data">The data to store.</param>
	void SetData(string format, object data);
}
