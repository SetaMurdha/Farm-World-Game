using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenButton : MonoBehaviour
{
    public GameObject pauseMenuPanel;

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
        quitGame();
    }

}
