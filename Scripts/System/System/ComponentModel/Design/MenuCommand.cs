using System.Collections;

namespace System.ComponentModel.Design;

/// <summary>Represents a Windows menu or toolbar command item.</summary>
public class MenuCommand
{
	private EventHandler _execHandler;

	private int _status;

	private IDictionary _properties;

	/// <summary>Gets the public properties associated with the <see cref="T:System.ComponentModel.Design.MenuCommand" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionary" /> containing the public properties of the <see cref="T:System.ComponentModel.Design.MenuCommand" />.</returns>
	public virtual IDictionary Properties => null;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> associated with this menu command.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.Design.CommandID" /> associated with the menu command.</returns>
	public virtual CommandID CommandID { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.MenuCommand" /> class.</summary>
	/// <param name="handler">The event to raise when the user selects the menu item or toolbar button.</param>
	/// <param name="command">The unique command ID that links this menu command to the environment's menu.</param>
	public MenuCommand(EventHandler handler, CommandID command)
	{
	}

	/// <summary>Returns a string representation of this menu command.</summary>
	/// <returns>A string containing the value of the <see cref="P:System.ComponentModel.Design.MenuCommand.CommandID" /> property appended with the names of any flags that are set, separated by pipe bars (|). These flag properties include <see cref="P:System.ComponentModel.Design.MenuCommand.Checked" />, <see cref="P:System.ComponentModel.Design.MenuCommand.Enabled" />, <see cref="P:System.ComponentModel.Design.MenuCommand.Supported" />, and <see cref="P:System.ComponentModel.Design.MenuCommand.Visible" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
