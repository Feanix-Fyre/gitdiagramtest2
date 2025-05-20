using System;

namespace UnityEngine;

public sealed class AddComponentMenu : Attribute
{
	private string m_AddComponentMenu;

	private int m_Ordering;

	public AddComponentMenu(string menuName)
	{
	}

	public AddComponentMenu(string menuName, int order)
	{
	}
}
