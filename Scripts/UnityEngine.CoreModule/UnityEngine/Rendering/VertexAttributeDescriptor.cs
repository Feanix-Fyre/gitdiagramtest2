using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
{
	public VertexAttribute attribute { get; set; }

	public VertexAttributeFormat format { get; set; }

	public int dimension { get; set; }

	public int stream { get; set; }

	public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
	{
		this.attribute = default(VertexAttribute);
		this.format = default(VertexAttributeFormat);
		this.dimension = 0;
		this.stream = 0;
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public bool Equals(VertexAttributeDescriptor other)
	{
		return false;
	}
}
