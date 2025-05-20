namespace UnityEngine.SceneManagement;

public class SceneManagerAPI
{
	private static SceneManagerAPI s_DefaultAPI;

	internal static SceneManagerAPI ActiveAPI => null;

	public static SceneManagerAPI overrideAPI { get; }

	protected internal SceneManagerAPI()
	{
	}

	protected internal virtual int GetNumScenesInBuildSettings()
	{
		return 0;
	}

	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}

	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
	{
		return null;
	}
}
