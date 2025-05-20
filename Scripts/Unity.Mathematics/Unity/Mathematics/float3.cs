using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics;

[Serializable]
[DebuggerTypeProxy(typeof(DebuggerProxy))]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct float3 : IEquatable<float3>, IFormattable
{
	internal sealed class DebuggerProxy
	{
		public float x;

		public float y;

		public float z;

		public DebuggerProxy(float3 v)
		{
		}
	}

	public float x;

	public float y;

	public float z;

	public static readonly float3 zero;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xxzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xyzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 xzzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yxzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yyzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 yzzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zxzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zyzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float4 zzzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float4);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 xzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 yzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zxx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zxy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zxz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zyx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zyy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zyz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zzx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zzy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float3 zzz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float3);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 xx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 xy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 xz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 yx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 yy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 yz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 zx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 zy
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public float2 zz
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(float2);
		}
	}

	public float this[int index]
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(float x, float y, float z)
	{
		this.x = 0f;
		this.y = 0f;
		this.z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(float x, float2 yz)
	{
		this.x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(float2 xy, float z)
	{
		x = 0f;
		y = 0f;
		this.z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(float3 xyz)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(float v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(bool v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(bool3 v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(int v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(int3 v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(uint v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(uint3 v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(half v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(half3 v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(double v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3(double3 v)
	{
		x = 0f;
		y = 0f;
		z = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3(float v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3(bool v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3(bool3 v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3(int v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3(int3 v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3(uint v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3(uint3 v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3(half v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3(half3 v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3(double v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3(double3 v)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator *(float3 lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator *(float3 lhs, float rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator *(float lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator +(float3 lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator +(float3 lhs, float rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator +(float lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator -(float3 lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator -(float3 lhs, float rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator -(float lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator /(float3 lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator /(float3 lhs, float rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator /(float lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator %(float3 lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator %(float3 lhs, float rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator %(float lhs, float3 rhs)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator ++(float3 val)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator --(float3 val)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator <(float3 lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator <(float3 lhs, float rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator <(float lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator <=(float3 lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator <=(float3 lhs, float rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator <=(float lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator >(float3 lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator >(float3 lhs, float rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator >(float lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator >=(float3 lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator >=(float3 lhs, float rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator >=(float lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator -(float3 val)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3 operator +(float3 val)
	{
		return default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator ==(float3 lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator ==(float3 lhs, float rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator ==(float lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator !=(float3 lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator !=(float3 lhs, float rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3 operator !=(float lhs, float3 rhs)
	{
		return default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(float3 rhs)
	{
		return false;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	public static implicit operator Vector3(float3 v)
	{
		return default(Vector3);
	}

	public static implicit operator float3(Vector3 v)
	{
		return default(float3);
	}
}
