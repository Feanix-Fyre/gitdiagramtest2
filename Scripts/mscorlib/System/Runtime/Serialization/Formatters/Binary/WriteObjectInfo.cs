using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class WriteObjectInfo
{
	internal int objectInfoId;

	internal object obj;

	internal Type objectType;

	internal bool isSi;

	internal bool isNamed;

	internal bool isTyped;

	internal bool isArray;

	internal SerializationInfo si;

	internal SerObjectInfoCache cache;

	internal object[] memberData;

	internal ISerializationSurrogate serializationSurrogate;

	internal StreamingContext context;

	internal SerObjectInfoInit serObjectInfoInit;

	internal long objectId;

	internal long assemId;

	private string binderTypeName;

	private string binderAssemblyString;

	internal WriteObjectInfo()
	{
	}

	internal void ObjectEnd()
	{
	}

	private void InternalInit()
	{
	}

	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
	{
		return null;
	}

	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
	{
	}

	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
	{
		return null;
	}

	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
	{
	}

	private void InitSiWrite()
	{
	}

	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString)
	{
	}

	private void InitNoMembers()
	{
	}

	private void InitMemberInfo()
	{
	}

	internal string GetTypeFullName()
	{
		return null;
	}

	internal string GetAssemblyString()
	{
		return null;
	}

	private void InvokeSerializationBinder(SerializationBinder binder)
	{
	}

	internal Type GetMemberType(MemberInfo objMember)
	{
		return null;
	}

	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData)
	{
		outMemberNames = null;
		outMemberTypes = null;
		outMemberData = null;
	}

	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
	{
		return null;
	}

	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
	{
	}
}
