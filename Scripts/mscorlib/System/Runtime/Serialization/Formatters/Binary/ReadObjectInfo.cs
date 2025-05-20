using System.Collections.Generic;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ReadObjectInfo
{
	internal int objectInfoId;

	internal static int readObjectInfoCounter;

	internal Type objectType;

	internal ObjectManager objectManager;

	internal int count;

	internal bool isSi;

	internal bool isNamed;

	internal bool isTyped;

	internal bool bSimpleAssembly;

	internal SerObjectInfoCache cache;

	internal string[] wireMemberNames;

	internal Type[] wireMemberTypes;

	private int lastPosition;

	internal ISerializationSurrogate serializationSurrogate;

	internal StreamingContext context;

	internal List<Type> memberTypesList;

	internal SerObjectInfoInit serObjectInfoInit;

	internal IFormatterConverter formatterConverter;

	internal ReadObjectInfo()
	{
	}

	internal void ObjectEnd()
	{
	}

	internal void PrepareForReuse()
	{
	}

	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
	{
		return null;
	}

	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
	{
	}

	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
	{
		return null;
	}

	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
	{
	}

	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
	{
	}

	private void InitSiRead()
	{
	}

	private void InitNoMembers()
	{
	}

	private void InitMemberInfo()
	{
	}

	internal MemberInfo GetMemberInfo(string name)
	{
		return null;
	}

	internal Type GetType(string name)
	{
		return null;
	}

	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData)
	{
	}

	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData)
	{
	}

	internal void RecordFixup(long objectId, string name, long idRef)
	{
	}

	internal void PopulateObjectMembers(object obj, object[] memberData)
	{
	}

	private int Position(string name)
	{
		return 0;
	}

	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType)
	{
		return null;
	}

	internal Type GetMemberType(MemberInfo objMember)
	{
		return null;
	}

	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
	{
		return null;
	}
}
