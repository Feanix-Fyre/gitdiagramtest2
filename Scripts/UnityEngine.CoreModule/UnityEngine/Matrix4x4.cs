using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeClass("Matrix4x4f")]
[Il2CppEagerStaticClassConstruction]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
{
	[NativeName("m_Data[0]")]
	public float m00;

	[NativeName("m_Data[1]")]
	public float m10;

	[NativeName("m_Data[2]")]
	public float m20;

	[NativeName("m_Data[3]")]
	public float m30;

	[NativeName("m_Data[4]")]
	public float m01;

	[NativeName("m_Data[5]")]
	public float m11;

	[NativeName("m_Data[6]")]
	public float m21;

	[NativeName("m_Data[7]")]
	public float m31;

	[NativeName("m_Data[8]")]
	public float m02;

	[NativeName("m_Data[9]")]
	public float m12;

	[NativeName("m_Data[10]")]
	public float m22;

	[NativeName("m_Data[11]")]
	public float m32;

	[NativeName("m_Data[12]")]
	public float m03;

	[NativeName("m_Data[13]")]
	public float m13;

	[NativeName("m_Data[14]")]
	public float m23;

	[NativeName("m_Data[15]")]
	public float m33;

	private static readonly Matrix4x4 zeroMatrix;

	private static readonly Matrix4x4 identityMatrix;

	public Vector3 lossyScale => default(Vector3);

	public bool isIdentity => false;

	public FrustumPlanes decomposeProjection => default(FrustumPlanes);

	public Matrix4x4 inverse => default(Matrix4x4);

	public Matrix4x4 transpose => default(Matrix4x4);

	public float this[int row, int column]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
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

	public static Matrix4x4 zero => default(Matrix4x4);

	public static Matrix4x4 identity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Matrix4x4);
		}
	}

	[ThreadSafe]
	private Vector3 GetLossyScale()
	{
		return default(Vector3);
	}

	[ThreadSafe]
	private bool IsIdentity()
	{
		return false;
	}

	[ThreadSafe]
	private FrustumPlanes DecomposeProjection()
	{
		return default(FrustumPlanes);
	}

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = true)]
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
	{
		return default(Matrix4x4);
	}

	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = true)]
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
	{
		return false;
	}

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = true)]
	public static Matrix4x4 Inverse(Matrix4x4 m)
	{
		return default(Matrix4x4);
	}

	[FreeFunction("MatrixScripting::Transpose", IsThreadSafe = true)]
	public static Matrix4x4 Transpose(Matrix4x4 m)
	{
		return default(Matrix4x4);
	}

	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = true)]
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
	{
		return default(Matrix4x4);
	}

	[FreeFunction("MatrixScripting::Perspective", IsThreadSafe = true)]
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
	{
		return default(Matrix4x4);
	}

	[FreeFunction("MatrixScripting::LookAt", IsThreadSafe = true)]
	public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
	{
		return default(Matrix4x4);
	}

	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = true)]
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
	{
		return default(Matrix4x4);
	}

	public static Matrix4x4 Frustum(FrustumPlanes fp)
	{
		return default(Matrix4x4);
	}

	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
	{
		m00 = 0f;
		m10 = 0f;
		m20 = 0f;
		m30 = 0f;
		m01 = 0f;
		m11 = 0f;
		m21 = 0f;
		m31 = 0f;
		m02 = 0f;
		m12 = 0f;
		m22 = 0f;
		m32 = 0f;
		m03 = 0f;
		m13 = 0f;
		m23 = 0f;
		m33 = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Matrix4x4 other)
	{
		return false;
	}

	public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
	{
		return default(Matrix4x4);
	}

	public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector)
	{
		return default(Vector4);
	}

	public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
	{
		return false;
	}

	public Vector4 GetColumn(int index)
	{
		return default(Vector4);
	}

	public Vector4 GetRow(int index)
	{
		return default(Vector4);
	}

	public void SetColumn(int index, Vector4 column)
	{
	}

	public void SetRow(int index, Vector4 row)
	{
	}

	public Vector3 MultiplyPoint(Vector3 point)
	{
		return default(Vector3);
	}

	public Vector3 MultiplyPoint3x4(Vector3 point)
	{
		return default(Vector3);
	}

	public Vector3 MultiplyVector(Vector3 vector)
	{
		return default(Vector3);
	}

	public static Matrix4x4 Scale(Vector3 vector)
	{
		return default(Matrix4x4);
	}

	public static Matrix4x4 Translate(Vector3 vector)
	{
		return default(Matrix4x4);
	}

	public static Matrix4x4 Rotate(Quaternion q)
	{
		return default(Matrix4x4);
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

	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private static bool IsIdentity_Injected(ref Matrix4x4 _unity_self)
	{
		return false;
	}

	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret)
	{
		ret = default(FrustumPlanes);
	}

	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result)
	{
		return false;
	}

	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}
}
