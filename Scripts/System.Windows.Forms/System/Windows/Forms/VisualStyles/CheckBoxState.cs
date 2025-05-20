namespace System.Windows.Forms.VisualStyles;

/// <summary>Specifies the visual state of a check box that is drawn with visual styles.</summary>
public enum CheckBoxState
{
	/// <summary>The check box is unchecked.</summary>
	UncheckedNormal = 1,
	/// <summary>The check box is unchecked and hot.</summary>
	UncheckedHot = 2,
	/// <summary>The check box is unchecked and pressed.</summary>
	UncheckedPressed = 3,
	/// <summary>The check box is unchecked and disabled.</summary>
	UncheckedDisabled = 4,
	/// <summary>The check box is checked.</summary>
	CheckedNormal = 5,
	/// <summary>The check box is checked and hot.</summary>
	CheckedHot = 6,
	/// <summary>The check box is checked and pressed.</summary>
	CheckedPressed = 7,
	/// <summary>The check box is checked and disabled.</summary>
	CheckedDisabled = 8,
	/// <summary>The check box is three-state.</summary>
	MixedNormal = 9,
	/// <summary>The check box is three-state and hot.</summary>
	MixedHot = 10,
	/// <summary>The check box is three-state and pressed.</summary>
	MixedPressed = 11,
	/// <summary>The check box is three-state and disabled.</summary>
	MixedDisabled = 12
}
