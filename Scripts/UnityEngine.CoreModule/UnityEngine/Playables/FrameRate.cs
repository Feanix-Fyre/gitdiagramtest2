using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/FrameRate.h")]
[UsedByNativeCode("FrameRate")]
internal struct FrameRate : IEquatable<FrameRate>
{
	[Ignore]
	public static readonly FrameRate k_24Fps;

	[Ignore]
	public static readonly FrameRate k_23_976Fps;

	[Ignore]
	public static readonly FrameRate k_25Fps;

	[Ignore]
	public static readonly FrameRate k_30Fps;

	[Ignore]
	public static readonly FrameRate k_29_97Fps;

	[Ignore]
	public static readonly FrameRate k_50Fps;

	[Ignore]
	public static readonly FrameRate k_60Fps;

	[Ignore]
	public static readonly FrameRate k_59_94Fps;

	[SerializeField]
	private int m_Rate;

	public bool dropFrame => false;

	public double rate => 0.0;

	public FrameRate(uint frameRate = 0u, bool drop = false)
	{
		m_Rate = 0;
	}

	public bool IsValid()
	{
		return false;
	}

	public bool Equals(FrameRate other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static bool operator ==(FrameRate a, FrameRate b)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	internal static FrameRate DoubleToFrameRate(double framerate)
	{
		return default(FrameRate);
	}
}
