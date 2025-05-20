using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine;

[MovedFrom(true, "UnityEditor", "UnityEditor", null)]
public class ExpressionEvaluator
{
	internal class Expression
	{
		internal readonly string[] rpnTokens;

		internal readonly bool hasVariables;

		internal Expression(string expression)
		{
		}

		public bool Evaluate<T>(ref T value, int index = 0, int count = 1)
		{
			return false;
		}
	}

	private struct PcgRandom
	{
		private readonly ulong increment;

		private ulong state;

		public PcgRandom(ulong state = 0uL, ulong sequence = 0uL)
		{
			increment = 0uL;
			this.state = 0uL;
		}

		public uint GetUInt()
		{
			return 0u;
		}

		private static uint RotateRight(uint v, int rot)
		{
			return 0u;
		}

		private static uint XshRr(ulong s)
		{
			return 0u;
		}

		private void Step()
		{
		}
	}

	private enum Op
	{
		Add = 0,
		Sub = 1,
		Mul = 2,
		Div = 3,
		Mod = 4,
		Neg = 5,
		Pow = 6,
		Sqrt = 7,
		Sin = 8,
		Cos = 9,
		Tan = 10,
		Floor = 11,
		Ceil = 12,
		Round = 13,
		Rand = 14,
		Linear = 15
	}

	private enum Associativity
	{
		Left = 0,
		Right = 1
	}

	private class Operator
	{
		public readonly Op op;

		public readonly int precedence;

		public readonly Associativity associativity;

		public readonly int inputs;

		public Operator(Op op, int precedence, int inputs, Associativity associativity)
		{
		}
	}

	private static PcgRandom s_Random;

	private static Dictionary<string, Operator> s_Operators;

	internal static bool Evaluate<T>(string expression, out T value, out Expression delayed)
	{
		value = default(T);
		delayed = null;
		return false;
	}

	private static bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count)
	{
		return false;
	}

	private static bool EvaluateDouble(string[] tokens, ref double value, int index, int count)
	{
		return false;
	}

	private static string[] InfixToRPN(string[] tokens)
	{
		return null;
	}

	private static bool NeedToPop(Stack<string> operatorStack, Operator newOperator)
	{
		return false;
	}

	private static string[] ExpressionToTokens(string expression, out bool hasVariables)
	{
		hasVariables = default(bool);
		return null;
	}

	private static bool IsCommand(string token)
	{
		return false;
	}

	private static bool IsVariable(string token)
	{
		return false;
	}

	private static bool IsDelayedFunction(string token)
	{
		return false;
	}

	private static bool IsOperator(string token)
	{
		return false;
	}

	private static Operator TokenToOperator(string token)
	{
		return null;
	}

	private static string PreFormatExpression(string expression)
	{
		return null;
	}

	private static string[] FixUnaryOperators(string[] tokens)
	{
		return null;
	}

	private static double EvaluateOp(double[] values, Op op, int index, int count)
	{
		return 0.0;
	}

	private static bool TryParse<T>(string expression, out T result)
	{
		result = default(T);
		return false;
	}
}
