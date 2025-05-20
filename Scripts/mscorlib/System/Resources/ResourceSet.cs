using System.Collections;
using System.Runtime.InteropServices;

namespace System.Resources;

/// <summary>Stores all the resources localized for one particular culture, ignoring all other cultures, including any fallback rules.</summary>
[Serializable]
[ComVisible(true)]
public class ResourceSet : IDisposable, IEnumerable
{
	/// <summary>Indicates the <see cref="T:System.Resources.IResourceReader" /> used to read the resources.</summary>
	[NonSerialized]
	protected IResourceReader Reader;

	/// <summary>The <see cref="T:System.Collections.Hashtable" /> in which the resources are stored.</summary>
	protected Hashtable Table;

	private Hashtable _caseInsensitiveTable;

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceSet" /> class with default properties.</summary>
	protected ResourceSet()
	{
	}

	internal ResourceSet(bool junk)
	{
	}

	private void CommonInit()
	{
	}

	/// <summary>Releases resources (other than memory) associated with the current instance, closing internal managed objects if requested.</summary>
	/// <param name="disposing">Indicates whether the objects contained in the current instance should be explicitly closed.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Disposes of the resources (other than memory) used by the current instance of <see cref="T:System.Resources.ResourceSet" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> that can iterate through the <see cref="T:System.Resources.ResourceSet" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for this <see cref="T:System.Resources.ResourceSet" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The resource set has been closed or disposed.</exception>
	[ComVisible(false)]
	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> object to avoid a race condition with <see langword="Dispose" />. This member is not intended to be used directly from your code.</summary>
	/// <returns>An enumerator for the current <see cref="T:System.Resources.ResourceSet" /> object.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private IDictionaryEnumerator GetEnumeratorHelper()
	{
		return null;
	}

	/// <summary>Searches for a <see cref="T:System.String" /> resource with the specified name.</summary>
	/// <param name="name">Name of the resource to search for.</param>
	/// <returns>The value of a resource, if the value is a <see cref="T:System.String" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The resource specified by <paramref name="name" /> is not a <see cref="T:System.String" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
	public virtual string GetString(string name)
	{
		return null;
	}

	/// <summary>Searches for a <see cref="T:System.String" /> resource with the specified name in a case-insensitive manner, if requested.</summary>
	/// <param name="name">Name of the resource to search for.</param>
	/// <param name="ignoreCase">Indicates whether the case of the case of the specified name should be ignored.</param>
	/// <returns>The value of a resource, if the value is a <see cref="T:System.String" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The resource specified by <paramref name="name" /> is not a <see cref="T:System.String" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
	public virtual string GetString(string name, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Searches for a resource object with the specified name.</summary>
	/// <param name="name">Case-sensitive name of the resource to search for.</param>
	/// <returns>The requested resource.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
	public virtual object GetObject(string name)
	{
		return null;
	}

	/// <summary>Searches for a resource object with the specified name in a case-insensitive manner, if requested.</summary>
	/// <param name="name">Name of the resource to search for.</param>
	/// <param name="ignoreCase">Indicates whether the case of the specified name should be ignored.</param>
	/// <returns>The requested resource.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
	public virtual object GetObject(string name, bool ignoreCase)
	{
		return null;
	}

	private object GetObjectInternal(string name)
	{
		return null;
	}

	private object GetCaseInsensitiveObjectInternal(string name)
	{
		return null;
	}
}
