using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy;

/// <summary>Defines the set of information that constitutes input to security policy decisions. This class cannot be inherited.</summary>
[Serializable]
[ComVisible(true)]
[MonoTODO("Serialization format not compatible with .NET")]
public sealed class Evidence : ICollection, IEnumerable
{
	private class EvidenceEnumerator : IEnumerator
	{
		private IEnumerator currentEnum;

		private IEnumerator hostEnum;

		private IEnumerator assemblyEnum;

		public object Current => null;

		public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private bool _locked;

	private ArrayList hostEvidenceList;

	private ArrayList assemblyEvidenceList;

	/// <summary>Gets the number of evidence objects in the evidence set.</summary>
	/// <returns>The number of evidence objects in the evidence set.</returns>
	[Obsolete]
	public int Count => 0;

	/// <summary>Gets a value indicating whether the evidence set is thread-safe.</summary>
	/// <returns>Always <see langword="false" /> because thread-safe evidence sets are not supported.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets the synchronization root.</summary>
	/// <returns>Always <see langword="this" /> (<see langword="Me" /> in Visual Basic), because synchronization of evidence sets is not supported.</returns>
	public object SyncRoot => null;

	/// <summary>Initializes a new empty instance of the <see cref="T:System.Security.Policy.Evidence" /> class.</summary>
	public Evidence()
	{
	}

	/// <summary>Copies evidence objects to an <see cref="T:System.Array" />.</summary>
	/// <param name="array">The target array to which to copy evidence objects.</param>
	/// <param name="index">The zero-based position in the array to which to begin copying evidence objects.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of the target array.</exception>
	[Obsolete]
	public void CopyTo(Array array, int index)
	{
	}

	/// <summary>Enumerates all evidence in the set, both that provided by the host and that provided by the assembly.</summary>
	/// <returns>An enumerator for evidence added by both the <see cref="M:System.Security.Policy.Evidence.AddHost(System.Object)" /> method and the <see cref="M:System.Security.Policy.Evidence.AddAssembly(System.Object)" /> method.</returns>
	[Obsolete]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
