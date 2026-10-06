using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string NextScene;
    public Scene currentScene;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
    }
    public void LoadScene(string sceneName, Scene currentActiveScene)
    {
        NextScene = sceneName;
        currentScene = currentActiveScene;
        SceneManager.LoadScene(NextScene);
    }


}
