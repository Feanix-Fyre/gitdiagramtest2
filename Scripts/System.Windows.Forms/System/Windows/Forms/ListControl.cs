using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides a common implementation of members for the <see cref="T:System.Windows.Forms.ListBox" /> and <see cref="T:System.Windows.Forms.ComboBox" /> classes.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[LookupBindingProperties("DataSource", "DisplayMember", "ValueMember", "SelectedValue")]
[ComVisible(true)]
public abstract class ListControl : Control
{
	private object data_source;

	private BindingMemberInfo value_member;

	private string display_member;

	private CurrencyManager data_manager;

	private BindingContext last_binding_context;

	private IFormatProvider format_info;

	private string format_string;

	private bool formatting_enabled;

	private static object DataSourceChangedEvent;

	private static object DisplayMemberChangedEvent;

	private static object FormatEvent;

	private static object FormatInfoChangedEvent;

	private static object FormatStringChangedEvent;

	private static object FormattingEnabledChangedEvent;

	private static object SelectedValueChangedEvent;

	private static object ValueMemberChangedEvent;

	/// <summary>Gets or sets the <see cref="T:System.IFormatProvider" /> that provides custom formatting behavior.</summary>
	/// <returns>The <see cref="T:System.IFormatProvider" /> implementation that provides custom formatting behavior.</returns>
	[Browsable(false)]
	[DefaultValue(null)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IFormatProvider FormatInfo => null;

	/// <summary>Gets or sets the format-specifier characters that indicate how a value is to be displayed.</summary>
	/// <returns>The string of format-specifier characters that indicates how a value is to be displayed.</returns>
	[DefaultValue(null)]
	[MergableProperty(false)]
	[Editor("System.Windows.Forms.Design.FormatStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string FormatString => null;

	/// <summary>Gets or sets a value indicating whether formatting is applied to the <see cref="P:System.Windows.Forms.ListControl.DisplayMember" /> property of the <see cref="T:System.Windows.Forms.ListControl" />.</summary>
	/// <returns>
	///   <see langword="true" /> if formatting of the <see cref="P:System.Windows.Forms.ListControl.DisplayMember" /> property is enabled; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool FormattingEnabled => false;

	/// <summary>Gets or sets the property to display for this <see cref="T:System.Windows.Forms.ListControl" />.</summary>
	/// <returns>A <see cref="T:System.String" /> specifying the name of an object property that is contained in the collection specified by the <see cref="P:System.Windows.Forms.ListControl.DataSource" /> property. The default is an empty string ("").</returns>
	[MWFCategory("Data")]
	[DefaultValue(null)]
	[TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string DisplayMember => null;

	/// <summary>When overridden in a derived class, gets or sets the zero-based index of the currently selected item.</summary>
	/// <returns>A zero-based index of the currently selected item. A value of negative one (-1) is returned if no item is selected.</returns>
	public abstract int SelectedIndex { get; set; }

	/// <summary>Gets a value indicating whether the list enables selection of list items.</summary>
	/// <returns>
	///   <see langword="true" /> if the list enables list item selection; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	protected virtual bool AllowSelection => false;

	internal override bool ScaleChildrenInternal => false;

	/// <summary>Gets the <see cref="T:System.Windows.Forms.CurrencyManager" /> associated with this control.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.CurrencyManager" /> associated with this control. The default is <see langword="null" />.</returns>
	protected CurrencyManager DataManager => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListControl" /> class.</summary>
	protected ListControl()
	{
	}

	/// <summary>Returns the current value of the <see cref="T:System.Windows.Forms.ListControl" /> item, if it is a property of an object given the item and the property name.</summary>
	/// <param name="item">The object the <see cref="T:System.Windows.Forms.ListControl" /> item is bound to.</param>
	/// <param name="field">The property name of the item the <see cref="T:System.Windows.Forms.ListControl" /> is bound to.</param>
	/// <returns>The filtered object.</returns>
	protected object FilterItemOnProperty(object item, string field)
	{
		return null;
	}

	/// <summary>Returns the text representation of the specified item.</summary>
	/// <param name="item">The object from which to get the contents to display.</param>
	/// <returns>If the <see cref="P:System.Windows.Forms.ListControl.DisplayMember" /> property is not specified, the value returned by <see cref="M:System.Windows.Forms.ListControl.GetItemText(System.Object)" /> is the value of the item's <see langword="ToString" /> method. Otherwise, the method returns the string value of the member specified in the <see cref="P:System.Windows.Forms.ListControl.DisplayMember" /> property for the object specified in the <paramref name="item" /> parameter.</returns>
	public string GetItemText(object item)
	{
		return null;
	}

	/// <summary>Handles special input keys, such as PAGE UP, PAGE DOWN, HOME, END, and so on.</summary>
	/// <param name="keyData">One of the values of <see cref="T:System.Windows.Forms.Keys" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="keyData" /> parameter specifies the <see cref="F:System.Windows.Forms.Keys.End" />, <see cref="F:System.Windows.Forms.Keys.Home" />, <see cref="F:System.Windows.Forms.Keys.PageUp" />, or <see cref="F:System.Windows.Forms.Keys.PageDown" /> key; <see langword="false" /> if the <paramref name="keyData" /> parameter specifies <see cref="F:System.Windows.Forms.Keys.Alt" />.</returns>
	protected override bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BindingContextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnBindingContextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListControl.Format" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ListControlConvertEventArgs" /> that contains the event data.</param>
	protected virtual void OnFormat(ListControlConvertEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListControl.SelectedValueChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnSelectedIndexChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListControl.SelectedValueChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnSelectedValueChanged(EventArgs e)
	{
	}

	/// <summary>When overridden in a derived class, resynchronizes the data of the object at the specified index with the contents of the data source.</summary>
	/// <param name="index">The zero-based index of the item whose data to refresh.</param>
	protected abstract void RefreshItem(int index);

	/// <summary>When overridden in a derived class, sets the specified array of objects in a collection in the derived class.</summary>
	/// <param name="items">An array of items.</param>
	protected abstract void SetItemsCore(IList items);

	private void ConnectToDataSource()
	{
	}

	private void OnItemChanged(object sender, ItemChangedEventArgs e)
	{
	}

	private void OnPositionChanged(object sender, EventArgs e)
	{
	}
}
