using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
{
	public MeshId MeshId { get; }

	public Mesh Mesh { get; }

	public MeshCollider MeshCollider { get; }

	public MeshGenerationStatus Status { get; }

	public MeshVertexAttributes Attributes { get; }

	public Vector3 Position { get; }

	public Quaternion Rotation { get; }

	public Vector3 Scale { get; }

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(MeshGenerationResult other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
