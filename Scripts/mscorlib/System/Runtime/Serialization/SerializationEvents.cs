using System.Collections.Generic;
using System.Reflection;

namespace System.Runtime.Serialization;

internal sealed class SerializationEvents
{
	private readonly List<MethodInfo> _onSerializingMethods;

	private readonly List<MethodInfo> _onSerializedMethods;

	private readonly List<MethodInfo> _onDeserializingMethods;

	private readonly List<MethodInfo> _onDeserializedMethods;

	internal bool HasOnSerializingEvents => false;

	internal SerializationEvents(Type t)
	{
	}

	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t)
	{
		return null;
	}

	internal void InvokeOnSerializing(object obj, StreamingContext context)
	{
	}

	internal void InvokeOnDeserializing(object obj, StreamingContext context)
	{
	}

	internal void InvokeOnDeserialized(object obj, StreamingContext context)
	{
	}

	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler)
	{
		return null;
	}

	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler)
	{
		return null;
	}

	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods)
	{
	}

	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods)
	{
		return null;
	}
}
