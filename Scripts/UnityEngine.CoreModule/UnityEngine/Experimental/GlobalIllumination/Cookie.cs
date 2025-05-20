namespace UnityEngine.Experimental.GlobalIllumination;

public struct Cookie
{
	public int instanceID;

	public float scale;

	public Vector2 sizes;

	public static Cookie Defaults()
	{
		return default(Cookie);
	}
}
