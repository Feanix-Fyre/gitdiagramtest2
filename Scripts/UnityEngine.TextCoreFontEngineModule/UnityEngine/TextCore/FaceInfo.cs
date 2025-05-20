using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore;

[Serializable]
[UsedByNativeCode]
public struct FaceInfo
{
	[SerializeField]
	[NativeName("faceIndex")]
	private int m_FaceIndex;

	[SerializeField]
	[NativeName("familyName")]
	private string m_FamilyName;

	[SerializeField]
	[NativeName("styleName")]
	private string m_StyleName;

	[NativeName("pointSize")]
	[SerializeField]
	private int m_PointSize;

	[NativeName("scale")]
	[SerializeField]
	private float m_Scale;

	[SerializeField]
	[NativeName("unitsPerEM")]
	private int m_UnitsPerEM;

	[NativeName("lineHeight")]
	[SerializeField]
	private float m_LineHeight;

	[NativeName("ascentLine")]
	[SerializeField]
	private float m_AscentLine;

	[NativeName("capLine")]
	[SerializeField]
	private float m_CapLine;

	[SerializeField]
	[NativeName("meanLine")]
	private float m_MeanLine;

	[NativeName("baseline")]
	[SerializeField]
	private float m_Baseline;

	[NativeName("descentLine")]
	[SerializeField]
	private float m_DescentLine;

	[SerializeField]
	[NativeName("superscriptOffset")]
	private float m_SuperscriptOffset;

	[NativeName("superscriptSize")]
	[SerializeField]
	private float m_SuperscriptSize;

	[NativeName("subscriptOffset")]
	[SerializeField]
	private float m_SubscriptOffset;

	[SerializeField]
	[NativeName("subscriptSize")]
	private float m_SubscriptSize;

	[NativeName("underlineOffset")]
	[SerializeField]
	private float m_UnderlineOffset;

	[NativeName("underlineThickness")]
	[SerializeField]
	private float m_UnderlineThickness;

	[NativeName("strikethroughOffset")]
	[SerializeField]
	private float m_StrikethroughOffset;

	[SerializeField]
	[NativeName("strikethroughThickness")]
	private float m_StrikethroughThickness;

	[NativeName("tabWidth")]
	[SerializeField]
	private float m_TabWidth;

	internal int faceIndex => 0;

	public string familyName => null;

	public string styleName => null;

	public int pointSize => 0;

	public float scale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal int unitsPerEM
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float lineHeight => 0f;

	public float ascentLine => 0f;

	public float capLine
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float meanLine
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float baseline => 0f;

	public float descentLine => 0f;

	public float superscriptOffset => 0f;

	public float superscriptSize => 0f;

	public float subscriptOffset => 0f;

	public float subscriptSize => 0f;

	public float underlineOffset => 0f;

	public float underlineThickness => 0f;

	public float strikethroughOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float tabWidth => 0f;
}
