using System.Text;

namespace System.Net;

internal class ResponseDescription
{
	internal bool Multiline;

	internal int Status;

	internal string StatusDescription;

	internal StringBuilder StatusBuffer;

	internal string StatusCodeString;

	internal bool PositiveIntermediate => false;

	internal bool PositiveCompletion => false;

	internal bool TransientFailure => false;

	internal bool PermanentFailure => false;

	internal bool InvalidStatusCode => false;
}
