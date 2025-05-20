namespace UnityEngine.UIElements;

internal struct Spacing
{
	public float left;

	public float top;

	public float right;

	public float bottom;

	public float horizontal => 0f;

	public float vertical => 0f;

	public Spacing(float left, float top, float right, float bottom)
	{
		this.left = 0f;
		this.top = 0f;
		this.right = 0f;
		this.bottom = 0f;
	}

	public static Rect operator -(Rect r, Spacing a)
	{
		return default(Rect);
	}
}
