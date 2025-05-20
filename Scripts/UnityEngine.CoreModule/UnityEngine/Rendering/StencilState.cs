using System;

namespace UnityEngine.Rendering;

public struct StencilState : IEquatable<StencilState>
{
	private byte m_Enabled;

	private byte m_ReadMask;

	private byte m_WriteMask;

	private byte m_Padding;

	private byte m_CompareFunctionFront;

	private byte m_PassOperationFront;

	private byte m_FailOperationFront;

	private byte m_ZFailOperationFront;

	private byte m_CompareFunctionBack;

	private byte m_PassOperationBack;

	private byte m_FailOperationBack;

	private byte m_ZFailOperationBack;

	public static StencilState defaultValue => default(StencilState);

	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public byte readMask
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public byte writeMask
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public CompareFunction compareFunctionFront
	{
		get
		{
			return default(CompareFunction);
		}
		set
		{
		}
	}

	public StencilOp passOperationFront
	{
		get
		{
			return default(StencilOp);
		}
		set
		{
		}
	}

	public StencilOp failOperationFront
	{
		get
		{
			return default(StencilOp);
		}
		set
		{
		}
	}

	public StencilOp zFailOperationFront
	{
		get
		{
			return default(StencilOp);
		}
		set
		{
		}
	}

	public CompareFunction compareFunctionBack
	{
		get
		{
			return default(CompareFunction);
		}
		set
		{
		}
	}

	public StencilOp passOperationBack
	{
		get
		{
			return default(StencilOp);
		}
		set
		{
		}
	}

	public StencilOp failOperationBack
	{
		get
		{
			return default(StencilOp);
		}
		set
		{
		}
	}

	public StencilOp zFailOperationBack
	{
		get
		{
			return default(StencilOp);
		}
		set
		{
		}
	}

	public StencilState(bool enabled = true, byte readMask = byte.MaxValue, byte writeMask = byte.MaxValue, CompareFunction compareFunction = CompareFunction.Always, StencilOp passOperation = StencilOp.Keep, StencilOp failOperation = StencilOp.Keep, StencilOp zFailOperation = StencilOp.Keep)
	{
		m_Enabled = 0;
		m_ReadMask = 0;
		m_WriteMask = 0;
		m_Padding = 0;
		m_CompareFunctionFront = 0;
		m_PassOperationFront = 0;
		m_FailOperationFront = 0;
		m_ZFailOperationFront = 0;
		m_CompareFunctionBack = 0;
		m_PassOperationBack = 0;
		m_FailOperationBack = 0;
		m_ZFailOperationBack = 0;
	}

	public StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack)
	{
		m_Enabled = 0;
		m_ReadMask = 0;
		m_WriteMask = 0;
		m_Padding = 0;
		m_CompareFunctionFront = 0;
		m_PassOperationFront = 0;
		m_FailOperationFront = 0;
		m_ZFailOperationFront = 0;
		m_CompareFunctionBack = 0;
		m_PassOperationBack = 0;
		m_FailOperationBack = 0;
		m_ZFailOperationBack = 0;
	}

	public void SetCompareFunction(CompareFunction value)
	{
	}

	public void SetPassOperation(StencilOp value)
	{
	}

	public void SetFailOperation(StencilOp value)
	{
	}

	public void SetZFailOperation(StencilOp value)
	{
	}

	public bool Equals(StencilState other)
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
}
