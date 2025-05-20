using System.Collections;

namespace System.Xml;

/// <summary>Represents a collection of nodes that can be accessed by name or index.</summary>
public class XmlNamedNodeMap : IEnumerable
{
	internal struct SmallXmlNodeList
	{
		private class SingleObjectEnumerator : IEnumerator
		{
			private object loneValue;

			private int position;

			public object Current => null;

			public SingleObjectEnumerator(object value)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private object field;

		public int Count => 0;

		public object this[int index] => null;

		public void Add(object value)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Insert(int index, object value)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	internal XmlNode parent;

	internal SmallXmlNodeList nodes;

	/// <summary>Gets the number of nodes in the <see langword="XmlNamedNodeMap" />.</summary>
	/// <returns>The number of nodes.</returns>
	public virtual int Count => 0;

	internal XmlNamedNodeMap(XmlNode parent)
	{
	}

	/// <summary>Retrieves an <see cref="T:System.Xml.XmlNode" /> specified by name.</summary>
	/// <param name="name">The qualified name of the node to retrieve. It is matched against the <see cref="P:System.Xml.XmlNode.Name" /> property of the matching node.</param>
	/// <returns>An <see langword="XmlNode" /> with the specified name or <see langword="null" /> if a matching node is not found.</returns>
	public virtual XmlNode GetNamedItem(string name)
	{
		return null;
	}

	/// <summary>Adds an <see cref="T:System.Xml.XmlNode" /> using its <see cref="P:System.Xml.XmlNode.Name" /> property.</summary>
	/// <param name="node">An <see langword="XmlNode" /> to store in the <see langword="XmlNamedNodeMap" />. If a node with that name is already present in the map, it is replaced by the new one.</param>
	/// <returns>If the <paramref name="node" /> replaces an existing node with the same name, the old node is returned; otherwise, <see langword="null" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="node" /> was created from a different <see cref="T:System.Xml.XmlDocument" /> than the one that created the <see langword="XmlNamedNodeMap" />; or the <see langword="XmlNamedNodeMap" /> is read-only.</exception>
	public virtual XmlNode SetNamedItem(XmlNode node)
	{
		return null;
	}

	/// <summary>Provides support for the "foreach" style iteration over the collection of nodes in the <see langword="XmlNamedNodeMap" />.</summary>
	/// <returns>An enumerator object.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	internal int FindNodeOffset(string name)
	{
		return 0;
	}

	internal int FindNodeOffset(string localName, string namespaceURI)
	{
		return 0;
	}

	internal virtual XmlNode AddNode(XmlNode node)
	{
		return null;
	}

	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
	{
		return null;
	}

	internal virtual XmlNode RemoveNodeAt(int i)
	{
		return null;
	}

	internal XmlNode ReplaceNodeAt(int i, XmlNode node)
	{
		return null;
	}

	internal virtual XmlNode InsertNodeAt(int i, XmlNode node)
	{
		return null;
	}
}
