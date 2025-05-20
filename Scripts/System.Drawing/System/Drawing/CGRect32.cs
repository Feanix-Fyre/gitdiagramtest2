namespace System.Drawing;

internal struct CGRect32
{
	public CGPoint32 origin;

	public CGSize32 size;

	public CGRect32(float x, float y, float width, float height)
	{
		origin = default(CGPoint32);
		size = default(CGSize32);
	}
}
