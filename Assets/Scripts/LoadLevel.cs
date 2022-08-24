using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoadLevel : MonoBehaviour
{
    
    public void loadLevel()
    {
       // Button play = GameObject.Find().GetComponent<Button>();
        // SceneManager.LoadScene()
        string buttonLevel = EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log(buttonLevel);
        if (buttonLevel == "10")
        {
            SceneManager.LoadScene("Level10");
        }
        else {
            SceneManager.LoadScene("Level0" + buttonLevel);
        }
    }
}
