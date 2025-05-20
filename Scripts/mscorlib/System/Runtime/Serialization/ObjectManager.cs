using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

/// <summary>Keeps track of objects as they are deserialized.</summary>
[ComVisible(true)]
public class ObjectManager
{
	private DeserializationEventHandler m_onDeserializationHandler;

	private SerializationEventHandler m_onDeserializedHandler;

	internal ObjectHolder[] m_objects;

	internal object m_topObject;

	internal ObjectHolderList m_specialFixupObjects;

	internal long m_fixupCount;

	internal ISurrogateSelector m_selector;

	internal StreamingContext m_context;

	internal object TopObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ObjectHolderList SpecialFixupObjects => null;

	internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
	{
	}

	private bool CanCallGetType(object obj)
	{
		return false;
	}

	internal ObjectHolder FindObjectHolder(long objectID)
	{
		return null;
	}

	internal ObjectHolder FindOrCreateObjectHolder(long objectID)
	{
		return null;
	}

	private void AddObjectHolder(ObjectHolder holder)
	{
	}

	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing)
	{
		holder = null;
		member = null;
		return false;
	}

	private void FixupSpecialObject(ObjectHolder holder)
	{
	}

	private bool ResolveObjectReference(ObjectHolder holder)
	{
		return false;
	}

	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value)
	{
		return false;
	}

	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
	{
	}

	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
	{
	}

	/// <summary>Returns the object with the specified object ID.</summary>
	/// <param name="objectID">The ID of the requested object.</param>
	/// <returns>The object with the specified object ID if it has been previously stored or <see langword="null" /> if no such object has been registered.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero.</exception>
	public virtual object GetObject(long objectID)
	{
		return null;
	}

	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
	{
	}

	/// <summary>Registers a member of an array contained in an object while it is deserialized, associating it with <paramref name="objectID" />, and recording the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
	/// <param name="obj">The object to register.</param>
	/// <param name="objectID">The ID of the object to register.</param>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> used if <paramref name="obj" /> implements <see cref="T:System.Runtime.Serialization.ISerializable" /> or has a <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" />. <paramref name="info" /> will be completed with any required fixup information and then passed to the required object when that object is completed.</param>
	/// <param name="idOfContainingObj">The ID of the object that contains <paramref name="obj" />. This parameter is required only if <paramref name="obj" /> is a value type.</param>
	/// <param name="member">The field in the containing object where <paramref name="obj" /> exists. This parameter has meaning only if <paramref name="obj" /> is a value type.</param>
	/// <param name="arrayIndex">If <paramref name="obj" /> is a <see cref="T:System.ValueType" /> and a member of an array, <paramref name="arrayIndex" /> contains the index within that array where <paramref name="obj" /> exists. <paramref name="arrayIndex" /> is ignored if <paramref name="obj" /> is not both a <see cref="T:System.ValueType" /> and a member of an array.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="objectID" /> has already been registered for an object other than <paramref name="obj" />, or <paramref name="member" /> is not a <see cref="T:System.Reflection.FieldInfo" /> and <paramref name="member" /> isn't <see langword="null" />.</exception>
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex)
	{
	}

	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context)
	{
	}

	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t)
	{
		return null;
	}

	/// <summary>Performs all the recorded fixups.</summary>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A fixup was not successfully completed.</exception>
	public virtual void DoFixups()
	{
	}

	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
	{
	}

	/// <summary>Records a fixup for a member of an object, to be executed later.</summary>
	/// <param name="objectToBeFixed">The ID of the object that needs the reference to the <paramref name="objectRequired" /> object.</param>
	/// <param name="member">The member of <paramref name="objectToBeFixed" /> where the fixup will be performed.</param>
	/// <param name="objectRequired">The ID of the object required by <paramref name="objectToBeFixed" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="member" /> parameter is <see langword="null" />.</exception>
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
	{
	}

	/// <summary>Records a fixup for an object member, to be executed later.</summary>
	/// <param name="objectToBeFixed">The ID of the object that needs the reference to <paramref name="objectRequired" />.</param>
	/// <param name="memberName">The member name of <paramref name="objectToBeFixed" /> where the fixup will be performed.</param>
	/// <param name="objectRequired">The ID of the object required by <paramref name="objectToBeFixed" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="objectToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="memberName" /> parameter is <see langword="null" />.</exception>
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
	{
	}

	/// <summary>Records fixups for the specified elements in an array, to be executed later.</summary>
	/// <param name="arrayToBeFixed">The ID of the array used to record a fixup.</param>
	/// <param name="indices">The indexes within the multidimensional array that a fixup is requested for.</param>
	/// <param name="objectRequired">The ID of the object the array elements will point to after fixup is completed.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="arrayToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="indices" /> parameter is <see langword="null" />.</exception>
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired)
	{
	}

	/// <summary>Raises the deserialization event to any registered object that implements <see cref="T:System.Runtime.Serialization.IDeserializationCallback" />.</summary>
	public virtual void RaiseDeserializationEvent()
	{
	}

	internal virtual void AddOnDeserialization(DeserializationEventHandler handler)
	{
	}

	internal virtual void AddOnDeserialized(object obj)
	{
	}

	internal virtual void RaiseOnDeserializedEvent(object obj)
	{
	}

	/// <summary>Invokes the method marked with the <see cref="T:System.Runtime.Serialization.OnDeserializingAttribute" />.</summary>
	/// <param name="obj">The instance of the type that contains the method to be invoked.</param>
	public void RaiseOnDeserializingEvent(object obj)
	{
	}
}
