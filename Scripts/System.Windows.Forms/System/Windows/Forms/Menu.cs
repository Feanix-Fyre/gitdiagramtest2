using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Represents the base functionality for all menus. Although <see cref="T:System.Windows.Forms.ToolStripDropDown" /> and <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" /> replace and add functionality to the <see cref="T:System.Windows.Forms.Menu" /> control of previous versions, <see cref="T:System.Windows.Forms.Menu" /> is retained for both backward compatibility and future use if you choose.</summary>
[ToolboxItemFilter("System.Windows.Forms", ToolboxItemFilterType.Allow)]
[ListBindable(false)]
public abstract class Menu : Component
{
	/// <summary>Represents a collection of <see cref="T:System.Windows.Forms.MenuItem" /> objects.</summary>
	[ListBindable(false)]
	public class MenuItemCollection : ICollection, IEnumerable, IList
	{
		private Menu owner;

		private ArrayList items;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Windows.Forms.Menu.MenuItemCollection" />.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</summary>
		/// <param name="index">The zero-based index of the element to get.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.MenuItem" /> at the specified index.</returns>
		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets a value indicating the total number of <see cref="T:System.Windows.Forms.MenuItem" /> objects in the collection.</summary>
		/// <returns>The number of <see cref="T:System.Windows.Forms.MenuItem" /> objects in the collection.</returns>
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Retrieves the <see cref="T:System.Windows.Forms.MenuItem" /> at the specified indexed location in the collection.</summary>
		/// <param name="index">The indexed location of the <see cref="T:System.Windows.Forms.MenuItem" /> in the collection.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.MenuItem" /> at the specified location.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="value" /> parameter is <see langword="null" />.  
		///  or  
		///  The <paramref name="index" /> parameter is less than zero.  
		///  or  
		///  The <paramref name="index" /> parameter is greater than the number of menu items in the collection, and the collection of menu items is not <see langword="null" />.</exception>
		public virtual MenuItem this[int index] => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Menu.MenuItemCollection" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.Menu" /> that owns this collection.</param>
		public MenuItemCollection(Menu owner)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.MenuItem" /> to add to the collection.</param>
		/// <returns>The position into which the <see cref="T:System.Windows.Forms.MenuItem" /> was inserted.</returns>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</summary>
		/// <param name="value">The object to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified object is a <see cref="T:System.Windows.Forms.MenuItem" /> in the collection; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object value)
		{
			return false;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.MenuItem" /> to locate in the collection.</param>
		/// <returns>The zero-based index if <paramref name="value" /> is a <see cref="T:System.Windows.Forms.MenuItem" /> in the collection; otherwise -1.</returns>
		int IList.IndexOf(object value)
		{
			return 0;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Insert(System.Int32,System.Object)" />.</summary>
		/// <param name="index">The zero-based index at which the <see cref="T:System.Windows.Forms.MenuItem" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Windows.Forms.MenuItem" /> to insert into the <see cref="T:System.Windows.Forms.Menu.MenuItemCollection" />.</param>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Remove(System.Object)" />.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.MenuItem" /> to remove.</param>
		void IList.Remove(object value)
		{
		}

		/// <summary>Adds a previously created <see cref="T:System.Windows.Forms.MenuItem" /> to the end of the current menu.</summary>
		/// <param name="item">The <see cref="T:System.Windows.Forms.MenuItem" /> to add.</param>
		/// <returns>The zero-based index where the item is stored in the collection.</returns>
		public virtual int Add(MenuItem item)
		{
			return 0;
		}

		internal void AddNoEvents(MenuItem mi)
		{
		}

		/// <summary>Adds a previously created <see cref="T:System.Windows.Forms.MenuItem" /> at the specified index within the menu item collection.</summary>
		/// <param name="index">The position to add the new item.</param>
		/// <param name="item">The <see cref="T:System.Windows.Forms.MenuItem" /> to add.</param>
		/// <returns>The zero-based index where the item is stored in the collection.</returns>
		/// <exception cref="T:System.Exception">The <see cref="T:System.Windows.Forms.MenuItem" /> being added is already in use.</exception>
		/// <exception cref="T:System.ArgumentException">The index supplied in the <paramref name="index" /> parameter is larger than the size of the collection.</exception>
		public virtual int Add(int index, MenuItem item)
		{
			return 0;
		}

		private void UpdateItem(MenuItem mi)
		{
		}

		internal void Insert(int index, MenuItem mi)
		{
		}

		/// <summary>Adds an array of previously created <see cref="T:System.Windows.Forms.MenuItem" /> objects to the collection.</summary>
		/// <param name="items">An array of <see cref="T:System.Windows.Forms.MenuItem" /> objects representing the menu items to add to the collection.</param>
		public virtual void AddRange(MenuItem[] items)
		{
		}

		/// <summary>Removes all <see cref="T:System.Windows.Forms.MenuItem" /> objects from the menu item collection.</summary>
		public virtual void Clear()
		{
		}

		/// <summary>Determines if the specified <see cref="T:System.Windows.Forms.MenuItem" /> is a member of the collection.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.MenuItem" /> to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.MenuItem" /> is a member of the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(MenuItem value)
		{
			return false;
		}

		/// <summary>Copies the entire collection into an existing array at a specified location within the array.</summary>
		/// <param name="dest">The destination array.</param>
		/// <param name="index">The index in the destination array at which storing begins.</param>
		public void CopyTo(Array dest, int index)
		{
		}

		/// <summary>Returns an enumerator that can be used to iterate through the menu item collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the menu item collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Retrieves the index of a specific item in the collection.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.MenuItem" /> to locate in the collection.</param>
		/// <returns>The zero-based index of the item found in the collection; otherwise, -1.</returns>
		public int IndexOf(MenuItem value)
		{
			return 0;
		}

		/// <summary>Removes the specified <see cref="T:System.Windows.Forms.MenuItem" /> from the menu item collection.</summary>
		/// <param name="item">The <see cref="T:System.Windows.Forms.MenuItem" /> to remove.</param>
		public virtual void Remove(MenuItem item)
		{
		}

		/// <summary>Removes a <see cref="T:System.Windows.Forms.MenuItem" /> from the menu item collection at a specified index.</summary>
		/// <param name="index">The index of the <see cref="T:System.Windows.Forms.MenuItem" /> to remove.</param>
		public virtual void RemoveAt(int index)
		{
		}

		private void UpdateItemsIndices()
		{
		}
	}

	internal MenuItemCollection menu_items;

	internal IntPtr menu_handle;

	internal Menu parent_menu;

	private Rectangle rect;

	internal Control Wnd;

	internal MenuTracker tracker;

	private string control_name;

	private object control_tag;

	/// <summary>Gets a value indicating the collection of <see cref="T:System.Windows.Forms.MenuItem" /> objects associated with the menu.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Menu.MenuItemCollection" /> that represents the list of <see cref="T:System.Windows.Forms.MenuItem" /> objects stored in the menu.</returns>
	[MergableProperty(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public MenuItemCollection MenuItems => null;

	/// <summary>Gets or sets the name of the <see cref="T:System.Windows.Forms.Menu" />.</summary>
	/// <returns>A string representing the name.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets user-defined data associated with the control.</summary>
	/// <returns>An object representing the data.</returns>
	[MWFCategory("Data")]
	[DefaultValue(null)]
	[TypeConverter(typeof(StringConverter))]
	[Bindable(true)]
	[Localizable(false)]
	public object Tag
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Rectangle Rect => default(Rectangle);

	internal MenuItem SelectedItem => null;

	internal int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int X
	{
		set
		{
		}
	}

	internal int Y
	{
		set
		{
		}
	}

	internal MenuTracker Tracker => null;

	internal event EventHandler MenuChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Menu" /> class.</summary>
	/// <param name="items">An array of type <see cref="T:System.Windows.Forms.MenuItem" /> containing the objects to add to the menu.</param>
	protected Menu(MenuItem[] items)
	{
	}

	internal virtual void OnMenuChanged(EventArgs e)
	{
	}

	/// <summary>Copies the <see cref="T:System.Windows.Forms.Menu" /> that is passed as a parameter to the current <see cref="T:System.Windows.Forms.Menu" />.</summary>
	/// <param name="menuSrc">The <see cref="T:System.Windows.Forms.Menu" /> to copy.</param>
	protected void CloneMenu(Menu menuSrc)
	{
	}

	/// <summary>Disposes of the resources, other than memory, used by the <see cref="T:System.Windows.Forms.Menu" />.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Returns the position at which a menu item should be inserted into the menu.</summary>
	/// <param name="mergeOrder">The merge order position for the menu item to be merged.</param>
	/// <returns>The position at which a menu item should be inserted into the menu.</returns>
	protected int FindMergePosition(int mergeOrder)
	{
		return 0;
	}

	/// <summary>Gets the <see cref="T:System.Windows.Forms.MainMenu" /> that contains this menu.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.MainMenu" /> that contains this menu.</returns>
	public MainMenu GetMainMenu()
	{
		return null;
	}

	internal virtual void InvalidateItem(MenuItem item)
	{
	}

	/// <summary>Merges the <see cref="T:System.Windows.Forms.MenuItem" /> objects of one menu with the current menu.</summary>
	/// <param name="menuSrc">The <see cref="T:System.Windows.Forms.Menu" /> whose menu items are merged with the menu items of the current menu.</param>
	/// <exception cref="T:System.ArgumentException">It was attempted to merge the menu with itself.</exception>
	public virtual void MergeMenu(Menu menuSrc)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />, passed by reference that represents the window message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed by the control; otherwise, <see langword="false" />.</returns>
	protected internal virtual bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return false;
	}

	/// <summary>Returns a <see cref="T:System.String" /> that represents the <see cref="T:System.Windows.Forms.Menu" /> control.</summary>
	/// <returns>A <see cref="T:System.String" /> that represents the current <see cref="T:System.Windows.Forms.Menu" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
