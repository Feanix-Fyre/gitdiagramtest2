using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class UIDocumentList
{
	internal List<UIDocument> m_AttachedUIDocuments;

	internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument)
	{
	}

	internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0)
	{
	}
}
