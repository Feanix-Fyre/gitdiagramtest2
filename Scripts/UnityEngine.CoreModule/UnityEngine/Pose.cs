using System;

namespace UnityEngine;

[Serializable]
public struct Pose : IEquatable<Pose>
{
	public Vector3 position;

	public Quaternion rotation;

	private static readonly Pose k_Identity;

	public Pose(Vector3 position, Quaternion rotation)
	{
		this.position = default(Vector3);
		this.rotation = default(Quaternion);
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Pose other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
