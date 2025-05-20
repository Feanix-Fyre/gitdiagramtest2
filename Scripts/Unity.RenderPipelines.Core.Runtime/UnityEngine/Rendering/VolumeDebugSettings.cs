using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Rendering;

public abstract class VolumeDebugSettings<T> : IVolumeDebugSettings2, IVolumeDebugSettings where T : MonoBehaviour, IAdditionalData
{
	private Camera m_SelectedCamera;

	protected int m_SelectedCameraIndex;

	private Camera[] m_CamerasArray;

	private List<Camera> m_Cameras;

	private static List<(string, Type)> s_ComponentPathAndType;

	private float[] weights;

	private Volume[] volumes;

	private VolumeParameter[,] savedStates;

	private static List<Type> s_ComponentTypes;

	public int selectedComponent { get; set; }

	public Camera selectedCamera => null;

	public int selectedCameraIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public IEnumerable<Camera> cameras => null;

	public abstract VolumeStack selectedCameraVolumeStack { get; }

	public abstract LayerMask selectedCameraLayerMask { get; }

	public abstract Vector3 selectedCameraPosition { get; }

	public Type selectedComponentType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<(string, Type)> volumeComponentsPathAndType => null;

	public abstract Type targetRenderPipeline { get; }

	[Obsolete("Please use volumeComponentsPathAndType instead, and get the second element of the tuple", false)]
	public static List<Type> componentTypes => null;

	[Obsolete("Cameras are auto registered/unregistered, use property cameras", false)]
	protected static List<T> additionalCameraDatas { get; private set; }

	internal VolumeParameter GetParameter(VolumeComponent component, FieldInfo field)
	{
		return null;
	}

	internal VolumeParameter GetParameter(FieldInfo field)
	{
		return null;
	}

	internal VolumeParameter GetParameter(Volume volume, FieldInfo field)
	{
		return null;
	}

	private float ComputeWeight(Volume volume, Vector3 triggerPos)
	{
		return 0f;
	}

	public Volume[] GetVolumes()
	{
		return null;
	}

	private VolumeParameter[,] GetStates()
	{
		return null;
	}

	private bool ChangedStates(VolumeParameter[,] newStates)
	{
		return false;
	}

	public bool RefreshVolumes(Volume[] newVolumes)
	{
		return false;
	}

	public float GetVolumeWeight(Volume volume)
	{
		return 0f;
	}

	public bool VolumeHasInfluence(Volume volume)
	{
		return false;
	}

	[Obsolete("Please use componentPathAndType instead, and get the first element of the tuple", false)]
	public static string ComponentDisplayName(Type component)
	{
		return null;
	}

	[Obsolete("Cameras are auto registered/unregistered", false)]
	public static void RegisterCamera(T additionalCamera)
	{
	}

	[Obsolete("Cameras are auto registered/unregistered", false)]
	public static void UnRegisterCamera(T additionalCamera)
	{
	}
}
