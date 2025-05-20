using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Windows.Forms;

/// <summary>Controls <see cref="T:System.Windows.Forms.ToolStrip" /> rendering and rafting, and the merging of <see cref="T:System.Windows.Forms.MenuStrip" />, <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />, and <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> objects. This class cannot be inherited.</summary>
public sealed class ToolStripManager
{
	private static ToolStripRenderer renderer;

	private static ToolStripManagerRenderMode render_mode;

	private static bool visual_styles_enabled;

	private static List<WeakReference> toolstrips;

	private static List<ToolStripMenuItem> menu_items;

	private static bool activated_by_keyboard;

	/// <summary>Gets or sets the default painting styles for the form.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripRenderer" /> values.</returns>
	public static ToolStripRenderer Renderer => null;

	internal static bool ActivatedByKeyboard
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal static event EventHandler AppClicked
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

	internal static event EventHandler AppFocusChange
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

	/// <summary>Combines two <see cref="T:System.Windows.Forms.ToolStrip" /> objects of different types.</summary>
	/// <param name="sourceToolStrip">The <see cref="T:System.Windows.Forms.ToolStrip" /> to be combined with the <see cref="T:System.Windows.Forms.ToolStrip" /> referred to by the <paramref name="targetToolStrip" /> parameter.</param>
	/// <param name="targetToolStrip">The <see cref="T:System.Windows.Forms.ToolStrip" /> that receives the <see cref="T:System.Windows.Forms.ToolStrip" /> referred to by the <paramref name="sourceToolStrip" /> parameter.</param>
	/// <returns>
	///   <see langword="true" /> if the merge is successful; otherwise, <see langword="false" />.</returns>
	[System.MonoLimitation("Only supports one level of merging, cannot merge the same ToolStrip multiple times")]
	public static bool Merge(ToolStrip sourceToolStrip, ToolStrip targetToolStrip)
	{
		return false;
	}

	/// <summary>Undoes a merging of two <see cref="T:System.Windows.Forms.ToolStrip" /> objects, returning the specified <see cref="T:System.Windows.Forms.ToolStrip" /> to its state before the merge and nullifying all previous merge operations.</summary>
	/// <param name="targetToolStrip">The <see cref="T:System.Windows.Forms.ToolStripItem" /> for which to undo a merge operation.</param>
	/// <returns>
	///   <see langword="true" /> if the undoing of the merge is successful; otherwise, <see langword="false" />.</returns>
	public static bool RevertMerge(ToolStrip targetToolStrip)
	{
		return false;
	}

	/// <summary>Undoes a merging of two <see cref="T:System.Windows.Forms.ToolStrip" /> objects, returning both <see cref="T:System.Windows.Forms.ToolStrip" /> controls to their state before the merge and nullifying all previous merge operations.</summary>
	/// <param name="targetToolStrip">The name of the <see cref="T:System.Windows.Forms.ToolStripItem" /> for which to undo a merge operation.</param>
	/// <param name="sourceToolStrip">The <see cref="T:System.Windows.Forms.ToolStrip" /> that was merged with the <paramref name="targetToolStrip" />.</param>
	/// <returns>
	///   <see langword="true" /> if the undoing of the merge is successful; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="sourceToolStrip" /> is <see langword="null" />.</exception>
	public static bool RevertMerge(ToolStrip targetToolStrip, ToolStrip sourceToolStrip)
	{
		return false;
	}

	internal static void AddToolStrip(ToolStrip ts)
	{
	}

	private static int AdjustItemMergeIndex(ToolStrip ts, ToolStripItem tsi)
	{
		return 0;
	}

	private static int CountRealToolStripItems(ToolStrip ts)
	{
		return 0;
	}

	internal static ToolStrip GetNextToolStrip(ToolStrip ts, bool forward)
	{
		return null;
	}

	internal static bool ProcessCmdKey(ref Message m, Keys keyData)
	{
		return false;
	}

	internal static bool ProcessMenuKey(ref Message m)
	{
		return false;
	}

	internal static void SetActiveToolStrip(ToolStrip toolStrip, bool keyboard)
	{
	}

	internal static void AddToolStripMenuItem(ToolStripMenuItem tsmi)
	{
	}

	internal static void RemoveToolStrip(ToolStrip ts)
	{
	}

	internal static void RemoveToolStripMenuItem(ToolStripMenuItem tsmi)
	{
	}

	internal static void FireAppClicked()
	{
	}

	internal static void FireAppFocusChanged(Form form)
	{
	}

	private static void RemoveItemFromParentToolStrip(ToolStripItem tsi)
	{
	}
}
