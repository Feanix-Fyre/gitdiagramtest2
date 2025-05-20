using System.Collections;
using System.Reflection;

namespace System.Windows.Forms;

/// <summary>Represents a collection of <see cref="T:System.Windows.Forms.Form" /> objects.</summary>
[DefaultMember("Item")]
public class FormCollection : ReadOnlyCollectionBase
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.FormCollection" /> class.</summary>
	public FormCollection()
	{
	}

	internal void Add(Form form)
	{
	}

	internal void Remove(Form form)
	{
	}
}
