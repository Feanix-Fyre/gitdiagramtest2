using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Windows.Forms;

/// <summary>Manages a list of <see cref="T:System.Windows.Forms.Binding" /> objects.</summary>
[DefaultMember("Item")]
public class CurrencyManager : BindingManagerBase
{
	/// <summary>Specifies the current position of the <see cref="T:System.Windows.Forms.CurrencyManager" /> in the list.</summary>
	protected int listposition;

	/// <summary>Specifies the data type of the list.</summary>
	protected Type finalType;

	private IList list;

	private bool binding_suspended;

	private object data_source;

	private bool editing;

	private ListChangedEventHandler ListChanged;

	private EventHandler MetaDataChanged;

	/// <summary>Gets the list for this <see cref="T:System.Windows.Forms.CurrencyManager" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IList" /> that contains the list.</returns>
	public IList List => null;

	/// <summary>Gets the current item in the list.</summary>
	/// <returns>A list item of type <see cref="T:System.Object" />.</returns>
	public override object Current => null;

	/// <summary>Gets the number of items in the list.</summary>
	/// <returns>The number of items in the list.</returns>
	public override int Count => 0;

	/// <summary>Gets or sets the position you are at within the list.</summary>
	/// <returns>A number between 0 and <see cref="P:System.Windows.Forms.CurrencyManager.Count" /> minus 1.</returns>
	public override int Position
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal override bool IsSuspended => false;

	/// <summary>Occurs when the current item has been altered.</summary>
	public event ItemChangedEventHandler ItemChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	internal CurrencyManager(object data_source)
	{
	}

	internal void SetDataSource(object data_source)
	{
	}

	/// <summary>Gets the property descriptor collection for the underlying list.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> for the list.</returns>
	public override PropertyDescriptorCollection GetItemProperties()
	{
		return null;
	}

	private void BeginEdit()
	{
	}

	/// <summary>Ends the current edit operation.</summary>
	public override void EndCurrentEdit()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingManagerBase.CurrentChanged" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal override void OnCurrentChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingManagerBase.CurrentItemChanged" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnCurrentItemChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.CurrencyManager.ItemChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.ItemChangedEventArgs" /> that contains the event data.</param>
	protected virtual void OnItemChanged(ItemChangedEventArgs e)
	{
	}

	private void OnListChanged(ListChangedEventArgs args)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingManagerBase.PositionChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnPositionChanged(EventArgs e)
	{
	}

	/// <summary>Updates the status of the binding.</summary>
	protected override void UpdateIsBinding()
	{
	}

	private void ChangeRecordState(int newPosition, bool validating, bool endCurrentEdit, bool firePositionChanged, bool pullData)
	{
	}

	private void UpdateItem()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.CurrencyManager.MetaDataChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected void OnMetaDataChanged(EventArgs e)
	{
	}

	private void ListChangedHandler(object sender, ListChangedEventArgs e)
	{
	}
}
