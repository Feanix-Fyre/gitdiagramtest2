using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a Windows list view control, which displays a collection of items that can be displayed using one of four different views.</summary>
[Designer("System.Windows.Forms.Design.ListViewDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Docking(DockingBehavior.Ask)]
[DefaultEvent("SelectedIndexChanged")]
[DefaultProperty("Items")]
[ComVisible(true)]
public class ListView : Control
{
	internal class ItemControl : Control
	{
		private enum BoxSelect
		{
			None = 0,
			Normal = 1,
			Shift = 2,
			Control = 3
		}

		private ListView owner;

		private ListViewItem clicked_item;

		private ListViewItem last_clicked_item;

		private bool hover_processed;

		private bool checking;

		private ListViewItem prev_hovered_item;

		private ListViewItem prev_tooltip_item;

		private int clicks;

		private Point drag_begin;

		internal int dragged_item_index;

		private ListViewLabelEditTextBox edit_text_box;

		internal ListViewItem edit_item;

		private LabelEditEventArgs edit_args;

		private BoxSelect box_select_mode;

		private IList prev_selection;

		private Point box_select_start;

		private Rectangle box_select_rect;

		internal Rectangle BoxSelectRectangle
		{
			get
			{
				return default(Rectangle);
			}
			set
			{
			}
		}

		private ArrayList BoxSelectedItems => null;

		public ItemControl(ListView owner)
		{
		}

		private void ItemsDoubleClick(object sender, EventArgs e)
		{
		}

		private void InvalidateBoxSelectRect()
		{
		}

		private Rectangle CalculateBoxSelectRectangle(Point pt)
		{
			return default(Rectangle);
		}

		private bool BoxIntersectsItem(int index)
		{
			return false;
		}

		private bool BoxIntersectsText(int index)
		{
			return false;
		}

		private bool PerformBoxSelection(Point pt)
		{
			return false;
		}

		private void ItemsMouseDown(object sender, MouseEventArgs me)
		{
		}

		private void ItemsMouseMove(object sender, MouseEventArgs me)
		{
		}

		private void ItemsMouseHover(object sender, EventArgs e)
		{
		}

		private void HandleClicks(MouseEventArgs me)
		{
		}

		private void ItemsMouseUp(object sender, MouseEventArgs me)
		{
		}

		private void ResetMouseState()
		{
		}

		private void LabelEditFinished(object sender, EventArgs e)
		{
		}

		private void LabelEditCancelled(object sender, EventArgs e)
		{
		}

		private void LabelTextChanged(object sender, EventArgs e)
		{
		}

		internal void BeginEdit(ListViewItem item)
		{
		}

		internal void CancelEdit(ListViewItem item)
		{
		}

		internal void EndEdit(ListViewItem item)
		{
		}

		internal override void OnPaintInternal(PaintEventArgs pe)
		{
		}

		protected override void WndProc(ref Message m)
		{
		}
	}

	internal class ListViewLabelEditTextBox : TextBox
	{
		private int max_width;

		private int min_width;

		private int max_height;

		private int min_height;

		private int old_number_lines;

		private SizeF text_size_one_char;

		public int MaxWidth
		{
			set
			{
			}
		}

		public int MaxHeight
		{
			set
			{
			}
		}

		public new int Width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override Font Font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event EventHandler EditingCancelled
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler EditingFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
		}

		protected override bool IsInputKey(Keys key_data)
		{
			return false;
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
		}

		protected override void OnLostFocus(EventArgs e)
		{
		}

		protected void OnEditingCancelled(EventArgs e)
		{
		}

		protected void OnEditingFinished(EventArgs e)
		{
		}

		private void ResizeTextBoxWidth(int new_width)
		{
		}

		private void ResizeTextBoxHeight(int new_height)
		{
		}

		public void Reset()
		{
		}
	}

	internal class HeaderControl : Control
	{
		private ListView owner;

		private bool column_resize_active;

		private ColumnHeader resize_column;

		private ColumnHeader clicked_column;

		private ColumnHeader drag_column;

		private int drag_x;

		private int drag_to_index;

		private ColumnHeader entered_column_header;

		internal ColumnHeader EnteredColumnHeader
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public HeaderControl(ListView owner)
		{
		}

		private void OnMouseLeave(object sender, EventArgs e)
		{
		}

		private ColumnHeader ColumnAtX(int x)
		{
			return null;
		}

		private int GetReorderedIndex(ColumnHeader col)
		{
			return 0;
		}

		private void HeaderMouseDown(object sender, MouseEventArgs me)
		{
		}

		private void Invalidate(ColumnHeader columnHeader)
		{
		}

		private Rectangle GetColumnHeaderInvalidateArea(ColumnHeader columnHeader)
		{
			return default(Rectangle);
		}

		private void StopResize()
		{
		}

		private void HeaderMouseMove(object sender, MouseEventArgs me)
		{
		}

		private void HeaderMouseUp(object sender, MouseEventArgs me)
		{
		}

		internal override void OnPaintInternal(PaintEventArgs pe)
		{
		}

		protected override void WndProc(ref Message m)
		{
		}
	}

	private class ItemComparer
	{
	}

	/// <summary>Represents the collection containing the indexes to the checked items in a list view control.</summary>
	[ListBindable(false)]
	public class CheckedIndexCollection : ICollection, IEnumerable, IList
	{
		private readonly ListView owner;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection of controls.</summary>
		/// <returns>The object used to synchronize the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" /> has a fixed size.</summary>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets an object in the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The object from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> that is stored at the specified location.</returns>
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

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets the index value at the specified index within the collection.</summary>
		/// <param name="index">The index of the item in the collection to retrieve.</param>
		/// <returns>The index value from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> that is stored at the specified location.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.CheckedIndexCollection.Count" /> property of <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />.</exception>
		public int this[int index] => 0;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" /> class.</summary>
		/// <param name="owner">A <see cref="T:System.Windows.Forms.ListView" /> control that owns the collection.</param>
		public CheckedIndexCollection(ListView owner)
		{
		}

		/// <summary>Copies the collection of checked-item indexes into an array.</summary>
		/// <param name="dest">An array of type <see cref="T:System.Int32" />.</param>
		/// <param name="index">The zero-based index in the array at which copying begins.</param>
		/// <exception cref="T:System.ArrayTypeMismatchException">The array type cannot be cast to an <see cref="T:System.Int32" />.</exception>
		void ICollection.CopyTo(Array dest, int index)
		{
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <param name="value">The object to add to the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />.</param>
		/// <returns>The zero-based index where <paramref name="value" /> is located in the collection.</returns>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>Removes all items from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Clear()
		{
		}

		/// <summary>Checks whether the index corresponding with the <see cref="T:System.Windows.Forms.ListViewItem" /> is checked.</summary>
		/// <param name="checkedIndex">An index to locate in the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />.</param>
		/// <returns>
		///   <see langword="true" /> if the index is found in the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object checkedIndex)
		{
			return false;
		}

		/// <summary>Returns the index of the specified object in the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />.</summary>
		/// <param name="checkedIndex">The zero-based index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> to locate in the collection.</param>
		/// <returns>The zero-based index in the collection where the specified index of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> is located if it is in the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />; otherwise, -1.</returns>
		int IList.IndexOf(object checkedIndex)
		{
			return 0;
		}

		/// <summary>Inserts an item into the collection at a specified index.</summary>
		/// <param name="index">The index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The object to be added to the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Removes the first occurrence of an item from the collection.</summary>
		/// <param name="value">The object to be removed from the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Remove(object value)
		{
		}

		/// <summary>Removes an item from the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.RemoveAt(int index)
		{
		}

		/// <summary>Determines whether the specified index is located in the collection.</summary>
		/// <param name="checkedIndex">The index to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> for the <see cref="T:System.Windows.Forms.ListView" /> is an item in the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(int checkedIndex)
		{
			return false;
		}

		/// <summary>Returns an enumerator that can be used to iterate through the checked index collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the checked index collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns the index within the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" /> of the specified index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> of the list view control.</summary>
		/// <param name="checkedIndex">The zero-based index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> to locate in the collection.</param>
		/// <returns>The zero-based index in the collection where the specified index of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> is located within the <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection" />; otherwise, -1 if the index is not located in the collection.</returns>
		public int IndexOf(int checkedIndex)
		{
			return 0;
		}

		private int[] GetIndices()
		{
			return null;
		}
	}

	/// <summary>Represents the collection of checked items in a list view control.</summary>
	[ListBindable(false)]
	public class CheckedListViewItemCollection : ICollection, IEnumerable, IList
	{
		private readonly ListView owner;

		private ArrayList list;

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection of controls.</summary>
		/// <returns>The object used to synchronize the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets an object from the collection.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item located at the specified index within the collection.</returns>
		/// <exception cref="T:System.NotSupportedException">This property cannot be set.</exception>
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

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets the item at the specified index within the collection.</summary>
		/// <param name="index">The index of the item in the collection to retrieve.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.CheckedListViewItemCollection.Count" /> property of <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Windows.Forms.ListView" /> is in virtual mode.</exception>
		public ListViewItem this[int index] => null;

		internal ArrayList List => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.ListView" /> control that owns the collection.</param>
		public CheckedListViewItemCollection(ListView owner)
		{
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <param name="value">The item to add to the collection.</param>
		/// <returns>The zero-based index where value is located in the collection.</returns>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>Removes all items from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Clear()
		{
		}

		/// <summary>Verifies whether the item is checked.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> to locate in the <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" />.</param>
		/// <returns>
		///   <see langword="true" /> if item is found in the <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" />; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object item)
		{
			return false;
		}

		/// <summary>Returns the index within the collection of the specified item.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item to locate in the collection.</param>
		/// <returns>The zero-based index of the item if it is in the collection; otherwise, -1.</returns>
		int IList.IndexOf(object item)
		{
			return 0;
		}

		/// <summary>Inserts an item into the collection at a specified index.</summary>
		/// <param name="index">The index at which value should be inserted.</param>
		/// <param name="value">The object to be added to the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Removes the first occurrence of an item from the collection.</summary>
		/// <param name="value">The object to be removed from the <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Remove(object value)
		{
		}

		/// <summary>Removes an item from the collection at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.RemoveAt(int index)
		{
		}

		/// <summary>Determines whether the specified item is located in the collection.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified item is located in the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(ListViewItem item)
		{
			return false;
		}

		/// <summary>Copies the entire collection into an existing array at a specified location within the array.</summary>
		/// <param name="dest">An <see cref="T:System.Array" /> representing the array to copy the contents of the collection to.</param>
		/// <param name="index">The location within the destination array to copy the items from the collection to.</param>
		public void CopyTo(Array dest, int index)
		{
		}

		/// <summary>Returns an enumerator that can be used to iterate through the checked item collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the checked item collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns the index within the collection of the specified item.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item to locate in the collection.</param>
		/// <returns>The zero-based index of the item in the collection; otherwise, -1.</returns>
		public int IndexOf(ListViewItem item)
		{
			return 0;
		}

		internal void Reset()
		{
		}

		private void ItemsCollection_Changed()
		{
		}
	}

	/// <summary>Represents the collection of column headers in a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
	[ListBindable(false)]
	public class ColumnHeaderCollection : ICollection, IEnumerable, IList
	{
		internal ArrayList list;

		private ListView owner;

		private static object UIACollectionChangedEvent;

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection of controls.</summary>
		/// <returns>The object used to synchronize the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" /> has a fixed size.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets the column header at the specified index within the collection.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ColumnHeader" /> that represents the column header located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ColumnHeaderCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" />.</exception>
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

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets the column header at the specified index within the collection.</summary>
		/// <param name="index">The index of the column header to retrieve from the collection.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ColumnHeader" /> representing the column header located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ColumnHeaderCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" />.</exception>
		public virtual ColumnHeader this[int index] => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.ListView" /> that owns this collection.</param>
		public ColumnHeaderCollection(ListView owner)
		{
		}

		/// <summary>Copies the <see cref="T:System.Windows.Forms.ColumnHeader" /> objects in the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" /> to an array, starting at a particular array index.</summary>
		/// <param name="dest">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in the array at which copying begins.</param>
		void ICollection.CopyTo(Array dest, int index)
		{
		}

		/// <summary>Adds a <see cref="T:System.Windows.Forms.ColumnHeader" /> to the <see cref="T:System.Windows.Forms.ListView" />.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.ColumnHeader" /> to be added to the <see cref="T:System.Windows.Forms.ListView" />.</param>
		/// <returns>The zero-based index indicating the location of the object that was added to the collection</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.Windows.Forms.ColumnHeader" />.</exception>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>Determines whether the specified column header is located in the collection.</summary>
		/// <param name="value">An object that represents the column header to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the object is a column header that is contained in the collection; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object value)
		{
			return false;
		}

		/// <summary>Returns the index, within the collection, of the specified column header.</summary>
		/// <param name="value">An object that represents the column header to locate in the collection.</param>
		int IList.IndexOf(object value)
		{
			return 0;
		}

		/// <summary>Inserts an existing column header into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the column header is inserted.</param>
		/// <param name="value">The <see cref="T:System.Windows.Forms.ColumnHeader" /> to insert into the collection.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ColumnHeaderCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" />.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Removes the specified column header from the collection.</summary>
		/// <param name="value">A <see cref="T:System.Windows.Forms.ColumnHeader" /> that represents the column header to remove from the collection.</param>
		void IList.Remove(object value)
		{
		}

		internal void OnUIACollectionChangedEvent(CollectionChangeEventArgs args)
		{
		}

		/// <summary>Adds an existing <see cref="T:System.Windows.Forms.ColumnHeader" /> to the collection.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.ColumnHeader" /> to add to the collection.</param>
		/// <returns>The zero-based index into the collection where the item was added.</returns>
		public virtual int Add(ColumnHeader value)
		{
			return 0;
		}

		/// <summary>Adds an array of column headers to the collection.</summary>
		/// <param name="values">An array of <see cref="T:System.Windows.Forms.ColumnHeader" /> objects to add to the collection.</param>
		public virtual void AddRange(ColumnHeader[] values)
		{
		}

		/// <summary>Removes all column headers from the collection.</summary>
		public virtual void Clear()
		{
		}

		/// <summary>Determines whether the specified column header is located in the collection.</summary>
		/// <param name="value">A <see cref="T:System.Windows.Forms.ColumnHeader" /> representing the column header to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the column header is contained in the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(ColumnHeader value)
		{
			return false;
		}

		/// <summary>Returns an enumerator to use to iterate through the column header collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the column header collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns the index, within the collection, of the specified column header.</summary>
		/// <param name="value">A <see cref="T:System.Windows.Forms.ColumnHeader" /> representing the column header to locate in the collection.</param>
		/// <returns>The zero-based index of the column header's location in the collection. If the column header is not located in the collection, the return value is -1.</returns>
		public int IndexOf(ColumnHeader value)
		{
			return 0;
		}

		/// <summary>Inserts an existing column header into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the column header is inserted.</param>
		/// <param name="value">The <see cref="T:System.Windows.Forms.ColumnHeader" /> to insert into the collection.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ColumnHeaderCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" />.</exception>
		public void Insert(int index, ColumnHeader value)
		{
		}

		/// <summary>Removes the specified column header from the collection.</summary>
		/// <param name="column">A <see cref="T:System.Windows.Forms.ColumnHeader" /> representing the column header to remove from the collection.</param>
		public virtual void Remove(ColumnHeader column)
		{
		}

		/// <summary>Removes the column header at the specified index within the collection.</summary>
		/// <param name="index">The zero-based index of the column header to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ColumnHeaderCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" />.</exception>
		public virtual void RemoveAt(int index)
		{
		}
	}

	/// <summary>Represents the collection of items in a <see cref="T:System.Windows.Forms.ListView" /> control or assigned to a <see cref="T:System.Windows.Forms.ListViewGroup" />.</summary>
	[ListBindable(false)]
	public class ListViewItemCollection : ICollection, IEnumerable, IList
	{
		private readonly ArrayList list;

		private ListView owner;

		private ListViewGroup group;

		private static object UIACollectionChangedEvent;

		private bool is_main_collection;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection of controls.</summary>
		/// <returns>The object used to synchronize the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ListViewItem" /> at the specified index within the collection.</summary>
		/// <param name="index">The zero-based index of the element to get.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index parameter is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ListViewItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" />.</exception>
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

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets or sets the item at the specified index within the collection.</summary>
		/// <param name="index">The index of the item in the collection to get or set.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ListViewItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" />.</exception>
		public virtual ListViewItem this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ListView Owner
		{
			set
			{
			}
		}

		internal event CollectionChangedHandler Changed
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

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.ListView" /> that owns the collection.</param>
		public ListViewItemCollection(ListView owner)
		{
		}

		internal ListViewItemCollection(ListView owner, ListViewGroup group)
		{
		}

		/// <summary>Adds an existing object to the collection.</summary>
		/// <param name="item">The object to add to the collection.</param>
		/// <returns>The zero-based index indicating the location of the object if it was added to the collection; otherwise, -1.</returns>
		int IList.Add(object item)
		{
			return 0;
		}

		/// <summary>Determines whether the specified item is in the collection.</summary>
		/// <param name="item">An object that represents the item to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified item is located in the collection; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object item)
		{
			return false;
		}

		/// <summary>Returns the index within the collection of the specified item.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item to locate in the collection.</param>
		/// <returns>The zero-based index of the item if it is in the collection; otherwise, -1.</returns>
		int IList.IndexOf(object item)
		{
			return 0;
		}

		/// <summary>Inserts an object into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the item is inserted.</param>
		/// <param name="item">The object that represents the item to insert.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index parameter is less than 0 or greater than the value of the <see cref="P:System.Windows.Forms.ListView.ListViewItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" />.</exception>
		void IList.Insert(int index, object item)
		{
		}

		/// <summary>Removes the specified item from the collection.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item to remove from the collection.</param>
		void IList.Remove(object item)
		{
		}

		internal void OnUIACollectionChangedEvent(CollectionChangeEventArgs args)
		{
		}

		/// <summary>Adds an existing <see cref="T:System.Windows.Forms.ListViewItem" /> to the collection.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.ListViewItem" /> to add to the collection.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.ListViewItem" /> that was added to the collection.</returns>
		public virtual ListViewItem Add(ListViewItem value)
		{
			return null;
		}

		/// <summary>Removes all items from the collection.</summary>
		public virtual void Clear()
		{
		}

		private void ClearItemsWithSameListView()
		{
		}

		/// <summary>Determines whether the specified item is located in the collection.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the item is contained in the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(ListViewItem item)
		{
			return false;
		}

		/// <summary>Copies the entire collection into an existing array at a specified location within the array.</summary>
		/// <param name="dest">An <see cref="T:System.Array" /> representing the array to copy the contents of the collection to.</param>
		/// <param name="index">The location within the destination array to copy the items from the collection to.</param>
		public void CopyTo(Array dest, int index)
		{
		}

		/// <summary>Returns an enumerator to use to iterate through the item collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the item collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The owner <see cref="T:System.Windows.Forms.ListView" /> is in virtual mode.</exception>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns the index within the collection of the specified item.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item to locate in the collection.</param>
		/// <returns>The zero-based index of the item's location in the collection; otherwise, -1 if the item is not located in the collection.</returns>
		public int IndexOf(ListViewItem item)
		{
			return 0;
		}

		/// <summary>Inserts an existing <see cref="T:System.Windows.Forms.ListViewItem" /> into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the item is inserted.</param>
		/// <param name="item">The <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item to insert.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.ListViewItem" /> that was inserted into the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than 0 or greater than the value of the <see cref="P:System.Windows.Forms.ListView.ListViewItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" />.</exception>
		public ListViewItem Insert(int index, ListViewItem item)
		{
			return null;
		}

		/// <summary>Creates a new item and inserts it into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the item is inserted.</param>
		/// <param name="text">The text to display for the item.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.ListViewItem" /> that was inserted into the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than 0 or greater than the value of the <see cref="P:System.Windows.Forms.ListView.ListViewItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" />.</exception>
		public ListViewItem Insert(int index, string text)
		{
			return null;
		}

		/// <summary>Removes the specified item from the collection.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item to remove from the collection.</param>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Windows.Forms.ListViewItem" /> assigned to the <paramref name="item" /> parameter is <see langword="null" />.</exception>
		public virtual void Remove(ListViewItem item)
		{
		}

		/// <summary>Removes the item at the specified index within the collection.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ListViewItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" />.</exception>
		public virtual void RemoveAt(int index)
		{
		}

		private void AddItem(ListViewItem value)
		{
		}

		private void CollectionChanged(bool sort)
		{
		}

		private ListViewItem RetrieveVirtualItemFromOwner(int displayIndex)
		{
			return null;
		}

		internal void Sort(IComparer comparer)
		{
		}

		internal void OnChange()
		{
		}
	}

	/// <summary>Represents the collection that contains the indexes to the selected items in a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
	[ListBindable(false)]
	public class SelectedIndexCollection : ICollection, IEnumerable, IList
	{
		private readonly ListView owner;

		private ArrayList list;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection of controls.</summary>
		/// <returns>The object used to synchronize the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" /> has a fixed size.</summary>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets an object in the collection.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The index value from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> that is stored at the specified location.</returns>
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

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets the index value at the specified index within the collection.</summary>
		/// <param name="index">The index of the item in the collection to retrieve.</param>
		/// <returns>The index value from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> that is stored at the specified location.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.SelectedIndexCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />.</exception>
		public int this[int index] => 0;

		internal ArrayList List => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" /> class.</summary>
		/// <param name="owner">A <see cref="T:System.Windows.Forms.ListView" /> control that owns the collection.</param>
		public SelectedIndexCollection(ListView owner)
		{
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <param name="value">An object to be added to the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />.</param>
		/// <returns>The location of the added item.</returns>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>Removes all items from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Clear()
		{
		}

		/// <summary>Determines whether the specified item is located in the collection.</summary>
		/// <param name="selectedIndex">The index to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> for the <see cref="T:System.Windows.Forms.ListView" /> is an item in the collection; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object selectedIndex)
		{
			return false;
		}

		/// <summary>Returns the index in the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />. The <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" /> contains the indexes of selected items in the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> of the <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
		/// <param name="selectedIndex">The zero-based index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> to locate in the collection.</param>
		int IList.IndexOf(object selectedIndex)
		{
			return 0;
		}

		/// <summary>Inserts an item into the collection at a specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The object to be inserted into the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Removes the first occurrence of a specified item from the collection.</summary>
		/// <param name="value">The object to remove from the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Remove(object value)
		{
		}

		/// <summary>Removes an item from the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.RemoveAt(int index)
		{
		}

		/// <summary>Clears the items in the collection.</summary>
		public void Clear()
		{
		}

		/// <summary>Determines whether the specified index is located in the collection.</summary>
		/// <param name="selectedIndex">The index to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> for the <see cref="T:System.Windows.Forms.ListView" /> is an item in the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(int selectedIndex)
		{
			return false;
		}

		/// <summary>Copies the entire collection into an existing array at a specified location within the array.</summary>
		/// <param name="dest">An <see cref="T:System.Array" /> representing the array to copy the contents of the collection to.</param>
		/// <param name="index">The location within the destination array to copy the items from the collection to.</param>
		public void CopyTo(Array dest, int index)
		{
		}

		/// <summary>Returns an enumerator that can be used to iterate through the selected index collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the selected index collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns the index within the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" /> of the specified index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> of the <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
		/// <param name="selectedIndex">The zero-based index from the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> to locate in the collection.</param>
		/// <returns>The zero-based index in the collection where the specified index of the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> is located within the <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" />, or -1 if the index is not located in the collection.</returns>
		public int IndexOf(int selectedIndex)
		{
			return 0;
		}

		internal void Reset()
		{
		}

		private void ItemsCollection_Changed()
		{
		}

		internal void RemoveIndex(int index)
		{
		}

		internal void InsertIndex(int index)
		{
		}
	}

	/// <summary>Represents the collection of selected items in a list view control.</summary>
	[ListBindable(false)]
	public class SelectedListViewItemCollection : ICollection, IEnumerable, IList
	{
		private readonly ListView owner;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection of controls.</summary>
		/// <returns>The object used to synchronize the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets an object from the collection.</summary>
		/// <param name="index">The zero-based index of the element to get.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item located at the specified index within the collection.</returns>
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

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets the item at the specified index within the collection.</summary>
		/// <param name="index">The index of the item in the collection to retrieve.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than zero or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListView.ListViewItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection" />.</exception>
		public ListViewItem this[int index] => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.ListView" /> control that owns the collection.</param>
		public SelectedListViewItemCollection(ListView owner)
		{
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <param name="value">An object to be added to the <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection" />.</param>
		/// <returns>The location of the added item.</returns>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>Determines whether the specified item is located in the collection.</summary>
		/// <param name="item">An object that represents the item to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified item is located in the collection; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object item)
		{
			return false;
		}

		/// <summary>Returns the index, within the collection, of the specified item.</summary>
		/// <param name="item">An object that represents the item to locate in the collection.</param>
		/// <returns>The zero-based index of the item if it is in the collection; otherwise, -1</returns>
		int IList.IndexOf(object item)
		{
			return 0;
		}

		/// <summary>Inserts an item into the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the item to be inserted.</param>
		/// <param name="value">An object to be added to the <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Removes the first occurrence of a specified item from the collection.</summary>
		/// <param name="value">The object to remove from the <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Remove(object value)
		{
		}

		/// <summary>Removes an item from the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.RemoveAt(int index)
		{
		}

		/// <summary>Removes all items from the collection.</summary>
		public void Clear()
		{
		}

		/// <summary>Determines whether the specified item is located in the collection.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the specified item is located in the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(ListViewItem item)
		{
			return false;
		}

		/// <summary>Copies the entire collection into an existing array at a specified location within the array.</summary>
		/// <param name="dest">An <see cref="T:System.Array" /> representing the array to copy the contents of the collection to.</param>
		/// <param name="index">The location within the destination array to copy the items from the collection to.</param>
		public void CopyTo(Array dest, int index)
		{
		}

		/// <summary>Returns an enumerator that can be used to iterate through the selected item collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the collection of selected items.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns the index within the collection of the specified item.</summary>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem" /> representing the item to locate in the collection.</param>
		/// <returns>The zero-based index of the item in the collection. If the item is not located in the collection, the return value is negative one (-1).</returns>
		public int IndexOf(ListViewItem item)
		{
			return 0;
		}
	}

	private struct ItemMatrixLocation
	{
		private int row;

		private int col;

		public int Col => 0;

		public int Row => 0;

		public ItemMatrixLocation(int row, int col)
		{
			this.row = 0;
			this.col = 0;
		}
	}

	internal delegate void CollectionChangedHandler();

	private ItemActivation activation;

	private ListViewAlignment alignment;

	private bool allow_column_reorder;

	private bool auto_arrange;

	private bool check_boxes;

	private readonly CheckedIndexCollection checked_indices;

	private readonly CheckedListViewItemCollection checked_items;

	private readonly ColumnHeaderCollection columns;

	internal int focused_item_index;

	private bool full_row_select;

	private bool grid_lines;

	private ColumnHeaderStyle header_style;

	private bool hide_selection;

	private bool hover_selection;

	private IComparer item_sorter;

	private readonly ListViewItemCollection items;

	private readonly ListViewGroupCollection groups;

	private bool owner_draw;

	private bool show_groups;

	private bool label_edit;

	private bool label_wrap;

	private bool multiselect;

	private bool scrollable;

	private bool hover_pending;

	private readonly SelectedIndexCollection selected_indices;

	private readonly SelectedListViewItemCollection selected_items;

	private ImageList state_image_list;

	internal bool updating;

	private View view;

	private int layout_wd;

	private int layout_ht;

	internal HeaderControl header_control;

	internal ItemControl item_control;

	internal ScrollBar h_scroll;

	internal ScrollBar v_scroll;

	internal int h_marker;

	internal int v_marker;

	private int keysearch_tickcnt;

	private string keysearch_text;

	private static readonly int keysearch_keydelay;

	private int[] reordered_column_indices;

	private int[] reordered_items_indices;

	private Point[] items_location;

	private ItemMatrixLocation[] items_matrix_location;

	private Size item_size;

	private int custom_column_width;

	private int hot_item_index;

	private bool hot_tracking;

	private ListViewInsertionMark insertion_mark;

	private bool show_item_tooltips;

	private ToolTip item_tooltip;

	private Size tile_size;

	private bool virtual_mode;

	private int virtual_list_size;

	internal ImageList large_image_list;

	internal ImageList small_image_list;

	internal Size text_size;

	private static object AfterLabelEditEvent;

	private static object BeforeLabelEditEvent;

	private static object ItemActivateEvent;

	private static object ItemCheckEvent;

	private static object ItemDragEvent;

	private static object SelectedIndexChangedEvent;

	private static object DrawColumnHeaderEvent;

	private static object DrawItemEvent;

	private static object DrawSubItemEvent;

	private static object ItemCheckedEvent;

	private static object ItemMouseHoverEvent;

	private static object ItemSelectionChangedEvent;

	private static object CacheVirtualItemsEvent;

	private static object RetrieveVirtualItemEvent;

	private static object RightToLeftLayoutChangedEvent;

	private static object SearchForVirtualItemEvent;

	private static object VirtualItemsSelectionRangeChangedEvent;

	private int x_spacing;

	private int y_spacing;

	private int rows;

	private int cols;

	private int[,] item_index_matrix;

	private ListViewItem selection_start;

	private bool refocusing;

	private static object ColumnReorderedEvent;

	private static object ColumnWidthChangedEvent;

	private static object ColumnWidthChangingEvent;

	private static object UIALabelEditChangedEvent;

	private static object UIAShowGroupsChangedEvent;

	private static object UIAMultiSelectChangedEvent;

	private static object UIAViewChangedEvent;

	private static object UIACheckBoxesChangedEvent;

	private static object UIAFocusedItemChangedEvent;

	internal Size CheckBoxSize => default(Size);

	internal Size ItemSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	internal int HotItemIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal bool UsingGroups => false;

	internal override bool ScaleChildrenInternal => false;

	internal bool UseCustomColumnWidth => false;

	internal ColumnHeader EnteredColumnHeader => null;

	/// <summary>This property is not relevant for this class.</summary>
	/// <returns>
	///   <see langword="null" /> in all cases.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets or sets a value indicating whether this control should redraw its surface using a secondary buffer to reduce or prevent flicker.</summary>
	/// <returns>
	///   <see langword="true" /> if the surface of the control should be drawn using double buffering; otherwise, <see langword="false" />.</returns>
	protected override bool DoubleBuffered => false;

	/// <summary>Gets or sets the type of action the user must take to activate an item.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ItemActivation" /> values. The default is <see cref="F:System.Windows.Forms.ItemActivation.Standard" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is not one of the <see cref="T:System.Windows.Forms.ItemActivation" /> members.</exception>
	[DefaultValue(ItemActivation.Standard)]
	public ItemActivation Activation => default(ItemActivation);

	/// <summary>Gets or sets the alignment of items in the control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ListViewAlignment" /> values. The default is <see cref="F:System.Windows.Forms.ListViewAlignment.Top" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is not one of the <see cref="T:System.Windows.Forms.ListViewAlignment" /> values.</exception>
	[Localizable(true)]
	[DefaultValue(ListViewAlignment.Top)]
	public ListViewAlignment Alignment => default(ListViewAlignment);

	/// <summary>Gets or sets a value indicating whether the user can drag column headers to reorder columns in the control.</summary>
	/// <returns>
	///   <see langword="true" /> if drag-and-drop column reordering is allowed; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool AllowColumnReorder
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the background color.</summary>
	/// <returns>The <see cref="T:System.Drawing.Color" /> of the background.</returns>
	public override Color BackColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets an <see cref="T:System.Windows.Forms.ImageLayout" /> value.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ImageLayout" /> values.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is not one of the <see cref="T:System.Windows.Forms.ImageLayout" /> values.</exception>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			return default(ImageLayout);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the background image of the <see cref="T:System.Windows.Forms.ListView" /> should be tiled.</summary>
	/// <returns>
	///   <see langword="true" /> if the background image of the <see cref="T:System.Windows.Forms.ListView" /> should be tiled; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool BackgroundImageTiled
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether a check box appears next to each item in the control.</summary>
	/// <returns>
	///   <see langword="true" /> if a check box appears next to each item in the <see cref="T:System.Windows.Forms.ListView" /> control; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool CheckBoxes => false;

	/// <summary>Gets the currently checked items in the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" /> that contains the currently checked items. If no items are currently checked, an empty <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection" /> is returned.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public CheckedListViewItemCollection CheckedItems => null;

	/// <summary>Gets the collection of all column headers that appear in the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" /> that represents the column headers that appear when the <see cref="P:System.Windows.Forms.ListView.View" /> property is set to <see cref="F:System.Windows.Forms.View.Details" />.</returns>
	[MergableProperty(false)]
	[Localizable(true)]
	[Editor("System.Windows.Forms.Design.ColumnHeaderCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ColumnHeaderCollection Columns => null;

	/// <summary>Gets or sets the item in the control that currently has focus.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item that has focus, or <see langword="null" /> if no item has the focus in the <see cref="T:System.Windows.Forms.ListView" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public ListViewItem FocusedItem => null;

	/// <summary>Gets or sets the foreground color.</summary>
	/// <returns>The <see cref="T:System.Drawing.Color" /> that is the foreground color.</returns>
	public override Color ForeColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether clicking an item selects all its subitems.</summary>
	/// <returns>
	///   <see langword="true" /> if clicking an item selects the item and all its subitems; <see langword="false" /> if clicking an item selects only the item itself. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool FullRowSelect => false;

	/// <summary>Gets or sets a value indicating whether grid lines appear between the rows and columns containing the items and subitems in the control.</summary>
	/// <returns>
	///   <see langword="true" /> if grid lines are drawn around items and subitems; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool GridLines => false;

	/// <summary>Gets or sets the column header style.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ColumnHeaderStyle" /> values. The default is <see cref="F:System.Windows.Forms.ColumnHeaderStyle.Clickable" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is not one of the <see cref="T:System.Windows.Forms.ColumnHeaderStyle" /> values.</exception>
	[DefaultValue(ColumnHeaderStyle.Clickable)]
	public ColumnHeaderStyle HeaderStyle => default(ColumnHeaderStyle);

	/// <summary>Gets or sets a value indicating whether the selected item in the control remains highlighted when the control loses focus.</summary>
	/// <returns>
	///   <see langword="true" /> if the selected item does not appear highlighted when the control loses focus; <see langword="false" /> if the selected item still appears highlighted when the control loses focus. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool HideSelection => false;

	/// <summary>Gets or sets a value indicating whether the text of an item or subitem has the appearance of a hyperlink when the mouse pointer passes over it.</summary>
	/// <returns>
	///   <see langword="true" /> if the item text has the appearance of a hyperlink when the mouse passes over it; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool HotTracking => false;

	/// <summary>Gets or sets a value indicating whether an item is automatically selected when the mouse pointer remains over the item for a few seconds.</summary>
	/// <returns>
	///   <see langword="true" /> if an item is automatically selected when the mouse pointer hovers over it; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool HoverSelection => false;

	/// <summary>Gets an object used to indicate the expected drop location when an item is dragged within a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListViewInsertionMark" /> object representing the insertion mark.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ListViewInsertionMark InsertionMark => null;

	/// <summary>Gets a collection containing all items in the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> that contains all the items in the <see cref="T:System.Windows.Forms.ListView" /> control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Localizable(true)]
	[MergableProperty(false)]
	[Editor("System.Windows.Forms.Design.ListViewItemCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public ListViewItemCollection Items => null;

	/// <summary>Gets or sets a value indicating whether the user can edit the labels of items in the control.</summary>
	/// <returns>
	///   <see langword="true" /> if the user can edit the labels of items at run time; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool LabelEdit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether item labels wrap when items are displayed in the control as icons.</summary>
	/// <returns>
	///   <see langword="true" /> if item labels wrap when items are displayed as icons; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[Localizable(true)]
	public bool LabelWrap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ImageList" /> to use when displaying items as large icons in the control.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.ImageList" /> that contains the icons to use when the <see cref="P:System.Windows.Forms.ListView.View" /> property is set to <see cref="F:System.Windows.Forms.View.LargeIcon" />. The default is <see langword="null" />.</returns>
	[DefaultValue(null)]
	public ImageList LargeImageList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the sorting comparer for the control.</summary>
	/// <returns>An <see cref="T:System.Collections.IComparer" /> that represents the sorting comparer for the control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IComparer ListViewItemSorter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether multiple items can be selected.</summary>
	/// <returns>
	///   <see langword="true" /> if multiple items in the control can be selected at one time; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool MultiSelect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.ListView" /> control is drawn by the operating system or by code that you provide.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ListView" /> control is drawn by code that you provide; <see langword="false" /> if the <see cref="T:System.Windows.Forms.ListView" /> control is drawn by the operating system. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool OwnerDraw => false;

	/// <summary>Gets the indexes of the selected items in the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" /> that contains the indexes of the selected items. If no items are currently selected, an empty <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection" /> is returned.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public SelectedIndexCollection SelectedIndices => null;

	/// <summary>Gets the items that are selected in the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection" /> that contains the items that are selected in the control. If no items are currently selected, an empty <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection" /> is returned.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public SelectedListViewItemCollection SelectedItems => null;

	/// <summary>Gets the collection of <see cref="T:System.Windows.Forms.ListViewGroup" /> objects assigned to the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListViewGroupCollection" /> that contains all the groups in the <see cref="T:System.Windows.Forms.ListView" /> control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[MergableProperty(false)]
	[Localizable(true)]
	[Editor("System.Windows.Forms.Design.ListViewGroupCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public ListViewGroupCollection Groups => null;

	/// <summary>Gets or sets a value indicating whether ToolTips are shown for the <see cref="T:System.Windows.Forms.ListViewItem" /> objects contained in the <see cref="T:System.Windows.Forms.ListView" />.</summary>
	/// <returns>
	///   <see langword="true" /> if <see cref="T:System.Windows.Forms.ListViewItem" /> ToolTips should be shown; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(false)]
	public bool ShowItemToolTips => false;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ImageList" /> to use when displaying items as small icons in the control.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.ImageList" /> that contains the icons to use when the <see cref="P:System.Windows.Forms.ListView.View" /> property is set to <see cref="F:System.Windows.Forms.View.SmallIcon" />. The default is <see langword="null" />.</returns>
	[DefaultValue(null)]
	public ImageList SmallImageList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ImageList" /> associated with application-defined states in the control.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.ImageList" /> that contains a set of state images that can be used to indicate an application-defined state of an item. The default is <see langword="null" />.</returns>
	[DefaultValue(null)]
	public ImageList StateImageList => null;

	/// <summary>This property is not relevant for this class.</summary>
	/// <returns>The text to display in the <see cref="T:System.Windows.Forms.ListView" /> control.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	public override string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the size of the tiles shown in tile view.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that contains the new tile size.</returns>
	[Browsable(true)]
	public Size TileSize => default(Size);

	/// <summary>Gets or sets how items are displayed in the control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.View" /> values. The default is <see cref="F:System.Windows.Forms.View.LargeIcon" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is not one of the <see cref="T:System.Windows.Forms.View" /> values.</exception>
	[DefaultValue(View.LargeIcon)]
	public View View
	{
		get
		{
			return default(View);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether you have provided your own data-management operations for the <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
	/// <returns>
	///   <see langword="true" /> if <see cref="T:System.Windows.Forms.ListView" /> uses data-management operations that you provide; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="P:System.Windows.Forms.ListView.VirtualMode" /> is set to <see langword="true" /> and one of the following conditions exist:  
	///
	/// <see cref="P:System.Windows.Forms.ListView.VirtualListSize" /> is greater than 0 and <see cref="E:System.Windows.Forms.ListView.RetrieveVirtualItem" /> is not handled.  
	///  -or-  
	///
	/// <see cref="P:System.Windows.Forms.ListView.Items" />, <see cref="P:System.Windows.Forms.ListView.CheckedItems" />, or <see cref="P:System.Windows.Forms.ListView.SelectedItems" /> contains items.  
	///  -or-  
	///
	/// Edits are made to <see cref="P:System.Windows.Forms.ListView.Items" />.</exception>
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public bool VirtualMode => false;

	/// <summary>Gets or sets the number of <see cref="T:System.Windows.Forms.ListViewItem" /> objects contained in the list when in virtual mode.</summary>
	/// <returns>The number of <see cref="T:System.Windows.Forms.ListViewItem" /> objects contained in the <see cref="T:System.Windows.Forms.ListView" /> when in virtual mode.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <see cref="P:System.Windows.Forms.ListView.VirtualListSize" /> is set to a value less than 0.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="P:System.Windows.Forms.ListView.VirtualMode" /> is set to <see langword="true" />, <see cref="P:System.Windows.Forms.ListView.VirtualListSize" /> is greater than 0, and <see cref="E:System.Windows.Forms.ListView.RetrieveVirtualItem" /> is not handled.</exception>
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(0)]
	public int VirtualListSize => 0;

	internal int FirstVisibleIndex => 0;

	internal int LastVisibleIndex => 0;

	internal int TotalWidth => 0;

	private Size LargeIconItemSize => default(Size);

	private Size SmallIconItemSize => default(Size);

	private Size TileItemSize => default(Size);

	/// <summary>Occurs when the user clicks a column header within the list view control.</summary>
	public event ColumnClickEventHandler ColumnClick
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListView" /> class.</summary>
	public ListView()
	{
	}

	internal void OnSelectedIndexChanged()
	{
	}

	internal void Redraw(bool recalculate)
	{
	}

	internal Size GetChildColumnSize(int index)
	{
		return default(Size);
	}

	private Size BiggestItem(int col)
	{
		return default(Size);
	}

	private void CalcTextSize()
	{
	}

	private void SetScrollValue(ScrollBar scrollbar, int val)
	{
	}

	private void Scroll(ScrollBar scrollbar, int delta)
	{
	}

	private void CalculateScrollBars()
	{
	}

	internal ColumnHeader GetReorderedColumn(int index)
	{
		return null;
	}

	internal void ReorderColumn(ColumnHeader col, int index, bool fireEvent)
	{
	}

	internal void ReorderColumns(int[] display_indices, bool redraw)
	{
	}

	internal void AddColumn(ColumnHeader newCol, int index, bool redraw)
	{
	}

	private int GetDetailsItemHeight()
	{
		return 0;
	}

	private void SetItemLocation(int index, int x, int y, int row, int col)
	{
	}

	private int GetDefaultGroupItems()
	{
		return 0;
	}

	private void CalculateRowsAndCols(Size item_size, bool left_aligned, int x_spacing, int y_spacing)
	{
	}

	private void CalculateCustomColumnWidth()
	{
	}

	private void LayoutIcons(Size item_size, bool left_aligned, int x_spacing, int y_spacing)
	{
	}

	private void CalculateGroupsLayout(Size item_size, int y_spacing, int y_origin)
	{
	}

	private int LayoutGroupHeader(ListViewGroup group, int y_origin, int item_height, int y_spacing, int rows)
	{
		return 0;
	}

	private void CalculateDetailsGroupItemsCount()
	{
	}

	private void LayoutHeader()
	{
	}

	private void LayoutDetails()
	{
	}

	private void AdjustItemsPositionArray(int count)
	{
	}

	private void CalculateListView(ListViewAlignment align)
	{
	}

	internal Point GetItemLocation(int index)
	{
		return default(Point);
	}

	private Point GetFixedItemLocation(int index)
	{
		return default(Point);
	}

	internal int GetItemIndex(int display_index)
	{
		return 0;
	}

	internal ListViewItem GetItemAtDisplayIndex(int display_index)
	{
		return null;
	}

	internal void SetItemAtDisplayIndex(int display_index, int index)
	{
	}

	private bool KeySearchString(KeyEventArgs ke)
	{
		return false;
	}

	private void OnItemsChanged()
	{
	}

	private void ResetSearchString()
	{
	}

	private int GetAdjustedIndex(Keys key)
	{
		return 0;
	}

	private int GetFixedAdjustedIndex(Keys key)
	{
		return 0;
	}

	private bool SelectItems(ArrayList sel_items)
	{
		return false;
	}

	private void UpdateMultiSelection(int index, bool reselect)
	{
	}

	internal override bool InternalPreProcessMessage(ref Message msg)
	{
		return false;
	}

	private bool HandleNavKeys(Keys key_data)
	{
		return false;
	}

	private void ToggleItemsCheckState()
	{
	}

	private void SelectIndex(int display_index)
	{
	}

	private void ListView_KeyDown(object sender, KeyEventArgs ke)
	{
	}

	private MouseEventArgs TranslateMouseEventArgs(MouseEventArgs args)
	{
		return null;
	}

	internal override void OnPaintInternal(PaintEventArgs pe)
	{
	}

	private void FocusChanged(object o, EventArgs args)
	{
	}

	private void ListView_Invalidated(object sender, InvalidateEventArgs e)
	{
	}

	private void ListView_MouseEnter(object sender, EventArgs args)
	{
	}

	private void ListView_MouseWheel(object sender, MouseEventArgs me)
	{
	}

	private void ListView_SizeChanged(object sender, EventArgs e)
	{
	}

	private void SetFocusedItem(int display_index)
	{
	}

	private void HorizontalScroller(object sender, EventArgs e)
	{
	}

	private void VerticalScroller(object sender, EventArgs e)
	{
	}

	internal override bool IsInputCharInternal(char charCode)
	{
		return false;
	}

	/// <summary>Creates a handle for the control.</summary>
	protected override void CreateHandle()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ListView" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Determines whether the specified key is a regular input key or a special key that requires preprocessing.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values.</param>
	/// <returns>
	///   <see langword="true" /> if the specified key is a regular input key; otherwise, <see langword="false" />.</returns>
	protected override bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.AfterLabelEdit" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.LabelEditEventArgs" /> that contains the event data.</param>
	protected virtual void OnAfterLabelEdit(LabelEditEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.BeforeLabelEdit" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.LabelEditEventArgs" /> that contains the event data.</param>
	protected virtual void OnBeforeLabelEdit(LabelEditEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ColumnClick" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ColumnClickEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnColumnClick(ColumnClickEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.DrawColumnHeader" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.DrawListViewColumnHeaderEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.DrawItem" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.DrawListViewItemEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnDrawItem(DrawListViewItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.DrawSubItem" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.DrawListViewSubItemEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnDrawSubItem(DrawListViewSubItemEventArgs e)
	{
	}

	/// <summary>Raises the <see langword="FontChanged" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleDestroyed(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ItemActivate" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnItemActivate(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ItemCheck" /> event.</summary>
	/// <param name="ice">An <see cref="T:System.Windows.Forms.ItemCheckEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnItemCheck(ItemCheckEventArgs ice)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ItemChecked" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.ItemCheckedEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnItemChecked(ItemCheckedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ItemDrag" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.ItemDragEventArgs" /> that contains the event data.</param>
	protected virtual void OnItemDrag(ItemDragEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ItemMouseHover" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ListViewItemMouseHoverEventArgs" /> that contains the event data.</param>
	protected virtual void OnItemMouseHover(ListViewItemMouseHoverEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ItemSelectionChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ListViewItemSelectionChangedEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnItemSelectionChanged(ListViewItemSelectionChangedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseHover" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseHover(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnParentChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.SelectedIndexChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnSelectedIndexChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.SystemColorsChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnSystemColorsChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.CacheVirtualItems" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.CacheVirtualItemsEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnCacheVirtualItems(CacheVirtualItemsEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.RetrieveVirtualItem" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.RetrieveVirtualItemEventArgs" /> that contains the event data.</param>
	protected virtual void OnRetrieveVirtualItem(RetrieveVirtualItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.SearchForVirtualItem" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.SearchForVirtualItemEventArgs" /> that contains the event data.</param>
	protected virtual void OnSearchForVirtualItem(SearchForVirtualItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.VirtualItemsSelectionRangeChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventArgs" /> that contains the event data.</param>
	protected virtual void OnVirtualItemsSelectionRangeChanged(ListViewVirtualItemsSelectionRangeChangedEventArgs e)
	{
	}

	/// <summary>Overrides <see cref="M:System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message@)" />.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	/// <summary>Prevents the control from drawing until the <see cref="M:System.Windows.Forms.ListView.EndUpdate" /> method is called.</summary>
	public void BeginUpdate()
	{
	}

	/// <summary>Resumes drawing of the list view control after drawing is suspended by the <see cref="M:System.Windows.Forms.ListView.BeginUpdate" /> method.</summary>
	public void EndUpdate()
	{
	}

	/// <summary>Ensures that the specified item is visible within the control, scrolling the contents of the control if necessary.</summary>
	/// <param name="index">The zero-based index of the item to scroll into view.</param>
	public void EnsureVisible(int index)
	{
	}

	internal ListViewItem FindItemWithText(string text, bool includeSubItemsInSearch, int startIndex, bool isPrefixSearch, bool roundtrip)
	{
		return null;
	}

	/// <summary>Retrieves the item at the specified location.</summary>
	/// <param name="x">The x-coordinate of the location to search for an item (expressed in client coordinates).</param>
	/// <param name="y">The y-coordinate of the location to search for an item (expressed in client coordinates).</param>
	/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item at the specified position. If there is no item at the specified location, the method returns <see langword="null" />.</returns>
	public ListViewItem GetItemAt(int x, int y)
	{
		return null;
	}

	/// <summary>Sorts the items of the list view.</summary>
	public void Sort()
	{
	}

	private void Sort(bool redraw)
	{
	}

	/// <summary>Returns a string representation of the <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
	/// <returns>A string that states the control type, the count of items in the <see cref="T:System.Windows.Forms.ListView" /> control, and the type of the first item in the <see cref="T:System.Windows.Forms.ListView" />, if the count is not 0.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnResize(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListView.ColumnWidthChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ColumnWidthChangedEventArgs" /> that contains the event data.</param>
	protected virtual void OnColumnWidthChanged(ColumnWidthChangedEventArgs e)
	{
	}

	private void RaiseColumnWidthChanged(int resize_column)
	{
	}

	private bool CanProceedWithResize(ColumnHeader col, int width)
	{
		return false;
	}

	internal void RaiseColumnWidthChanged(ColumnHeader column)
	{
	}

	private void OnUIAMultiSelectChanged()
	{
	}

	private void OnUIALabelEditChanged()
	{
	}

	private void OnUIAViewChanged()
	{
	}

	internal void OnUIAFocusedItemChanged()
	{
	}
}
