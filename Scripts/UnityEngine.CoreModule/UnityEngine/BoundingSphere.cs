namespace UnityEngine;

public struct BoundingSphere
{
	public Vector3 position;

	public float radius;

	public BoundingSphere(Vector3 pos, float rad)
	{
		position = default(Vector3);
		radius = 0f;
	}
}
