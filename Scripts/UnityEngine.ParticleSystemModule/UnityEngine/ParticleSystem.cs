using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[UsedByNativeCode]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
public sealed class ParticleSystem : Component
{
	public struct MainModule
	{
		internal ParticleSystem m_ParticleSystem;

		public float duration => 0f;

		public bool loop => false;

		public MinMaxCurve startLifetime
		{
			get
			{
				return default(MinMaxCurve);
			}
			[NativeThrows]
			set
			{
			}
		}

		public MinMaxCurve startSpeed
		{
			get
			{
				return default(MinMaxCurve);
			}
			[NativeThrows]
			set
			{
			}
		}

		[NativeName("StartSizeX")]
		public MinMaxCurve startSize
		{
			get
			{
				return default(MinMaxCurve);
			}
			[NativeThrows]
			set
			{
			}
		}

		public MinMaxGradient startColor
		{
			get
			{
				return default(MinMaxGradient);
			}
			[NativeThrows]
			set
			{
			}
		}

		public float simulationSpeed
		{
			[NativeThrows]
			set
			{
			}
		}

		public int maxParticles
		{
			get
			{
				return 0;
			}
			[NativeThrows]
			set
			{
			}
		}

		internal MainModule(ParticleSystem particleSystem)
		{
			m_ParticleSystem = null;
		}

		[SpecialName]
		private static float get_duration_Injected(ref MainModule _unity_self)
		{
			return 0f;
		}

		[SpecialName]
		private static bool get_loop_Injected(ref MainModule _unity_self)
		{
			return false;
		}

		[SpecialName]
		private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret)
		{
			ret = default(MinMaxCurve);
		}

