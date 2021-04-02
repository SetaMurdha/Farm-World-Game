using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenButton : MonoBehaviour
{
    public GameObject pauseMenuPanel = null;

    public void pauseGame()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;

    }

    public void resumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void quitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void retryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
