using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : Object
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
	public struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr;
	}

	public IndexFormat indexFormat
	{
		get
		{
			return default(IndexFormat);
		}
		set
		{
		}
	}

	public int blendShapeCount
	{
		[NativeMethod(Name = "GetBlendShapeChannelCount")]
		get
		{
			return 0;
		}
	}

	[NativeName("BindPosesFromScript")]
	public Matrix4x4[] bindposes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isReadable
	{
		[NativeMethod("GetIsReadable")]
		get
		{
			return false;
		}
	}

	internal bool canAccess
	{
		[NativeMethod("CanAccessFromScript")]
		get
		{
			return false;
		}
	}

	public int vertexCount
	{
		[NativeMethod("GetVertexCount")]
		get
		{
			return 0;
		}
	}

	public int subMeshCount
	{
		[NativeMethod(Name = "GetSubMeshCount")]
		get
		{
			return 0;
		}
		[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = true)]
		set
		{
		}
	}

	public Bounds bounds
	{
		get
		{
			return default(Bounds);
		}
		set
		{
		}
	}

	public Vector3[] vertices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3[] normals
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector4[] tangents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector2[] uv
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector2[] uv2
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector2[] uv3
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector2[] uv4
	{
		set
		{
		}
	}

	public Color[] colors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color32[] colors32
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int[] triangles
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoneWeight[] boneWeights
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create([Writable] Mesh mono)
	{
	}

	[RequiredByNativeCode]
	public Mesh()
	{
	}

	[FreeFunction("MeshScripting::MeshFromInstanceId")]
	internal static Mesh FromInstanceID(int id)
	{
		return null;
	}

	[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = true, ThrowsException = true)]
	public void SetIndexBufferParams(int indexCount, IndexFormat format)
	{
	}

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = true, ThrowsException = true)]
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
	{
	}

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = true, ThrowsException = true)]
	private void SetVertexBufferParamsFromArray(int vertexCount, [Unmarshalled] params VertexAttributeDescriptor[] attributes)
	{
	}

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = true)]
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
	{
	}

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = true)]
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
	{
	}

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = true)]
	private uint GetIndexCountImpl(int submesh)
	{
		return 0u;
	}

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = true)]
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex)
	{
		return null;
	}

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = true)]
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex)
	{
		return null;
	}

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = true, ThrowsException = true)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
	{
	}

	[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = true, ThrowsException = true)]
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
	{
	}

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = true)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch)
	{
	}

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
	public bool HasVertexAttribute(VertexAttribute attr)
	{
		return false;
	}

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = true)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
	{
	}

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = true)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim)
	{
		return null;
	}

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = true)]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values)
	{
	}

	[FreeFunction(Name = "MeshScripting::ClearBlendShapes", HasExplicitThis = true)]
	public void ClearBlendShapes()
	{
	}

	[FreeFunction(Name = "MeshScripting::GetBlendShapeName", HasExplicitThis = true, ThrowsException = true)]
	public string GetBlendShapeName(int shapeIndex)
	{
		return null;
	}

	[FreeFunction(Name = "MeshScripting::GetBlendShapeIndex", HasExplicitThis = true, ThrowsException = true)]
	public int GetBlendShapeIndex(string blendShapeName)
	{
		return 0;
	}

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameCount", HasExplicitThis = true, ThrowsException = true)]
	public int GetBlendShapeFrameCount(int shapeIndex)
	{
		return 0;
	}

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameWeight", HasExplicitThis = true, ThrowsException = true)]
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
	{
		return 0f;
	}

	[FreeFunction(Name = "GetBlendShapeFrameVerticesFromScript", HasExplicitThis = true, ThrowsException = true)]
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, [Unmarshalled] Vector3[] deltaVertices, [Unmarshalled] Vector3[] deltaNormals, [Unmarshalled] Vector3[] deltaTangents)
	{
	}

	[FreeFunction(Name = "AddBlendShapeFrameFromScript", HasExplicitThis = true, ThrowsException = true)]
	public void AddBlendShapeFrame(string shapeName, float frameWeight, [Unmarshalled] Vector3[] deltaVertices, [Unmarshalled] Vector3[] deltaNormals, [Unmarshalled] Vector3[] deltaTangents)
	{
	}

	[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = true)]
	private BoneWeight[] GetBoneWeightsImpl()
	{
		return null;
	}

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = true)]
	private void SetBoneWeightsImpl(BoneWeight[] weights)
	{
	}

	[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = true, ThrowsException = true)]
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default)
	{
	}

	[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = true, ThrowsException = true)]
	public SubMeshDescriptor GetSubMesh(int index)
	{
		return default(SubMeshDescriptor);
	}

	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout)
	{
	}

	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags)
	{
	}

	[NativeMethod("RecalculateNormals")]
	private void RecalculateNormalsImpl(MeshUpdateFlags flags)
	{
	}

	[NativeMethod("RecalculateTangents")]
	private void RecalculateTangentsImpl(MeshUpdateFlags flags)
	{
	}

	[NativeMethod("MarkDynamic")]
	private void MarkDynamicImpl()
	{
	}

	[NativeMethod("UploadMeshData")]
	private void UploadMeshDataImpl(bool markNoLongerReadable)
	{
	}

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = true)]
	private MeshTopology GetTopologyImpl(int submesh)
	{
		return default(MeshTopology);
	}

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = true, ThrowsException = true, HasExplicitThis = true)]
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
	{
	}

	[NativeMethod("Optimize")]
	private void OptimizeImpl()
	{
	}

	internal static VertexAttribute GetUVChannel(int uvIndex)
	{
		return default(VertexAttribute);
	}

	internal static int DefaultDimensionForChannel(VertexAttribute channel)
	{
		return 0;
	}

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim)
	{
		return null;
	}

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel)
	{
		return null;
	}

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
	{
	}

	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
	{
	}

	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
	{
	}

	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags)
	{
	}

	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags)
	{
	}

	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim)
	{
	}

	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType)
	{
	}

	public void SetVertices(List<Vector3> inVertices)
	{
	}

	[ExcludeFromDocs]
	public void SetVertices(List<Vector3> inVertices, int start, int length)
	{
	}

	public void SetVertices(List<Vector3> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	[ExcludeFromDocs]
	public void SetVertices(Vector3[] inVertices, int start, int length)
	{
	}

	public void SetVertices(Vector3[] inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void SetNormals(List<Vector3> inNormals)
	{
	}

	[ExcludeFromDocs]
	public void SetNormals(List<Vector3> inNormals, int start, int length)
	{
	}

	public void SetNormals(List<Vector3> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	[ExcludeFromDocs]
	public void SetNormals(Vector3[] inNormals, int start, int length)
	{
	}

	public void SetNormals(Vector3[] inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void SetTangents(List<Vector4> inTangents)
	{
	}

	[ExcludeFromDocs]
	public void SetTangents(List<Vector4> inTangents, int start, int length)
	{
	}

	public void SetTangents(List<Vector4> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	[ExcludeFromDocs]
	public void SetTangents(Vector4[] inTangents, int start, int length)
	{
	}

	public void SetTangents(Vector4[] inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void SetColors(List<Color> inColors)
	{
	}

	[ExcludeFromDocs]
	public void SetColors(List<Color> inColors, int start, int length)
	{
	}

	public void SetColors(List<Color> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void SetColors(List<Color32> inColors)
	{
	}

	[ExcludeFromDocs]
	public void SetColors(List<Color32> inColors, int start, int length)
	{
	}

	public void SetColors(List<Color32> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags)
	{
	}

	public void SetUVs(int channel, List<Vector2> uvs)
	{
	}

	public void SetUVs(int channel, List<Vector3> uvs)
	{
	}

	public void SetUVs(int channel, List<Vector4> uvs)
	{
	}

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length)
	{
	}

	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length)
	{
	}

	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length)
	{
	}

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags)
	{
	}

	public void SetUVs(int channel, Vector4[] uvs)
	{
	}

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector2[] uvs, int start, int length)
	{
	}

	public void SetUVs(int channel, Vector2[] uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector4[] uvs, int start, int length)
	{
	}

	public void SetUVs(int channel, Vector4[] uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
	{
	}

	public void GetUVs(int channel, List<Vector2> uvs)
	{
	}

	public void GetUVs(int channel, List<Vector3> uvs)
	{
	}

	public void GetUVs(int channel, List<Vector4> uvs)
	{
	}

	public void SetVertexBufferParams(int vertexCount, params VertexAttributeDescriptor[] attributes)
	{
	}

	public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
	{
	}

	public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
	{
	}

	private void PrintErrorCantAccessIndices()
	{
	}

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
	{
		return false;
	}

	private bool CheckCanAccessSubmeshTriangles(int submesh)
	{
		return false;
	}

	private bool CheckCanAccessSubmeshIndices(int submesh)
	{
		return false;
	}

	public int[] GetTriangles(int submesh)
	{
		return null;
	}

	public int[] GetTriangles(int submesh, [DefaultValue("true")] bool applyBaseVertex)
	{
		return null;
	}

	[ExcludeFromDocs]
	public int[] GetIndices(int submesh)
	{
		return null;
	}

	public int[] GetIndices(int submesh, [DefaultValue("true")] bool applyBaseVertex)
	{
		return null;
	}

	public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
	{
	}

	public uint GetIndexCount(int submesh)
	{
		return 0u;
	}

	private void CheckIndicesArrayRange(int valuesLength, int start, int length)
	{
	}

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
	{
	}

	public void SetTriangles(int[] triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
	{
	}

	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	[ExcludeFromDocs]
	public void SetTriangles(List<int> triangles, int submesh)
	{
	}

	public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
	{
	}

	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	[ExcludeFromDocs]
	public void SetIndices(int[] indices, MeshTopology topology, int submesh)
	{
	}

	[ExcludeFromDocs]
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds)
	{
	}

	public void SetIndices(int[] indices, MeshTopology topology, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
	{
	}

	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : struct
	{
	}

	public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : struct
	{
	}

	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	[ExcludeFromDocs]
	public void Clear()
	{
	}

	[ExcludeFromDocs]
	public void RecalculateBounds()
	{
	}

	[ExcludeFromDocs]
	public void RecalculateNormals()
	{
	}

	[ExcludeFromDocs]
	public void RecalculateTangents()
	{
	}

	public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void RecalculateNormals([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void RecalculateTangents([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void MarkDynamic()
	{
	}

	public void UploadMeshData(bool markNoLongerReadable)
	{
	}

	public void Optimize()
	{
	}

	public MeshTopology GetTopology(int submesh)
	{
		return default(MeshTopology);
	}

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices)
	{
	}

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes)
	{
	}

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine)
	{
	}

	private void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default)
	{
	}

	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret)
	{
		ret = default(SubMeshDescriptor);
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default(Bounds);
	}

	[SpecialName]
	private void set_bounds_Injected(ref Bounds value)
	{
	}
}
