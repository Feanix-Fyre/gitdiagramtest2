using System.Reflection;

namespace System.Runtime.Serialization;

internal sealed class ObjectHolder
{
	private object m_object;

	internal long m_id;

	private int m_missingElementsRemaining;

	private int m_missingDecendents;

	internal SerializationInfo m_serInfo;

	internal ISerializationSurrogate m_surrogate;

	internal FixupHolderList m_missingElements;

	internal LongList m_dependentObjects;

	internal ObjectHolder m_next;

	internal int m_flags;

	private bool m_markForFixupWhenAvailable;

	private ValueTypeFixupInfo m_valueFixup;

	private TypeLoadExceptionHolder m_typeLoad;

	private bool m_reachable;

	internal bool IsIncompleteObjectReference
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool RequiresDelayedFixup => false;

	internal bool RequiresValueTypeFixup => false;

	internal bool ValueTypeFixupPerformed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool HasISerializable => false;

	internal bool HasSurrogate => false;

	internal bool CanSurrogatedObjectValueChange => false;

	internal bool CanObjectValueChange => false;

	internal int DirectlyDependentObjects => 0;

	internal int TotalDependentObjects => 0;

	internal bool Reachable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool TypeLoadExceptionReachable => false;

	internal TypeLoadExceptionHolder TypeLoadException
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal object ObjectValue => null;

	internal SerializationInfo SerializationInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ISerializationSurrogate Surrogate => null;

	internal LongList DependentObjects
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool RequiresSerInfoFixup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal ValueTypeFixupInfo ValueFixup => null;

	internal bool CompletelyFixed => false;

	internal long ContainerID => 0L;

	internal ObjectHolder(long objID)
	{
	}

	internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex)
	{
	}

	internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex)
	{
	}

	private void IncrementDescendentFixups(int amount)
	{
	}

	internal void DecrementFixupsRemaining(ObjectManager manager)
	{
	}

	internal void RemoveDependency(long id)
	{
	}

	internal void AddFixup(FixupHolder fixup, ObjectManager manager)
	{
	}

	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
	{
	}

	internal void AddDependency(long dependentObject)
	{
	}

	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager)
	{
	}

	internal void MarkForCompletionWhenAvailable()
	{
	}

	internal void SetFlags()
	{
	}

	internal void SetObjectValue(object obj, ObjectManager manager)
	{
	}
}
