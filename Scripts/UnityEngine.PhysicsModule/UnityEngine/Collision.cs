namespace UnityEngine;

public class Collision
{
	private ContactPairHeader m_Header;

	private ContactPair m_Pair;

	private bool m_Flipped;

	private ContactPoint[] m_LegacyContacts;

	public Vector3 relativeVelocity => default(Vector3);

	public Rigidbody rigidbody => null;

	public Component body => null;

	public Collider collider => null;

	public GameObject gameObject => null;

	internal bool Flipped
	{
		set
		{
		}
	}

	public int contactCount => 0;

	public ContactPoint[] contacts => null;

	public Collision()
	{
	}

	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped)
	{
	}

	internal void Reuse(in ContactPairHeader header, in ContactPair pair)
	{
	}

	public int GetContacts(ContactPoint[] contacts)
	{
		return 0;
	}
}
