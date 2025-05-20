using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace System.Windows.Forms;

/// <summary>Implements a basic data transfer mechanism.</summary>
[ClassInterface(ClassInterfaceType.None)]
public class DataObject : System.Runtime.InteropServices.ComTypes.IDataObject, IDataObject
{
	private class Entry
	{
		private string type;

		private object data;

		private bool autoconvert;

		internal Entry next;

		public object Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AutoConvert => false;

		internal Entry(string type, object data, bool autoconvert)
		{
		}

		public static int Count(Entry entries)
		{
			return 0;
		}

		public static Entry Find(Entry entries, string type)
		{
			return null;
		}

		public static Entry Find(Entry entries, string type, bool only_convertible)
		{
			return null;
		}

		public static Entry FindConvertible(Entry entries, string type)
		{
			return null;
		}

		public static string[] Entries(Entry entries, bool convertible)
		{
			return null;
		}
	}

	private Entry entries;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DataObject" /> class.</summary>
	public DataObject()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DataObject" /> class and adds the specified object in the specified format.</summary>
	/// <param name="format">The format of the specified data. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <param name="data">The data to store.</param>
	public DataObject(string format, object data)
	{
	}

	/// <summary>Creates a connection between a data object and an advisory sink. This method is called by an object that supports an advisory sink and enables the advisory sink to be notified of changes in the object's data.</summary>
	/// <param name="pFormatetc">A <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure, passed by reference, that defines the format, target device, aspect, and medium that will be used for future notifications.</param>
	/// <param name="advf">One of the <see cref="T:System.Runtime.InteropServices.ComTypes.ADVF" /> values that specifies a group of flags for controlling the advisory connection.</param>
	/// <param name="pAdvSink">A pointer to the <see cref="T:System.Runtime.InteropServices.ComTypes.IAdviseSink" /> interface on the advisory sink that will receive the change notification.</param>
	/// <param name="pdwConnection">When this method returns, contains a pointer to a DWORD token that identifies this connection. You can use this token later to delete the advisory connection by passing it to <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.DUnadvise(System.Int32)" />. If this value is zero, the connection was not established. This parameter is passed uninitialized.</param>
	/// <returns>This method supports the standard return values E_INVALIDARG, E_UNEXPECTED, and E_OUTOFMEMORY, as well as the following:  
	///   Value  
	///
	///   Description  
	///
	///   S_OK  
	///
	///   The advisory connection was created.  
	///
	///   E_NOTIMPL  
	///
	///   This method is not implemented on the data object.  
	///
	///   DV_E_LINDEX  
	///
	///   There is an invalid value for <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.lindex" />; currently, only -1 is supported.  
	///
	///   DV_E_FORMATETC  
	///
	///   There is an invalid value for the <paramref name="pFormatetc" /> parameter.  
	///
	///   OLE_E_ADVISENOTSUPPORTED  
	///
	///   The data object does not support change notification.</returns>
	int System.Runtime.InteropServices.ComTypes.IDataObject.DAdvise(ref FORMATETC pFormatetc, ADVF advf, IAdviseSink adviseSink, out int connection)
	{
		connection = default(int);
		return 0;
	}

	/// <summary>Destroys a notification connection that had been previously established.</summary>
	/// <param name="dwConnection">A DWORD token that specifies the connection to remove. Use the value returned by <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.DAdvise(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.ADVF,System.Runtime.InteropServices.ComTypes.IAdviseSink,System.Int32@)" /> when the connection was originally established.</param>
	void System.Runtime.InteropServices.ComTypes.IDataObject.DUnadvise(int connection)
	{
	}

	/// <summary>Creates an object that can be used to enumerate the current advisory connections.</summary>
	/// <param name="enumAdvise">When this method returns, contains an <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumSTATDATA" /> that receives the interface pointer to the new enumerator object. If the implementation sets <paramref name="enumAdvise" /> to <see langword="null" />, there are no connections to advisory sinks at this time. This parameter is passed uninitialized.</param>
	/// <returns>This method supports the standard return value E_OUTOFMEMORY, as well as the following:  
	///   Value  
	///
	///   Description  
	///
	///   S_OK  
	///
	///   The enumerator object is successfully instantiated or there are no connections.  
	///
	///   OLE_E_ADVISENOTSUPPORTED  
	///
	///   This object does not support advisory notifications.</returns>
	int System.Runtime.InteropServices.ComTypes.IDataObject.EnumDAdvise(out IEnumSTATDATA enumAdvise)
	{
		enumAdvise = null;
		return 0;
	}

