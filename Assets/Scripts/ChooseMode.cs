using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMode : MonoBehaviour
{
    public void LoadLevelsMode()
    {
        SceneManager.LoadScene("Levels");
    }
    public void LoadEndlessMode()
    {
        SceneManager.LoadScene("Endless");
    }
}
