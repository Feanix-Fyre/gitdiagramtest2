using System.ComponentModel;

namespace System.Data;

internal sealed class DataViewManagerListItemTypeDescriptor : ICustomTypeDescriptor
{
	private DataViewManager _dataViewManager;

	private PropertyDescriptorCollection _propsCollection;

	internal DataViewManagerListItemTypeDescriptor(DataViewManager dataViewManager)
	{
	}

	internal DataView GetDataView(DataTable table)
	{
		return null;
	}

	AttributeCollection ICustomTypeDescriptor.GetAttributes()
	{
		return null;
	}

	string ICustomTypeDescriptor.GetClassName()
	{
		return null;
	}

	string ICustomTypeDescriptor.GetComponentName()
	{
		return null;
	}

	TypeConverter ICustomTypeDescriptor.GetConverter()
	{
		return null;
	}

	EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
	{
		return null;
	}

	PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
	{
		return null;
	}

	object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
	{
		return null;
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
	{
		return null;
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
	{
		return null;
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
	{
		return null;
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
	{
		return null;
	}

	object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
	{
		return null;
	}
}