		[SpecialName]
		private static void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value)
		{
		}

		[SpecialName]
		private static void get_startSpeed_Injected(ref MainModule _unity_self, out MinMaxCurve ret)
		{
			ret = default(MinMaxCurve);
		}

		[SpecialName]
		private static void set_startSpeed_Injected(ref MainModule _unity_self, ref MinMaxCurve value)
		{
		}

		[SpecialName]
		private static void get_startSize_Injected(ref MainModule _unity_self, out MinMaxCurve ret)
		{
			ret = default(MinMaxCurve);
		}

		[SpecialName]
		private static void set_startSize_Injected(ref MainModule _unity_self, ref MinMaxCurve value)
		{
		}

		[SpecialName]
		private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret)
		{
			ret = default(MinMaxGradient);
		}

		[SpecialName]
		private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value)
		{
		}

		[SpecialName]
		private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static int get_maxParticles_Injected(ref MainModule _unity_self)
		{
			return 0;
		}

		[SpecialName]
		private static void set_maxParticles_Injected(ref MainModule _unity_self, int value)
		{
		}
	}

	public struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem;

		public MinMaxCurve rateOverTime
		{
			get
			{
				return default(MinMaxCurve);
			}
			[NativeThrows]
			set
			{
			}
		}

		internal EmissionModule(ParticleSystem particleSystem)
		{
			m_ParticleSystem = null;
		}

		[SpecialName]
		private static void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret)
		{
			ret = default(MinMaxCurve);
		}

		[SpecialName]
		private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value)
		{
		}
	}

	public struct ShapeModule
	{
		internal ParticleSystem m_ParticleSystem;

		public ParticleSystemShapeType shapeType
		{
			[NativeThrows]
			set
			{
			}
		}

		public float randomDirectionAmount
		{
			[NativeThrows]
			set
			{
			}
		}

		public float radius
		{
			[NativeThrows]
			set
			{
			}
		}

		public float angle
		{
			[NativeThrows]
			set
			{
			}
		}

		public float length
		{
			[NativeThrows]
			set
			{
			}
		}

		public float arc
		{
			[NativeThrows]
			set
			{
			}
		}

		public Vector3 position
		{
			[NativeThrows]
			set
			{
			}
		}

		internal ShapeModule(ParticleSystem particleSystem)
		{
			m_ParticleSystem = null;
		}

		[SpecialName]
		private static void set_shapeType_Injected(ref ShapeModule _unity_self, ParticleSystemShapeType value)
		{
		}

		[SpecialName]
		private static void set_randomDirectionAmount_Injected(ref ShapeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_radius_Injected(ref ShapeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_angle_Injected(ref ShapeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_length_Injected(ref ShapeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_arc_Injected(ref ShapeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_position_Injected(ref ShapeModule _unity_self, ref Vector3 value)
		{
		}
	}

	public struct CollisionModule
	{
		internal ParticleSystem m_ParticleSystem;

		public LayerMask collidesWith
		{
			get
			{
				return default(LayerMask);
			}
			[NativeThrows]
			set
			{
			}
		}

		public bool sendCollisionMessages
		{
			[NativeThrows]
			set
			{
			}
		}

		internal CollisionModule(ParticleSystem particleSystem)
		{
			m_ParticleSystem = null;
		}

		[SpecialName]
		private static void get_collidesWith_Injected(ref CollisionModule _unity_self, out LayerMask ret)
		{
			ret = default(LayerMask);
		}

		[SpecialName]
		private static void set_collidesWith_Injected(ref CollisionModule _unity_self, ref LayerMask value)
		{
		}

		[SpecialName]
		private static void set_sendCollisionMessages_Injected(ref CollisionModule _unity_self, bool value)
		{
		}
	}

	public struct TriggerModule
	{
		internal ParticleSystem m_ParticleSystem;

		internal TriggerModule(ParticleSystem particleSystem)
		{
			m_ParticleSystem = null;
		}

		[NativeThrows]
		public void AddCollider(Component collider)
		{
		}

		[NativeThrows]
		public Component GetCollider(int index)
		{
			return null;
		}

		private static void AddCollider_Injected(ref TriggerModule _unity_self, Component collider)
		{
		}

		private static Component GetCollider_Injected(ref TriggerModule _unity_self, int index)
		{
			return null;
		}
	}

	public struct SubEmittersModule
	{
		internal ParticleSystem m_ParticleSystem;

		public int subEmittersCount => 0;

		internal SubEmittersModule(ParticleSystem particleSystem)
		{
			m_ParticleSystem = null;
		}

		[NativeThrows]
		public ParticleSystem GetSubEmitterSystem(int index)
		{
			return null;
		}

		[SpecialName]
		private static int get_subEmittersCount_Injected(ref SubEmittersModule _unity_self)
		{
			return 0;
		}

		private static ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index)
		{
			return null;
		}
	}

	[RequiredByNativeCode("particleSystemParticle", Optional = true)]
	public struct Particle
	{
		private Vector3 m_Position;

		private Vector3 m_Velocity;

		private Vector3 m_AnimatedVelocity;

		private Vector3 m_InitialVelocity;

		private Vector3 m_AxisOfRotation;

		private Vector3 m_Rotation;

		private Vector3 m_AngularVelocity;

		private Vector3 m_StartSize;

		private Color32 m_StartColor;

		private uint m_RandomSeed;

		private uint m_ParentRandomSeed;

		private float m_Lifetime;

		private float m_StartLifetime;

		private int m_MeshIndex;

		private float m_EmitAccumulator0;

		private float m_EmitAccumulator1;

		private uint m_Flags;

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
		public float lifetime
		{
			set
			{
			}
		}

		public Vector3 position
		{
			set
			{
			}
		}

		public Vector3 velocity
		{
			set
			{
			}
		}

		public float remainingLifetime
		{
			set
			{
			}
		}

		public float startLifetime
		{
			set
			{
			}
		}

		public Color32 startColor
		{
			set
			{
			}
		}

		public uint randomSeed
		{
			set
			{
			}
		}

		public float startSize
		{
			set
			{
			}
		}

		public Vector3 rotation3D
		{
			set
			{
			}
		}

		public Vector3 angularVelocity3D
		{
			set
			{
			}
		}
	}

	[Serializable]
	[NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	public struct MinMaxCurve
	{
		[SerializeField]
		private ParticleSystemCurveMode m_Mode;

		[SerializeField]
		private float m_CurveMultiplier;

		[SerializeField]
		private AnimationCurve m_CurveMin;

		[SerializeField]
		private AnimationCurve m_CurveMax;

		[SerializeField]
		private float m_ConstantMin;

		[SerializeField]
		private float m_ConstantMax;

		public ParticleSystemCurveMode mode
		{
			set
			{
			}
		}

		public float constantMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float constantMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float constant
		{
			set
			{
			}
		}

		public MinMaxCurve(float constant)
		{
			m_Mode = default(ParticleSystemCurveMode);
			m_CurveMultiplier = 0f;
			m_CurveMin = null;
			m_CurveMax = null;
			m_ConstantMin = 0f;
			m_ConstantMax = 0f;
		}

		public MinMaxCurve(float min, float max)
		{
			m_Mode = default(ParticleSystemCurveMode);
			m_CurveMultiplier = 0f;
			m_CurveMin = null;
			m_CurveMax = null;
			m_ConstantMin = 0f;
			m_ConstantMax = 0f;
		}
	}

	[Serializable]
	[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	public struct MinMaxGradient
	{
		[SerializeField]
		private ParticleSystemGradientMode m_Mode;

		[SerializeField]
		private Gradient m_GradientMin;

		[SerializeField]
		private Gradient m_GradientMax;

		[SerializeField]
		private Color m_ColorMin;

		[SerializeField]
		private Color m_ColorMax;

		public ParticleSystemGradientMode mode
		{
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Gradient gradient
		{
			set
			{
			}
		}

		public MinMaxGradient(Color color)
		{
			m_Mode = default(ParticleSystemGradientMode);
			m_GradientMin = null;
			m_GradientMax = null;
			m_ColorMin = default(Color);
			m_ColorMax = default(Color);
		}

		public static implicit operator MinMaxGradient(Color color)
		{
			return default(MinMaxGradient);
		}
	}

	public struct EmitParams
	{
		[NativeName("particle")]
		private Particle m_Particle;

		[NativeName("positionSet")]
		private bool m_PositionSet;

		[NativeName("velocitySet")]
		private bool m_VelocitySet;

		[NativeName("axisOfRotationSet")]
		private bool m_AxisOfRotationSet;

		[NativeName("rotationSet")]
		private bool m_RotationSet;

		[NativeName("rotationalSpeedSet")]
		private bool m_AngularVelocitySet;

		[NativeName("startSizeSet")]
		private bool m_StartSizeSet;

		[NativeName("startColorSet")]
		private bool m_StartColorSet;

		[NativeName("randomSeedSet")]
		private bool m_RandomSeedSet;

		[NativeName("startLifetimeSet")]
		private bool m_StartLifetimeSet;

		[NativeName("meshIndexSet")]
		private bool m_MeshIndexSet;

		[NativeName("applyShapeToPosition")]
		private bool m_ApplyShapeToPosition;
	}

	public struct VelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem;

		public bool enabled
		{
			[NativeThrows]
			set
			{
			}
		}

		public float xMultiplier
		{
			[NativeThrows]
			set
			{
			}
		}

		public float yMultiplier
		{
			[NativeThrows]
			set
			{
			}
		}

		public float zMultiplier
		{
			[NativeThrows]
			set
			{
			}
		}

		public ParticleSystemSimulationSpace space
		{
			[NativeThrows]
			set
			{
			}
		}

		internal VelocityOverLifetimeModule(ParticleSystem particleSystem)
		{
			m_ParticleSystem = null;
		}

		[SpecialName]
		private static void set_enabled_Injected(ref VelocityOverLifetimeModule _unity_self, bool value)
		{
		}

		[SpecialName]
		private static void set_xMultiplier_Injected(ref VelocityOverLifetimeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_yMultiplier_Injected(ref VelocityOverLifetimeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_zMultiplier_Injected(ref VelocityOverLifetimeModule _unity_self, float value)
		{
		}

		[SpecialName]
		private static void set_space_Injected(ref VelocityOverLifetimeModule _unity_self, ParticleSystemSimulationSpace value)
		{
		}
	}

	[Obsolete("startColor property is deprecated. Use main.startColor instead.", false)]
	public Color startColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool isPlaying
	{
		[NativeName("SyncJobs(false)->IsPlaying")]
		get
		{
			return false;
		}
	}

	public bool isEmitting
	{
		[NativeName("SyncJobs(false)->IsEmitting")]
		get
		{
			return false;
		}
	}

	public int particleCount
	{
		[NativeName("SyncJobs(false)->GetParticleCount")]
		get
		{
			return 0;
		}
	}

	public float time
	{
		[NativeName("SyncJobs(false)->GetSecPosition")]
		get
		{
			return 0f;
		}
	}

	public uint randomSeed
	{
		[NativeName("SyncJobs(false)->SetRandomSeed")]
		set
		{
		}
	}

	public bool useAutoRandomSeed
	{
		[NativeName("GetAutoRandomSeed")]
		get
		{
			return false;
		}
		[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
		set
		{
		}
	}

	public MainModule main => default(MainModule);

	public EmissionModule emission => default(EmissionModule);

	public ShapeModule shape => default(ShapeModule);

	public VelocityOverLifetimeModule velocityOverLifetime => default(VelocityOverLifetimeModule);

	public CollisionModule collision => default(CollisionModule);

	public TriggerModule trigger => default(TriggerModule);

	public SubEmittersModule subEmitters => default(SubEmittersModule);

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
	{
	}

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
	public void Emit(Particle particle)
	{
	}

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
	public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep)
	{
	}

	public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart)
	{
	}

	public void Simulate(float t, [DefaultValue("true")] bool withChildren)
	{
	}

	public void Simulate(float t)
	{
	}

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
	public void Play([DefaultValue("true")] bool withChildren)
	{
	}

	public void Play()
	{
	}

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
	public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior)
	{
	}

	public void Stop([DefaultValue("true")] bool withChildren)
	{
	}

	public void Stop()
	{
	}

	[RequiredByNativeCode]
	public void Emit(int count)
	{
	}

	[NativeName("SyncJobs()->Emit")]
	private void Emit_Internal(int count)
	{
	}

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	public void Emit(EmitParams emitParams, int count)
	{
	}

	[NativeName("SyncJobs()->EmitParticleExternal")]
	private void EmitOld_Internal(ref Particle particle)
	{
	}

	private void Emit_Injected(ref EmitParams emitParams, int count)
	{
	}
}
