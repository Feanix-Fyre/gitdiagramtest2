namespace UnityEngine.UIElements;

public interface IResolvedStyle
{
	Color backgroundColor { get; }

	Color borderBottomColor { get; }

	float borderBottomLeftRadius { get; }

	float borderBottomRightRadius { get; }

	float borderBottomWidth { get; }

	Color borderLeftColor { get; }

	float borderLeftWidth { get; }

	Color borderRightColor { get; }

	float borderRightWidth { get; }

	Color borderTopColor { get; }

	float borderTopLeftRadius { get; }

	float borderTopRightRadius { get; }

	float borderTopWidth { get; }

	float bottom { get; }

	Color color { get; }

	DisplayStyle display { get; }

	FlexDirection flexDirection { get; }

	float flexGrow { get; }

	float flexShrink { get; }

	float height { get; }

	float left { get; }

	float marginBottom { get; }

	float marginLeft { get; }

	float marginRight { get; }

	float marginTop { get; }

	StyleFloat minHeight { get; }

	StyleFloat minWidth { get; }

	float opacity { get; }

	float paddingBottom { get; }

	float paddingLeft { get; }

	float paddingRight { get; }

	float paddingTop { get; }

	float right { get; }

	Scale scale { get; }

	float top { get; }

	Vector3 transformOrigin { get; }

	Vector3 translate { get; }

	Color unityBackgroundImageTintColor { get; }

	int unitySliceLeft { get; }

	int unitySliceRight { get; }

	float unitySliceScale { get; }

	Color unityTextOutlineColor { get; }

	float unityTextOutlineWidth { get; }

	Visibility visibility { get; }

	float width { get; }
}
