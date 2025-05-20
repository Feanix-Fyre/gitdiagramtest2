using System.Reflection;
using System.Runtime.Serialization;

namespace System;

[Serializable]
internal class UnitySerializationHolder : ISerializable, IObjectReference
{
	private Type[] m_instantiation;

	private int[] m_elementTypes;

	private int m_genericParameterPosition;

	private Type m_declaringType;

	private MethodBase m_declaringMethod;

	private string m_data;

	private string m_assemblyName;

	private int m_unityType;

	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type)
	{
		return null;
	}

	internal Type MakeElementTypes(Type type)
	{
		return null;
	}

	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType)
	{
	}

	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type)
	{
	}

	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly)
	{
	}

	internal UnitySerializationHolder(SerializationInfo info, StreamingContext context)
	{
	}

	private void ThrowInsufficientInformation(string field)
	{
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual object GetRealObject(StreamingContext context)
	{
		return null;
	}
}
