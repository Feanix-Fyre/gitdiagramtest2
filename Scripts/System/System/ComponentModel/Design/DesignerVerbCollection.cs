using System.Collections;
using System.Reflection;

namespace System.ComponentModel.Design;

/// <summary>Represents a collection of <see cref="T:System.ComponentModel.Design.DesignerVerb" /> objects.</summary>
[DefaultMember("Item")]
public class DesignerVerbCollection : CollectionBase
{
	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" /> class.</summary>
	public DesignerVerbCollection()
	{
	}

	/// <summary>Adds the specified <see cref="T:System.ComponentModel.Design.DesignerVerb" /> to the collection.</summary>
	/// <param name="value">The <see cref="T:System.ComponentModel.Design.DesignerVerb" /> to add to the collection.</param>
	/// <returns>The index in the collection at which the verb was added.</returns>
	public int Add(DesignerVerb value)
	{
		return 0;
	}

	/// <summary>Raises the <see langword="Set" /> event.</summary>
	/// <param name="index">The index at which to set the item.</param>
	/// <param name="oldValue">The old object.</param>
	/// <param name="newValue">The new object.</param>
	protected override void OnSet(int index, object oldValue, object newValue)
	{
	}

	/// <summary>Raises the <see langword="Insert" /> event.</summary>
	/// <param name="index">The index at which to insert an item.</param>
	/// <param name="value">The object to insert.</param>
	protected override void OnInsert(int index, object value)
	{
	}

	/// <summary>Raises the <see langword="Clear" /> event.</summary>
	protected override void OnClear()
	{
	}

	/// <summary>Raises the <see langword="Remove" /> event.</summary>
	/// <param name="index">The index at which to remove the item.</param>
	/// <param name="value">The object to remove.</param>
	protected override void OnRemove(int index, object value)
	{
	}

	/// <summary>Raises the <see langword="Validate" /> event.</summary>
	/// <param name="value">The object to validate.</param>
	protected override void OnValidate(object value)
	{
	}
}
