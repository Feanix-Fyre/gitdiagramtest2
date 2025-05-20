using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[AssetFileNameExtension("guiskin", new string[] { })]
[RequiredByNativeCode]
[ExecuteInEditMode]
public sealed class GUISkin : ScriptableObject
{
	internal delegate void SkinChangedDelegate();

	[SerializeField]
	private Font m_Font;

	[SerializeField]
	private GUIStyle m_box;

	[SerializeField]
	private GUIStyle m_button;

	[SerializeField]
	private GUIStyle m_toggle;

	[SerializeField]
	private GUIStyle m_label;

	[SerializeField]
	private GUIStyle m_textField;

	[SerializeField]
	private GUIStyle m_textArea;

	[SerializeField]
	private GUIStyle m_window;

	[SerializeField]
	private GUIStyle m_horizontalSlider;

	[SerializeField]
	private GUIStyle m_horizontalSliderThumb;

	[NonSerialized]
	private GUIStyle m_horizontalSliderThumbExtent;

	[SerializeField]
	private GUIStyle m_verticalSlider;

	[SerializeField]
	private GUIStyle m_verticalSliderThumb;

	[NonSerialized]
	private GUIStyle m_verticalSliderThumbExtent;

	[NonSerialized]
	private GUIStyle m_SliderMixed;

	[SerializeField]
	private GUIStyle m_horizontalScrollbar;

	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb;

	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton;

	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton;

	[SerializeField]
	private GUIStyle m_verticalScrollbar;

	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb;

	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton;

	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton;

	[SerializeField]
	private GUIStyle m_ScrollView;

	[SerializeField]
	internal GUIStyle[] m_CustomStyles;

	[SerializeField]
	private GUISettings m_Settings;

	internal static GUIStyle ms_Error;

	private Dictionary<string, GUIStyle> m_Styles;

	internal static SkinChangedDelegate m_SkinChanged;

	internal static GUISkin current;

	public Font font
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle box
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle label
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle textField
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle textArea
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle button
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle toggle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle window
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle horizontalSlider
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle horizontalSliderThumb
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal GUIStyle horizontalSliderThumbExtent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal GUIStyle sliderMixed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle verticalSlider
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle verticalSliderThumb
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal GUIStyle verticalSliderThumbExtent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle horizontalScrollbar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle horizontalScrollbarThumb
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle horizontalScrollbarLeftButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle horizontalScrollbarRightButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle verticalScrollbar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle verticalScrollbarThumb
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle verticalScrollbarUpButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle verticalScrollbarDownButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle scrollView
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyle[] customStyles
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUISettings settings => null;

	internal static GUIStyle error => null;

	internal void OnEnable()
	{
	}

	internal static void CleanupRoots()
	{
	}

	internal void Apply()
	{
	}

	private void BuildStyleCache()
	{
	}

	public GUIStyle GetStyle(string styleName)
	{
		return null;
	}

	public GUIStyle FindStyle(string styleName)
	{
		return null;
	}

	internal void MakeCurrent()
	{
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
