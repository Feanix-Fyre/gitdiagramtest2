using System;
using JetBrains.Annotations;
using UnityEngine;

namespace FluffyUnderware.DevTools;

[ExecuteAlways]
[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
[RequireComponent(typeof(MeshFilter))]
[UsedImplicitly]
public abstract class DuplicateEditorMesh : DTVersionedMonoBehaviour
{
	private MeshFilter mFilter;

	public MeshFilter Filter => null;
}
