namespace UnityEngine;

public interface IExposedPropertyTable
{
	Object GetReferenceValue(PropertyName id, out bool idValid);
}
