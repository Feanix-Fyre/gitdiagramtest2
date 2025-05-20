using System.ComponentModel;
using System.Reflection;

namespace System.Windows.Forms;

/// <summary>Provides functionality to discover a bindable list and the properties of the items contained in the list when they differ from the public properties of the object to which they bind.</summary>
public static class ListBindingHelper
{
	/// <summary>Returns a list associated with the specified data source.</summary>
	/// <param name="list">The data source to examine for its underlying list.</param>
	/// <returns>An <see cref="T:System.Object" /> representing the underlying list if it exists; otherwise, the original data source specified by <paramref name="list" />.</returns>
	public static object GetList(object list)
	{
		return null;
	}

	/// <summary>Returns the data type of the items in the specified list.</summary>
	/// <param name="list">The list to be examined for type information.</param>
	/// <returns>The <see cref="T:System.Type" /> of the items contained in the list.</returns>
	public static Type GetListItemType(object list)
	{
		return null;
	}

	/// <summary>Returns the data type of the items in the specified data source.</summary>
	/// <param name="dataSource">The data source to examine for items.</param>
	/// <param name="dataMember">The optional name of the property on the data source that is to be used as the data member. This can be <see langword="null" />.</param>
	/// <returns>For complex data binding, the <see cref="T:System.Type" /> of the items represented by the <paramref name="dataMember" /> in the data source; otherwise, the <see cref="T:System.Type" /> of the item in the list itself.</returns>
	public static Type GetListItemType(object dataSource, string dataMember)
	{
		return null;
	}

	/// <summary>Returns the <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that describes the properties of an item type contained in a specified data source, or properties of the specified data source.</summary>
	/// <param name="list">The data source to examine for property information.</param>
	/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> containing the properties of the items contained in <paramref name="list" />, or properties of <paramref name="list." /></returns>
	public static PropertyDescriptorCollection GetListItemProperties(object list)
	{
		return null;
	}

	/// <summary>Returns the <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that describes the properties of an item type contained in a collection property of a data source. Uses the specified <see cref="T:System.ComponentModel.PropertyDescriptor" /> array to indicate which properties to examine.</summary>
	/// <param name="list">The data source to be examined for property information.</param>
	/// <param name="listAccessors">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> array describing which properties of the data source to examine. This can be <see langword="null" />.</param>
	/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> describing the properties of the item type contained in a collection property of the data source.</returns>
	public static PropertyDescriptorCollection GetListItemProperties(object list, PropertyDescriptor[] listAccessors)
	{
		return null;
	}

	private static PropertyDescriptor GetProperty(object obj, string property_name)
	{
		return null;
	}

	private static PropertyInfo GetPropertyByReflection(Type type, string property_name)
	{
		return null;
	}
}
