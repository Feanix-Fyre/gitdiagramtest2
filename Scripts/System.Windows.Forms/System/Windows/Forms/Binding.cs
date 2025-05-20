using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Represents the simple binding between the property value of an object and the property value of a control.</summary>
[TypeConverter(typeof(ListBindingConverter))]
public class Binding
{
	private string property_name;

	private object data_source;

	private string data_member;

	private bool is_binding;

	private bool checked_isnull;

	private BindingMemberInfo binding_member_info;

	private IBindableComponent control;

	private BindingManagerBase manager;

	private PropertyDescriptor control_property;

	private PropertyDescriptor is_null_desc;

	private object data;

	private Type data_type;

	private DataSourceUpdateMode datasource_update_mode;

	private ControlUpdateMode control_update_mode;

	private object datasource_null_value;

	private object null_value;

	private IFormatProvider format_info;

	private string format_string;

	private bool formatting_enabled;

	private ConvertEventHandler Format;

	private ConvertEventHandler Parse;

	private BindingCompleteEventHandler BindingComplete;

	/// <summary>Gets the control the <see cref="T:System.Windows.Forms.Binding" /> is associated with.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.IBindableComponent" /> the <see cref="T:System.Windows.Forms.Binding" /> is associated with.</returns>
	[DefaultValue(null)]
	public IBindableComponent BindableComponent => null;

	/// <summary>Gets the control that the binding belongs to.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Control" /> that the binding belongs to.</returns>
	[DefaultValue(null)]
	public Control Control => null;

	/// <summary>Gets a value indicating whether the binding is active.</summary>
	/// <returns>
	///   <see langword="true" /> if the binding is active; otherwise, <see langword="false" />.</returns>
	public bool IsBinding => false;

	/// <summary>Gets or sets the name of the control's data-bound property.</summary>
	/// <returns>The name of a control property to bind to.</returns>
	[DefaultValue(null)]
	public string PropertyName => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Binding" /> class that simple-binds the indicated control property to the specified data member of the data source.</summary>
	/// <param name="propertyName">The name of the control property to bind.</param>
	/// <param name="dataSource">An <see cref="T:System.Object" /> that represents the data source.</param>
	/// <param name="dataMember">The property or list to bind to.</param>
	/// <exception cref="T:System.Exception">
	///   <paramref name="propertyName" /> is neither a valid property of a control nor an empty string ("").</exception>
	/// <exception cref="T:System.ArgumentException">The property given by <paramref name="propertyName" /> does not exist on the control.</exception>
	public Binding(string propertyName, object dataSource, string dataMember)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Binding" /> class with the specified control property to the specified data member of the specified data source. Optionally enables formatting with the specified format string; propagates values to the data source based on the specified update setting; enables formatting with the specified format string; sets the property to the specified value when a <see cref="T:System.DBNull" /> is returned from the data source; and sets the specified format provider.</summary>
	/// <param name="propertyName">The name of the control property to bind.</param>
	/// <param name="dataSource">An <see cref="T:System.Object" /> representing the data source.</param>
	/// <param name="dataMember">The property or list to bind to.</param>
	/// <param name="formattingEnabled">
	///   <see langword="true" /> to format the displayed data; otherwise, <see langword="false" />.</param>
	/// <param name="dataSourceUpdateMode">One of the <see cref="T:System.Windows.Forms.DataSourceUpdateMode" /> values.</param>
	/// <param name="nullValue">The <see cref="T:System.Object" /> to be applied to the bound control property if the data source value is <see cref="T:System.DBNull" />.</param>
	/// <param name="formatString">One or more format specifier characters that indicate how a value is to be displayed.</param>
	/// <param name="formatInfo">An implementation of <see cref="T:System.IFormatProvider" /> to override default formatting behavior.</param>
	/// <exception cref="T:System.ArgumentException">The property given by <paramref name="propertyName" /> does not exist on the control.  
	///  -or-  
	///  The data source or data member or control property specified are associated with another binding in the collection.</exception>
	public Binding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString, IFormatProvider formatInfo)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Binding.BindingComplete" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.BindingCompleteEventArgs" /> that contains the event data.</param>
	protected virtual void OnBindingComplete(BindingCompleteEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Binding.Format" /> event.</summary>
	/// <param name="cevent">A <see cref="T:System.Windows.Forms.ConvertEventArgs" /> that contains the event data.</param>
	protected virtual void OnFormat(ConvertEventArgs cevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Binding.Parse" /> event.</summary>
	/// <param name="cevent">A <see cref="T:System.Windows.Forms.ConvertEventArgs" /> that contains the event data.</param>
	protected virtual void OnParse(ConvertEventArgs cevent)
	{
	}

	internal void SetControl(IBindableComponent control)
	{
	}

	internal void Check()
	{
	}

	internal bool PullData()
	{
		return false;
	}

	private bool PullData(bool force)
	{
		return false;
	}

	internal void PushData()
	{
	}

	private void PushData(bool force)
	{
	}

	internal void UpdateIsBinding()
	{
	}

	private void SetControlValue(object data)
	{
	}

	private void SetPropertyValue(object data)
	{
	}

	private void ControlValidatingHandler(object sender, CancelEventArgs e)
	{
	}

	private void ControlCreatedHandler(object o, EventArgs args)
	{
	}

	private void PositionChangedHandler(object sender, EventArgs e)
	{
	}

	private EventDescriptor GetPropertyChangedEvent(object o, string property_name)
	{
		return null;
	}

	private void SourcePropertyChangedHandler(object o, EventArgs args)
	{
	}

	private void ControlPropertyChangedHandler(object o, EventArgs args)
	{
	}

	private object ParseData(object data, Type data_type)
	{
		return null;
	}

	private object FormatData(object data)
	{
		return null;
	}

	private object ConvertData(object data, Type data_type)
	{
		return null;
	}

	private void FireBindingComplete(BindingCompleteContext context, Exception exc, string error_message)
	{
	}
}
