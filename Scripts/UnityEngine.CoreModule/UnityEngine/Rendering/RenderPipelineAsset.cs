namespace UnityEngine.Rendering;

public abstract class RenderPipelineAsset : ScriptableObject
{
	public virtual string[] renderingLayerMaskNames => null;

	public virtual string[] prefixedRenderingLayerMaskNames => null;

	public virtual Material defaultMaterial => null;

	public virtual Shader autodeskInteractiveShader => null;

	public virtual Shader autodeskInteractiveTransparentShader => null;

	public virtual Shader autodeskInteractiveMaskedShader => null;

	public virtual Shader terrainDetailLitShader => null;

	public virtual Shader terrainDetailGrassShader => null;

	public virtual Shader terrainDetailGrassBillboardShader => null;

	public virtual Material defaultParticleMaterial => null;

	public virtual Material defaultLineMaterial => null;

	public virtual Material defaultTerrainMaterial => null;

	public virtual Material defaultUIMaterial => null;

	public virtual Material defaultUIOverdrawMaterial => null;

	public virtual Material defaultUIETC1SupportedMaterial => null;

	public virtual Material default2DMaterial => null;

	public virtual Material default2DMaskMaterial => null;

	public virtual Shader defaultShader => null;

	public virtual Shader defaultSpeedTree7Shader => null;

	public virtual Shader defaultSpeedTree8Shader => null;

	public virtual string renderPipelineShaderTag => null;

	internal RenderPipeline InternalCreatePipeline()
	{
		return null;
	}

	protected abstract RenderPipeline CreatePipeline();

	protected virtual void OnValidate()
	{
	}

	protected virtual void OnDisable()
	{
	}
}
