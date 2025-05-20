namespace System.Windows.Forms;

/// <summary>Indicates which <see cref="T:System.Windows.Forms.ImageList" /> a property is related to.</summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public sealed class RelatedImageListAttribute : Attribute
{
	private string related_image_list;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.RelatedImageListAttribute" /> class.</summary>
	/// <param name="relatedImageList">The name of the <see cref="T:System.Windows.Forms.ImageList" /> the property relates to.</param>
	public RelatedImageListAttribute(string relatedImageList)
	{
	}
}
