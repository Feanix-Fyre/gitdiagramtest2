using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
public struct Resolution
{
	private int m_Width;

	private int m_Height;

	private RefreshRate m_RefreshRate;

	public int width => 0;

	public int height => 0;

	public RefreshRate refreshRateRatio => default(RefreshRate);

	public override string ToString()
	{
		return null;
	}
}
