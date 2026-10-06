using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void MainMenuButton()
    {
        ServiceHubManager.Instance.levelManager.LoadScene("Level1", SceneManager.GetActiveScene());
    }

    public void Level1Button()
    {
        ServiceHubManager.Instance.levelManager.LoadScene("Level2", SceneManager.GetActiveScene());
    }

    public void Level2Button()
    {
        ServiceHubManager.Instance.levelManager.LoadScene("MainMenu", SceneManager.GetActiveScene());
    }
}
