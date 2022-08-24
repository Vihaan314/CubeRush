using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayAgain()
    {
        Invoke("mainMenu", 0.125f);
    }
}
