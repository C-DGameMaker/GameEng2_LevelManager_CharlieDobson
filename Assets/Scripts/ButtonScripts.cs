using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void MainMenuButton()
    {
        ServiceHubManager.Instance.levelManager.LoadScene(1);
    }

    public void Level1Button()
    {
        ServiceHubManager.Instance.levelManager.LoadScene(2);
    }

    public void Level2Button()
    {
        ServiceHubManager.Instance.levelManager.LoadScene(0);
    }
}
