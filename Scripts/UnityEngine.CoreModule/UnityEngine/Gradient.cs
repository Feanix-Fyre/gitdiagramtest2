using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient>
{
	internal IntPtr m_Ptr;

	public GradientColorKey[] colorKeys
	{
		[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = true, HasExplicitThis = true)]
		get
		{
			return null;
		}
		[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = true, HasExplicitThis = true)]
		[param: Unmarshalled]
		set
		{
		}
	}

	public GradientAlphaKey[] alphaKeys
	{
		[FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = true, HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = true)]
	private static IntPtr Init()
	{
		return (IntPtr)0;
	}

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
	private void Cleanup()
	{
	}

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = true, HasExplicitThis = true)]
	private bool Internal_Equals(IntPtr other)
	{
		return false;
	}

	[RequiredByNativeCode]
	public Gradient()
	{
	}

	~Gradient()
	{
	}

	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = true, HasExplicitThis = true)]
	public Color Evaluate(float time)
	{
		return default(Color);
	}

	[FreeFunction(Name = "Gradient_Bindings::SetKeys", IsThreadSafe = true, HasExplicitThis = true)]
	public void SetKeys([Unmarshalled] GradientColorKey[] colorKeys, [Unmarshalled] GradientAlphaKey[] alphaKeys)
	{
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public bool Equals(Gradient other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private void Evaluate_Injected(float time, out Color ret)
	{
		ret = default(Color);
	}
}
