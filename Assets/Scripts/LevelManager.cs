using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string NextScene;
    public float sceneTransitionTime;
    public void LoadScene(string sceneName, float waitTime)
    {
        NextScene = sceneName;
        sceneTransitionTime = waitTime;
        SceneManager.LoadScene(NextScene);
    }
}
