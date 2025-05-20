using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", StaticAccessorType.DoubleColon)]
public sealed class Gizmos
{
	public static Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Matrix4x4 matrix
	{
		get
		{
			return default(Matrix4x4);
		}
		set
		{
		}
	}

	[NativeThrows]
	public static void DrawLine(Vector3 from, Vector3 to)
	{
	}

	[NativeThrows]
	public static void DrawWireSphere(Vector3 center, float radius)
	{
	}

	[NativeThrows]
	public static void DrawSphere(Vector3 center, float radius)
	{
	}

	[NativeThrows]
	public static void DrawWireCube(Vector3 center, Vector3 size)
	{
	}

	[NativeThrows]
	public static void DrawCube(Vector3 center, Vector3 size)
	{
	}

	[NativeThrows]
	public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
	{
	}

	[NativeThrows]
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
	{
	}

	[NativeThrows]
	public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] Color tint)
	{
	}

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh)
	{
	}

	public static void DrawMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
	{
	}

	public static void DrawWireMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
	{
	}

	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to)
	{
	}

	private static void DrawWireSphere_Injected(ref Vector3 center, float radius)
	{
	}

	private static void DrawSphere_Injected(ref Vector3 center, float radius)
	{
	}

	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size)
	{
	}

	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size)
	{
	}

	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] ref Vector3 position, [DefaultValue("Quaternion.identity")] ref Quaternion rotation, [DefaultValue("Vector3.one")] ref Vector3 scale)
	{
	}

	private static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] ref Vector3 position, [DefaultValue("Quaternion.identity")] ref Quaternion rotation, [DefaultValue("Vector3.one")] ref Vector3 scale)
	{
	}

	private static void DrawIcon_Injected(ref Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] ref Color tint)
	{
	}

	[SpecialName]
	private static void get_color_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private static void set_color_Injected(ref Color value)
	{
	}

	[SpecialName]
	private static void get_matrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	[SpecialName]
	private static void set_matrix_Injected(ref Matrix4x4 value)
	{
	}
}
