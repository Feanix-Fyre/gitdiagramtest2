using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;

namespace System.Security.Claims;

/// <summary>Represents a claims-based identity.</summary>
[Serializable]
[ComVisible(true)]
public class ClaimsIdentity : IIdentity
{
	[CompilerGenerated]
	private sealed class _003Cget_Claims_003Ed__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private Claim _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ClaimsIdentity _003C_003E4__this;

		private int _003Ci_003E5__2;

		private IEnumerator<Claim> _003C_003E7__wrap2;

		Claim IEnumerator<Claim>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003Cget_Claims_003Ed__51(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<Claim> IEnumerable<Claim>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[NonSerialized]
	private byte[] m_userSerializationData;

	[NonSerialized]
	private List<Claim> m_instanceClaims;

	[NonSerialized]
	private Collection<IEnumerable<Claim>> m_externalClaims;

	[NonSerialized]
	private string m_nameType;

	[NonSerialized]
	private string m_roleType;

	[OptionalField(VersionAdded = 2)]
	private string m_version;

	[OptionalField(VersionAdded = 2)]
	private ClaimsIdentity m_actor;

	[OptionalField(VersionAdded = 2)]
	private string m_authenticationType;

	[OptionalField(VersionAdded = 2)]
	private object m_bootstrapContext;

	[OptionalField(VersionAdded = 2)]
	private string m_label;

	[OptionalField(VersionAdded = 2)]
	private string m_serializedNameType;

	[OptionalField(VersionAdded = 2)]
	private string m_serializedRoleType;

	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaims;

	/// <summary>Gets the authentication type.</summary>
	/// <returns>The authentication type.</returns>
	public virtual string AuthenticationType => null;

	/// <summary>Gets or sets the identity of the calling party that was granted delegation rights.</summary>
	/// <returns>The calling party that was granted delegation rights.</returns>
	/// <exception cref="T:System.InvalidOperationException">An attempt to set the property to the current instance occurs.</exception>
	public ClaimsIdentity Actor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the claims associated with this claims identity.</summary>
	/// <returns>The collection of claims associated with this claims identity.</returns>
	public virtual IEnumerable<Claim> Claims
	{
		[IteratorStateMachine(typeof(_003Cget_Claims_003Ed__51))]
		get
		{
			return null;
		}
	}

	/// <summary>Gets the name of this claims identity.</summary>
	/// <returns>The name or <see langword="null" />.</returns>
	public virtual string Name => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class with an empty claims collection.</summary>
	public ClaimsIdentity()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class using an enumerated collection of <see cref="T:System.Security.Claims.Claim" /> objects.</summary>
	/// <param name="claims">The claims with which to populate the claims identity.</param>
	public ClaimsIdentity(IEnumerable<Claim> claims)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class from the specified <see cref="T:System.Security.Principal.IIdentity" /> using the specified claims, authentication type, name claim type, and role claim type.</summary>
	/// <param name="identity">The identity from which to base the new claims identity.</param>
	/// <param name="claims">The claims with which to populate the new claims identity.</param>
	/// <param name="authenticationType">The type of authentication used.</param>
	/// <param name="nameType">The claim type to use for name claims.</param>
	/// <param name="roleType">The claim type to use for role claims.</param>
	public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
	{
	}

	internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class from a serialized stream created by using <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary>
	/// <param name="info">The serialized data.</param>
	/// <param name="context">The context for serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is null.</exception>
	protected ClaimsIdentity(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Returns a new <see cref="T:System.Security.Claims.ClaimsIdentity" /> copied from this claims identity.</summary>
	/// <returns>A copy of the current instance.</returns>
	public virtual ClaimsIdentity Clone()
	{
		return null;
	}

	private void SafeAddClaims(IEnumerable<Claim> claims)
	{
	}

	private void SafeAddClaim(Claim claim)
	{
	}

	/// <summary>Retrieves the first claim with the specified claim type.</summary>
	/// <param name="type">The claim type to match.</param>
	/// <returns>The first matching claim or <see langword="null" /> if no match is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is null.</exception>
	public virtual Claim FindFirst(string type)
	{
		return null;
	}

	[OnSerializing]
	private void OnSerializingMethod(StreamingContext context)
	{
	}

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context)
	{
	}

	[OnDeserializing]
	private void OnDeserializingMethod(StreamingContext context)
	{
	}

	/// <summary>Populates the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with data needed to serialize the current <see cref="T:System.Security.Claims.ClaimsIdentity" /> object.</summary>
	/// <param name="info">The object to populate with data.</param>
	/// <param name="context">The destination for this serialization. Can be <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private void DeserializeClaims(string serializedClaims)
	{
	}

	private string SerializeClaims()
	{
		return null;
	}

	private bool IsCircular(ClaimsIdentity subject)
	{
		return false;
	}

	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
	{
	}
}
