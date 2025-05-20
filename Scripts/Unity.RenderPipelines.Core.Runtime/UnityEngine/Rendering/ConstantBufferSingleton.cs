namespace UnityEngine.Rendering;

internal class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> where CBType : struct
{
	private static ConstantBufferSingleton<CBType> s_Instance;

	internal static ConstantBufferSingleton<CBType> instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Release()
	{
	}
}
