using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization;

[Serializable]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable
{
	private IList<object> m_serializedStates;

	private SerializationInfo m_savedSerializationInfo;

	private object m_realObject;

	private RuntimeType m_realType;

	[CompilerGenerated]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState;

	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	internal bool IsActive => false;

	internal SafeSerializationManager()
	{
	}

	private SafeSerializationManager(SerializationInfo info, StreamingContext context)
	{
	}

	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context)
	{
	}

	internal void CompleteDeserialization(object deserializedObject)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	object IObjectReference.GetRealObject(StreamingContext context)
	{
		return null;
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
	}
}
