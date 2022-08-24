using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void StartGame()
    {
        Invoke("loadGame", 0.125f);
    }

    public void loadShop() {
        SceneManager.LoadScene("Shop");
    }
    public void OpenShop()
    {
        Invoke("loadShop", 0.125f);
    }

    public void loadSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void openSettings()
    {
        Invoke("loadSettings", 0.125f);
    }
}
