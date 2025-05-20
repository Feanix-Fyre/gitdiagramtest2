using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace Unity.Properties.Internal;

internal class ReflectedPropertyBagProvider
{
	[CompilerGenerated]
	private sealed class _003CGetPropertyMembers_003Ed__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private MemberInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Type type;

		public Type _003C_003E3__type;

		private IOrderedEnumerable<MemberInfo> _003Cmembers_003E5__1;

		private IEnumerator<MemberInfo> _003C_003Es__2;

		private MemberInfo _003Cmember_003E5__3;

		private bool _003ChasDontCreatePropertyAttribute_003E5__4;

		private bool _003ChasCreatePropertyAttribute_003E5__5;

		private bool _003ChasNonSerializedAttribute_003E5__6;

		private bool _003ChasSerializedFieldAttribute_003E5__7;

		private FieldInfo _003Cfield_003E5__8;

		MemberInfo IEnumerator<MemberInfo>.Current
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
		public _003CGetPropertyMembers_003Ed__22(int _003C_003E1__state)
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
		IEnumerator<MemberInfo> IEnumerable<MemberInfo>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private readonly MethodInfo m_CreatePropertyMethod;

	private readonly MethodInfo m_CreatePropertyBagMethod;

	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod;

	private readonly MethodInfo m_CreateSetPropertyBagMethod;

	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod;

	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod;

	private readonly MethodInfo m_CreateArrayPropertyBagMethod;

	private readonly MethodInfo m_CreateListPropertyBagMethod;

	private readonly MethodInfo m_CreateHashSetPropertyBagMethod;

	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod;

	public IPropertyBag CreatePropertyBag(Type type)
	{
		return null;
	}

	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>()
	{
		return null;
	}

	[Preserve]
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag)
	{
	}

	[Preserve]
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() where TList : IList<TElement>
	{
		return null;
	}

	[Preserve]
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() where TSet : ISet<TValue>
	{
		return null;
	}

	[Preserve]
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() where TDictionary : IDictionary<TKey, TValue>
	{
		return null;
	}

	[Preserve]
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>()
	{
		return null;
	}

	[Preserve]
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>()
	{
		return null;
	}

	[Preserve]
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>()
	{
		return null;
	}

	[Preserve]
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>()
	{
		return null;
	}

	[Preserve]
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetPropertyMembers_003Ed__22))]
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type)
	{
		return null;
	}

	private static bool IsValidMember(MemberInfo memberInfo)
	{
		return false;
	}

	private static bool IsValidPropertyType(Type type)
	{
		return false;
	}
}
