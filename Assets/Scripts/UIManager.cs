using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;

    void Start()
    {
        if (gameOverScreen != null)
        {
            Time.timeScale = 1f;
            gameOverScreen.SetActive(false);

        }
    }

    public void ShowGameOverScreen()
    {
        if (gameOverScreen != null)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);

        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
