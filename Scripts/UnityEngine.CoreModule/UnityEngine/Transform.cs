using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[NativeHeader("Runtime/Transform/Transform.h")]
[RequiredByNativeCode]
[NativeHeader("Configuration/UnityConfigure.h")]
public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer;

		private int currentIndex;

		public object Current => null;

		internal Enumerator(Transform outer)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	public Vector3 position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 localPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 eulerAngles
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 localEulerAngles
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 right => default(Vector3);

	public Vector3 up
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 forward
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Quaternion localRotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 localScale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Transform parent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Transform parentInternal
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Matrix4x4 worldToLocalMatrix => default(Matrix4x4);

	public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

	public Transform root => null;

	public int childCount
	{
		[NativeMethod("GetChildrenCount")]
		get
		{
			return 0;
		}
	}

	public Vector3 lossyScale
	{
		[NativeMethod("GetWorldScaleLossy")]
		get
		{
			return default(Vector3);
		}
	}

	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected Transform()
	{
	}

	private Transform GetParent()
	{
		return null;
	}

	public void SetParent(Transform p)
	{
	}

	[FreeFunction("SetParent", HasExplicitThis = true)]
	public void SetParent(Transform parent, bool worldPositionStays)
	{
	}

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
	{
	}

	public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo)
	{
	}

	public void Translate(Vector3 translation)
	{
	}

	public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo)
	{
	}

	public void Translate(float x, float y, float z)
	{
	}

	public void Rotate(Vector3 eulers, [DefaultValue("Space.Self")] Space relativeTo)
	{
	}

	public void Rotate(Vector3 eulers)
	{
	}

	public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo)
	{
	}

	public void Rotate(float xAngle, float yAngle, float zAngle)
	{
	}

	[NativeMethod("RotateAround")]
	internal void RotateAroundInternal(Vector3 axis, float angle)
	{
	}

	public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
	{
	}

	public void Rotate(Vector3 axis, float angle)
	{
	}

	public void RotateAround(Vector3 point, Vector3 axis, float angle)
	{
	}

	public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp)
	{
	}

	public void LookAt(Transform target)
	{
	}

	public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp)
	{
	}

	public void LookAt(Vector3 worldPosition)
	{
	}

	[FreeFunction("Internal_LookAt", HasExplicitThis = true)]
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
	{
	}

	public Vector3 TransformDirection(Vector3 direction)
	{
		return default(Vector3);
	}

	public Vector3 InverseTransformDirection(Vector3 direction)
	{
		return default(Vector3);
	}

	public Vector3 TransformVector(Vector3 vector)
	{
		return default(Vector3);
	}

	public Vector3 InverseTransformVector(Vector3 vector)
	{
		return default(Vector3);
	}

	public Vector3 TransformPoint(Vector3 position)
	{
		return default(Vector3);
	}

	public Vector3 TransformPoint(float x, float y, float z)
	{
		return default(Vector3);
	}

	public Vector3 InverseTransformPoint(Vector3 position)
	{
		return default(Vector3);
	}

	private Transform GetRoot()
	{
		return null;
	}

	public void SetAsFirstSibling()
	{
	}

	public void SetAsLastSibling()
	{
	}

	public void SetSiblingIndex(int index)
	{
	}

	public int GetSiblingIndex()
	{
		return 0;
	}

	[FreeFunction]
	private static Transform FindRelativeTransformWithPath([NotNull("NullExceptionObject")] Transform transform, string path, [DefaultValue("false")] bool isActiveOnly)
	{
		return null;
	}

	public Transform Find(string n)
	{
		return null;
	}

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = true)]
	public bool IsChildOf([NotNull("ArgumentNullException")] Transform parent)
	{
		return false;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[FreeFunction("GetChild", HasExplicitThis = true)]
	[NativeThrows]
	public Transform GetChild(int index)
	{
		return null;
	}

	[SpecialName]
	private void get_position_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_position_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_localPosition_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_localPosition_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_rotation_Injected(out Quaternion ret)
	{
		ret = default(Quaternion);
	}

	[SpecialName]
	private void set_rotation_Injected(ref Quaternion value)
	{
	}

	[SpecialName]
	private void get_localRotation_Injected(out Quaternion ret)
	{
		ret = default(Quaternion);
	}

	[SpecialName]
	private void set_localRotation_Injected(ref Quaternion value)
	{
	}

	[SpecialName]
	private void get_localScale_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_localScale_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	[SpecialName]
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation)
	{
	}

	private void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation)
	{
	}

	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle)
	{
	}

	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp)
	{
	}

	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void get_lossyScale_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}
}
