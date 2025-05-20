using System;

namespace UnityEngine.Assertions;

public class AssertionException : Exception
{
	private string m_UserMessage;

	public override string Message => null;

	public AssertionException(string message, string userMessage)
	{
	}
}