	/// <summary>Creates an object for enumerating the <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structures for a data object. These structures are used in calls to <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" /> or <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.SetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@,System.Boolean)" />.</summary>
	/// <param name="dwDirection">One of the <see cref="T:System.Runtime.InteropServices.ComTypes.DATADIR" /> values that specifies the direction of the data.</param>
	/// <returns>This method supports the standard return values E_INVALIDARG and E_OUTOFMEMORY, as well as the following:  
	///   Value  
	///
	///   Description  
	///
	///   S_OK  
	///
	///   The enumerator object was successfully created.  
	///
	///   E_NOTIMPL  
	///
	///   The direction specified by the <paramref name="direction" /> parameter is not supported.  
	///
	///   OLE_S_USEREG  
	///
	///   Requests that OLE enumerate the formats from the registry.</returns>
	IEnumFORMATETC System.Runtime.InteropServices.ComTypes.IDataObject.EnumFormatEtc(DATADIR direction)
	{
		return null;
	}

	/// <summary>Provides a standard <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure that is logically equivalent to a more complex structure. Use this method to determine whether two different <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structures would return the same data, removing the need for duplicate rendering.</summary>
	/// <param name="pformatetcIn">A pointer to a <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure, passed by reference, that defines the format, medium, and target device that the caller would like to use to retrieve data in a subsequent call such as <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />. The <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" /> member is not significant in this case and should be ignored.</param>
	/// <param name="pformatetcOut">When this method returns, contains a pointer to a <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure that contains the most general information possible for a specific rendering, making it canonically equivalent to <c>formatetIn</c>. The caller must allocate this structure and the <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetCanonicalFormatEtc(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.FORMATETC@)" /> method must fill in the data. To retrieve data in a subsequent call such as <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />, the caller uses the supplied value of <c>formatOut</c>, unless the value supplied is <see langword="null" />. This value is <see langword="null" /> if the method returns <see langword="DATA_S_SAMEFORMATETC" />. The <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" /> member is not significant in this case and should be ignored. This parameter is passed uninitialized.</param>
	/// <returns>This method supports the standard return values E_INVALIDARG, E_UNEXPECTED, and E_OUTOFMEMORY, as well as the following:  
	///   Value  
	///
	///   Description  
	///
	///   S_OK  
	///
	///   The returned <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure is different from the one that was passed.  
	///
	///   DATA_S_SAMEFORMATETC  
	///
	///   The <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structures are the same and <see langword="null" /> is returned in the <paramref name="formatOut" /> parameter.  
	///
	///   DV_E_LINDEX  
	///
	///   There is an invalid value for <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.lindex" />; currently, only -1 is supported.  
	///
	///   DV_E_FORMATETC  
	///
	///   There is an invalid value for the <paramref name="pFormatetc" /> parameter.  
	///
	///   OLE_E_NOTRUNNING  
	///
	///   The application is not running.</returns>
	int System.Runtime.InteropServices.ComTypes.IDataObject.GetCanonicalFormatEtc(ref FORMATETC formatIn, out FORMATETC formatOut)
	{
		formatOut = default(FORMATETC);
		return 0;
	}

	/// <summary>Obtains data from a source data object. The <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" /> method, which is called by a data consumer, renders the data described in the specified <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure and transfers it through the specified <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /> structure. The caller then assumes responsibility for releasing the <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /> structure.</summary>
	/// <param name="formatetc">A pointer to a <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure, passed by reference, that defines the format, medium, and target device to use when passing the data. It is possible to specify more than one medium by using the Boolean OR operator, allowing the method to choose the best medium among those specified.</param>
	/// <param name="medium">When this method returns, contains a pointer to the <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /> structure that indicates the storage medium containing the returned data through its <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.tymed" /> member, and the responsibility for releasing the medium through the value of its <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> member. If <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> is <see langword="null" />, the receiver of the medium is responsible for releasing it; otherwise, <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> points to the <see langword="IUnknown" /> interface on the appropriate object so its <see langword="Release" /> method can be called. The medium must be allocated and filled in by <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />. This parameter is passed uninitialized.</param>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough memory to perform this operation.</exception>
	void System.Runtime.InteropServices.ComTypes.IDataObject.GetData(ref FORMATETC format, out STGMEDIUM medium)
	{
		medium = default(STGMEDIUM);
	}

