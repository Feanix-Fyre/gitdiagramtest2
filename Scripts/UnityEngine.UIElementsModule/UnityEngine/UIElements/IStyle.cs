namespace UnityEngine.UIElements;

public interface IStyle
{
	StyleColor backgroundColor { set; }

	StyleBackgroundSize backgroundSize { get; }

	StyleColor borderBottomColor { set; }

	StyleLength borderBottomLeftRadius { set; }

	StyleLength borderBottomRightRadius { set; }

	StyleFloat borderBottomWidth { set; }

	StyleColor borderLeftColor { set; }

	StyleFloat borderLeftWidth { set; }

	StyleColor borderRightColor { set; }

	StyleFloat borderRightWidth { set; }

	StyleColor borderTopColor { set; }

	StyleLength borderTopLeftRadius { set; }

	StyleLength borderTopRightRadius { set; }

	StyleFloat borderTopWidth { set; }

	StyleLength bottom { set; }

	StyleColor color { set; }

	StyleCursor cursor { get; }

	StyleEnum<DisplayStyle> display { get; set; }

	StyleLength flexBasis { set; }

	StyleEnum<FlexDirection> flexDirection { set; }

	StyleFloat flexGrow { set; }

	StyleFloat flexShrink { set; }

	StyleLength fontSize { set; }

	StyleLength height { set; }

	StyleLength left { set; }

	StyleLength marginBottom { set; }

	StyleLength marginLeft { set; }

	StyleLength marginRight { set; }

	StyleLength marginTop { set; }

	StyleLength maxHeight { set; }

	StyleLength maxWidth { set; }

	StyleLength minWidth { set; }

	StyleFloat opacity { set; }

	StyleEnum<Overflow> overflow { set; }

	StyleLength paddingBottom { set; }

	StyleLength paddingLeft { set; }

	StyleLength paddingRight { set; }

	StyleLength paddingTop { get; set; }

	StyleEnum<Position> position { set; }

	StyleLength right { set; }

	StyleRotate rotate { get; }

	StyleScale scale { get; }

	StyleTextShadow textShadow { get; }

	StyleLength top { set; }

	StyleTransformOrigin transformOrigin { get; }

	StyleTranslate translate { get; set; }

	StyleColor unityBackgroundImageTintColor { set; }

	StyleFont unityFont { set; }

	StyleFontDefinition unityFontDefinition { set; }

	StyleEnum<Visibility> visibility { set; }

	StyleLength width { get; set; }
}
