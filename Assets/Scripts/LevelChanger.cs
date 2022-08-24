using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    private int levelToLoad;
    public GameManager gameManager;
    [SerializeField] GameObject end;

    private void Awake()
    {
        gameManager = end.GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (gameManager.completeLevelUI.activeSelf)
        {
            FadeToLevel(5);
        }
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
