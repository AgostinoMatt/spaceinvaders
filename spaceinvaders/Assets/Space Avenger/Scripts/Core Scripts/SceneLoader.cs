using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader {

    /// <summary>
    /// Replay the specified sceneName.
    /// </summary>
    /// <returns>The replay.</returns>
    /// <param name="sceneName">Scene name.</param>
    public static void Replay(string sceneName)
	{
        SceneManager.LoadScene(sceneName);
	}

    /// <summary>
    /// Opens the title scene.
    /// </summary>
	public static void OpenTitleScene()
	{
		SceneManager.LoadScene("Title");
	}

    /// <summary>
    /// Opens the village scene.
    /// </summary>
	public static void OpenVillageScene()
	{
		SceneManager.LoadScene("Village");
	}
}