	/// <summary>Obtains data from a source data object. This method, which is called by a data consumer, differs from the <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" /> method in that the caller must allocate and free the specified storage medium.</summary>
	/// <param name="formatetc">A pointer to a <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure, passed by reference, that defines the format, medium, and target device to use when passing the data. Only one medium can be specified in <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" />, and only the following <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" /> values are valid: <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_ISTORAGE" />, <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_ISTREAM" />, <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_HGLOBAL" />, or <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_FILE" />.</param>
	/// <param name="medium">A <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />, passed by reference, that defines the storage medium containing the data being transferred. The medium must be allocated by the caller and filled in by <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetDataHere(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />. The caller must also free the medium. The implementation of this method must always supply a value of <see langword="null" /> for the <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> member of the <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /> structure that this parameter points to.</param>
	void System.Runtime.InteropServices.ComTypes.IDataObject.GetDataHere(ref FORMATETC format, ref STGMEDIUM medium)
	{
	}

	/// <summary>Determines whether the data object is capable of rendering the data described in the <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure. Objects attempting a paste or drop operation can call this method before calling <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" /> to get an indication of whether the operation may be successful.</summary>
	/// <param name="formatetc">A pointer to a <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure, passed by reference, that defines the format, medium, and target device to use for the query.</param>
	/// <returns>This method supports the standard return values E_INVALIDARG, E_UNEXPECTED, and E_OUTOFMEMORY, as well as the following:  
	///   Value  
	///
	///   Description  
	///
	///   S_OK  
	///
	///   A subsequent call to <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" /> would probably be successful.  
	///
	///   DV_E_LINDEX  
	///
	///   An invalid value for <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.lindex" />; currently, only -1 is supported.  
	///
	///   DV_E_FORMATETC  
	///
	///   An invalid value for the <paramref name="pFormatetc" /> parameter.  
	///
	///   DV_E_TYMED  
	///
	///   An invalid <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.tymed" /> value.  
	///
	///   DV_E_DVASPECT  
	///
	///   An invalid <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.dwAspect" /> value.  
	///
	///   OLE_E_NOTRUNNING  
	///
	///   The application is not running.</returns>
	int System.Runtime.InteropServices.ComTypes.IDataObject.QueryGetData(ref FORMATETC format)
	{
		return 0;
	}

	/// <summary>Transfers data to the object that implements this method. This method is called by an object that contains a data source.</summary>
	/// <param name="pFormatetcIn">A <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> structure, passed by reference, that defines the format used by the data object when interpreting the data contained in the storage medium.</param>
	/// <param name="pmedium">A <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /> structure, passed by reference, that defines the storage medium in which the data is being passed.</param>
	/// <param name="fRelease">
	///   <see langword="true" /> to specify that the data object called, which implements <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.SetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@,System.Boolean)" />, owns the storage medium after the call returns. This means that the data object must free the medium after it has been used by calling the <see langword="ReleaseStgMedium" /> function. <see langword="false" /> to specify that the caller retains ownership of the storage medium, and the data object called uses the storage medium for the duration of the call only.</param>
	/// <exception cref="T:System.NotImplementedException">This method does not support the type of the underlying data object.</exception>
	void System.Runtime.InteropServices.ComTypes.IDataObject.SetData(ref FORMATETC formatIn, ref STGMEDIUM medium, bool release)
	{
	}

	/// <summary>Returns the data associated with the specified data format.</summary>
	/// <param name="format">The format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <returns>The data associated with the specified format, or <see langword="null" />.</returns>
	public virtual object GetData(string format)
	{
		return null;
	}

