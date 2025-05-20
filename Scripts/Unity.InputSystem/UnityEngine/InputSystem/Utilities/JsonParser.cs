using System;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

internal struct JsonParser
{
	public enum JsonValueType
	{
		None = 0,
		Bool = 1,
		Real = 2,
		Integer = 3,
		String = 4,
		Array = 5,
		Object = 6,
		Any = 7
	}

	public struct JsonString : IEquatable<JsonString>
	{
		public Substring text;

		public bool hasEscapes;

		public override string ToString()
		{
			return null;
		}

		public bool Equals(JsonString other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(JsonString left, JsonString right)
		{
			return false;
		}

		public static bool operator !=(JsonString left, JsonString right)
		{
			return false;
		}

		public static implicit operator JsonString(string str)
		{
			return default(JsonString);
		}
	}

	public struct JsonValue : IEquatable<JsonValue>
	{
		public JsonValueType type;

		public bool boolValue;

		public double realValue;

		public long integerValue;

		public JsonString stringValue;

		public List<JsonValue> arrayValue;

		public Dictionary<string, JsonValue> objectValue;

		public object anyValue;

		public bool ToBoolean()
		{
			return false;
		}

		public long ToInteger()
		{
			return 0L;
		}

		public double ToDouble()
		{
			return 0.0;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator JsonValue(bool val)
		{
			return default(JsonValue);
		}

		public static implicit operator JsonValue(long val)
		{
			return default(JsonValue);
		}

		public static implicit operator JsonValue(double val)
		{
			return default(JsonValue);
		}

		public static implicit operator JsonValue(string str)
		{
			return default(JsonValue);
		}

		public static implicit operator JsonValue(JsonString str)
		{
			return default(JsonValue);
		}

		public static implicit operator JsonValue(List<JsonValue> array)
		{
			return default(JsonValue);
		}

		public static implicit operator JsonValue(Dictionary<string, JsonValue> obj)
		{
			return default(JsonValue);
		}

		public static implicit operator JsonValue(Enum val)
		{
			return default(JsonValue);
		}

		public bool Equals(JsonValue other)
		{
			return false;
		}

		private static bool Equals(object obj, JsonValue value)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(JsonValue left, JsonValue right)
		{
			return false;
		}

		public static bool operator !=(JsonValue left, JsonValue right)
		{
			return false;
		}
	}

	private readonly string m_Text;

	private readonly int m_Length;

	private int m_Position;

	private bool m_MatchAnyElementInArray;

	private bool m_DryRun;

	public bool isAtEnd => false;

	public JsonParser(string json)
	{
		m_Text = null;
		m_Length = 0;
		m_Position = 0;
		m_MatchAnyElementInArray = false;
		m_DryRun = false;
	}

	public void Reset()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public bool NavigateToProperty(string path)
	{
		return false;
	}

	public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue)
	{
		return false;
	}

	public bool ParseToken(char token)
	{
		return false;
	}

	public bool ParseValue()
	{
		return false;
	}

	public bool ParseValue(out JsonValue result)
	{
		result = default(JsonValue);
		return false;
	}

	public bool ParseStringValue(out JsonValue result)
	{
		result = default(JsonValue);
		return false;
	}

	public bool ParseArrayValue(out JsonValue result)
	{
		result = default(JsonValue);
		return false;
	}

	public bool ParseObjectValue(out JsonValue result)
	{
		result = default(JsonValue);
		return false;
	}

	public bool ParseNumber(out JsonValue result)
	{
		result = default(JsonValue);
		return false;
	}

	public bool ParseBooleanValue(out JsonValue result)
	{
		result = default(JsonValue);
		return false;
	}

	public bool ParseNullValue(out JsonValue result)
	{
		result = default(JsonValue);
		return false;
	}

	public bool SkipToValue()
	{
		return false;
	}

	private bool SkipString(string text)
	{
		return false;
	}

	private void SkipWhitespace()
	{
	}
}
