using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectWriter
{
	private Queue m_objectQueue;

	private ObjectIDGenerator m_idGenerator;

	private int m_currentId;

	private ISurrogateSelector m_surrogates;

	private StreamingContext m_context;

	private __BinaryWriter serWriter;

	private SerializationObjectManager m_objectManager;

	private long topId;

	private string topName;

	private Header[] headers;

	private InternalFE formatterEnums;

	private SerializationBinder m_binder;

	private SerObjectInfoInit serObjectInfoInit;

	private IFormatterConverter m_formatterConverter;

	internal object[] crossAppDomainArray;

	private object previousObj;

	private long previousId;

	private Type previousType;

	private InternalPrimitiveTypeE previousCode;

	private Hashtable assemblyToIdTable;

	private SerStack niPool;

	internal SerializationObjectManager ObjectManager => null;

	internal ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
	{
	}

	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck)
	{
	}

	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
	{
	}

	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos)
	{
	}

	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo)
	{
	}

	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo)
	{
	}

	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo)
	{
	}

	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data)
	{
	}

	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA)
	{
	}

	private object GetNext(out long objID)
	{
		objID = default(long);
		return null;
	}

	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew)
	{
		isNew = default(bool);
		return 0L;
	}

	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type)
	{
		return 0L;
	}

	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo)
	{
		return 0L;
	}

	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
	{
		return false;
	}

	private void WriteObjectRef(NameInfo nameInfo, long objectId)
	{
	}

	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject)
	{
	}

	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
	{
		return false;
	}

	private void WriteSerializedStreamHeader(long topId, long headerId)
	{
	}

	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo)
	{
		return null;
	}

	private NameInfo TypeToNameInfo(Type type)
	{
		return null;
	}

	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo)
	{
		return null;
	}

	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo)
	{
		return null;
	}

	private void TypeToNameInfo(Type type, NameInfo nameInfo)
	{
	}

	private NameInfo MemberToNameInfo(string name)
	{
		return null;
	}

	internal InternalPrimitiveTypeE ToCode(Type type)
	{
		return default(InternalPrimitiveTypeE);
	}

	private long GetAssemblyId(WriteObjectInfo objectInfo)
	{
		return 0L;
	}

	private Type GetType(object obj)
	{
		return null;
	}

	private NameInfo GetNameInfo()
	{
		return null;
	}

	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want)
	{
		return false;
	}

	private void PutNameInfo(NameInfo nameInfo)
	{
	}
}