	/// <summary>Returns the data associated with the specified data format, using an automated conversion parameter to determine whether to convert the data to the format.</summary>
	/// <param name="format">The format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <param name="autoConvert">
	///   <see langword="true" /> to the convert data to the specified format; otherwise, <see langword="false" />.</param>
	/// <returns>The data associated with the specified format, or <see langword="null" />.</returns>
	public virtual object GetData(string format, bool autoConvert)
	{
		return null;
	}

	/// <summary>Determines whether data stored in this <see cref="T:System.Windows.Forms.DataObject" /> is associated with, or can be converted to, the specified format.</summary>
	/// <param name="format">The format to check for. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <returns>
	///   <see langword="true" /> if data stored in this <see cref="T:System.Windows.Forms.DataObject" /> is associated with, or can be converted to, the specified format; otherwise, <see langword="false" />.</returns>
	public virtual bool GetDataPresent(string format)
	{
		return false;
	}

	/// <summary>Determines whether this <see cref="T:System.Windows.Forms.DataObject" /> contains data in the specified format or, optionally, contains data that can be converted to the specified format.</summary>
	/// <param name="format">The format to check for. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <param name="autoConvert">
	///   <see langword="true" /> to determine whether data stored in this <see cref="T:System.Windows.Forms.DataObject" /> can be converted to the specified format; <see langword="false" /> to check whether the data is in the specified format.</param>
	/// <returns>
	///   <see langword="true" /> if the data is in, or can be converted to, the specified format; otherwise, <see langword="false" />.</returns>
	public virtual bool GetDataPresent(string format, bool autoConvert)
	{
		return false;
	}

	/// <summary>Returns a list of all formats that data stored in this <see cref="T:System.Windows.Forms.DataObject" /> is associated with or can be converted to.</summary>
	/// <returns>An array of type <see cref="T:System.String" />, containing a list of all formats that are supported by the data stored in this object.</returns>
	public virtual string[] GetFormats()
	{
		return null;
	}

	/// <summary>Returns a list of all formats that data stored in this <see cref="T:System.Windows.Forms.DataObject" /> is associated with or can be converted to, using an automatic conversion parameter to determine whether to retrieve only native data formats or all formats that the data can be converted to.</summary>
	/// <param name="autoConvert">
	///   <see langword="true" /> to retrieve all formats that data stored in this <see cref="T:System.Windows.Forms.DataObject" /> is associated with, or can be converted to; <see langword="false" /> to retrieve only native data formats.</param>
	/// <returns>An array of type <see cref="T:System.String" />, containing a list of all formats that are supported by the data stored in this object.</returns>
	public virtual string[] GetFormats(bool autoConvert)
	{
		return null;
	}

	/// <summary>Adds the specified object to the <see cref="T:System.Windows.Forms.DataObject" /> using the object type as the data format.</summary>
	/// <param name="data">The data to store.</param>
	public virtual void SetData(object data)
	{
	}

	/// <summary>Adds the specified object to the <see cref="T:System.Windows.Forms.DataObject" /> using the specified format and indicating whether the data can be converted to another format.</summary>
	/// <param name="format">The format associated with the data. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <param name="autoConvert">
	///   <see langword="true" /> to allow the data to be converted to another format; otherwise, <see langword="false" />.</param>
	/// <param name="data">The data to store.</param>
	public virtual void SetData(string format, bool autoConvert, object data)
	{
	}

	/// <summary>Adds the specified object to the <see cref="T:System.Windows.Forms.DataObject" /> using the specified format.</summary>
	/// <param name="format">The format associated with the data. See <see cref="T:System.Windows.Forms.DataFormats" /> for predefined formats.</param>
	/// <param name="data">The data to store.</param>
	public virtual void SetData(string format, object data)
	{
	}

	/// <summary>Adds the specified object to the <see cref="T:System.Windows.Forms.DataObject" /> using the specified type as the format.</summary>
	/// <param name="format">A <see cref="T:System.Type" /> representing the format associated with the data.</param>
	/// <param name="data">The data to store.</param>
	public virtual void SetData(Type format, object data)
	{
	}

	internal string EnsureFormat(string name)
	{
		return null;
	}

	internal string EnsureFormat(Type type)
	{
		return null;
	}
}
