using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.UI;

[EditorBrowsable(EditorBrowsableState.Never)]
[Obsolete("Use IMeshModifier instead", true)]
public interface IVertexModifier
{
	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void ModifyVertices(List<UIVertex> verts);
}
