using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using JetBrains.Annotations;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[ModuleInfo("Create/GameObject", ModuleName = "Create GameObject")]
[HelpURL("https://curvyeditor.com/doclink/cgcreategameobject")]
public class CreateGameObject : ResourceExportingModule
{
	[InputSlotInfo(new Type[] { typeof(CGGameObject) }, Array = true, Name = "GameObject")]
	[HideInInspector]
	public CGModuleInputSlot InGameObjectArray;

	[InputSlotInfo(new Type[] { typeof(CGSpots) }, Name = "Spots")]
	[HideInInspector]
	public CGModuleInputSlot InSpots;

	[SerializeField]
	[CGResourceCollectionManager("GameObject", ShowCount = true)]
	private CGGameObjectResourceCollection m_Resources;

	[SerializeField]
	[Tab("General")]
	private bool m_MakeStatic;

	[Layer(null, null)]
	[SerializeField]
	private int m_Layer;

	[Tooltip("Whether Layer should be applied only on the root of a created game object, or it should be applied on its whole hierarchy")]
	[SerializeField]
	private bool applyLayerOnChildren;

	private readonly Dictionary<Transform, string> usedPoolsDictionary;

	public int Layer
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool ApplyLayerOnChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MakeStatic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CGGameObjectResourceCollection GameObjects => null;

	public int GameObjectCount => 0;

	public override void Reset()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override bool DeleteAllOutputManagedResources()
	{
		return false;
	}

	[Obsolete("Use DeleteAllOutputManagedResources instead")]
	[UsedImplicitly]
	public void Clear()
	{
	}

	public override void Refresh()
	{
	}

	protected override GameObject SaveResourceToScene(Component managedResource, Transform newParent)
	{
		return null;
	}

	protected override void ResetOnEnable()
	{
	}
}
