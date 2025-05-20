namespace System.Windows.Forms;

/// <summary>Provides custom binding management for components.</summary>
public interface ICurrencyManagerProvider
{
	/// <summary>Gets the <see cref="T:System.Windows.Forms.CurrencyManager" /> associated with this <see cref="T:System.Windows.Forms.ICurrencyManagerProvider" />.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.CurrencyManager" /> associated with this <see cref="T:System.Windows.Forms.ICurrencyManagerProvider" />.</returns>
	CurrencyManager CurrencyManager { get; }

	/// <summary>Gets the <see cref="T:System.Windows.Forms.CurrencyManager" /> for this <see cref="T:System.Windows.Forms.ICurrencyManagerProvider" /> and the specified data member.</summary>
	/// <param name="dataMember">The name of the column or list, within the data source, to obtain the <see cref="T:System.Windows.Forms.CurrencyManager" /> for.</param>
	/// <returns>The related <see cref="T:System.Windows.Forms.CurrencyManager" /> obtained from this <see cref="T:System.Windows.Forms.ICurrencyManagerProvider" /> and the specified data member.</returns>
	CurrencyManager GetRelatedCurrencyManager(string dataMember);
}
