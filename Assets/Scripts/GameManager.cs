using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	[SerializeField] private CanvasGroup redPanel;
	[SerializeField] private bool fadeIn = false;
	[SerializeField] private bool fadeOut = false;

	//public CameraShake cameraShake;

	//public Vector3 CameraRotation;
	//public Camera mainCamera;

	public void showPanel()
    {
		fadeIn = true;
    }

	public void hidePanel()
    {
		fadeOut = true;
    }

	public void CompleteLevel()
    {
		Debug.Log("Level completed");
		completeLevelUI.SetActive(true);
		//SceneManager.LoadScene("LevelIntro");
    }

	public void EndGame()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			
			//var cameraTransform = mainCamera.GetComponent<RectTransform>();
			//CameraRotation = new Vector3(0, 0, 10);
			//cameraTransform.rotation += CameraRotation;

			//StartCoroutine(cameraShake.Shake(0.2f, 1f));

            showPanel();
			Invoke("Restart", restartDelay);
			hidePanel();
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	private void Update()
    {
		if (fadeIn)
        {
			if (redPanel.alpha < 1)
            {
				redPanel.alpha += Time.deltaTime;
				if (redPanel.alpha >= 1)
                {
					fadeIn = false;
                }
            }
        }
		if (fadeOut)
		{
			if (redPanel.alpha >= 0)
			{
				redPanel.alpha -= Time.deltaTime;
				if (redPanel.alpha == 0)
				{
					fadeOut = false;
				}
			}
		}
	}

}
