using System.Drawing;
using System.Runtime.Serialization;

namespace System.Windows.Forms;

/// <summary>Contains values of properties that a component might need only occasionally.</summary>
[Serializable]
public class OwnerDrawPropertyBag : MarshalByRefObject, ISerializable
{
	private Color fore_color;

	private Color back_color;

	private Font font;

	/// <summary>Gets or sets the foreground color of the component.</summary>
	/// <returns>The foreground color of the component. The default is <see cref="F:System.Drawing.Color.Empty" />.</returns>
	public Color ForeColor => default(Color);

	/// <summary>Gets or sets the background color for the component.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the component. The default is <see cref="F:System.Drawing.Color.Empty" />.</returns>
	public Color BackColor => default(Color);

	/// <summary>Gets or sets the font of the text displayed by the component.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the component. The default is <see langword="null" />.</returns>
	public Font Font => null;

	internal OwnerDrawPropertyBag()
	{
	}

	private OwnerDrawPropertyBag(Color fore_color, Color back_color, Font font)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.OwnerDrawPropertyBag" /> class.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> value.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> value.</param>
	protected OwnerDrawPropertyBag(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="si">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="context">The destination for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
	}

	/// <summary>Copies an <see cref="T:System.Windows.Forms.OwnerDrawPropertyBag" />.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.OwnerDrawPropertyBag" /> to be copied.</param>
	/// <returns>A new copy of the <see cref="T:System.Windows.Forms.OwnerDrawPropertyBag" /> control.</returns>
	public static OwnerDrawPropertyBag Copy(OwnerDrawPropertyBag value)
	{
		return null;
	}
}
