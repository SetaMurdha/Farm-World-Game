using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Panel = null;
    public void PlayButton()
    {
        Panel.SetActive(true);
    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void level1()
    {
        SceneManager.LoadScene(1);
    }

    public void level2()
    {
        SceneManager.LoadScene(2);
    }

    public void level3()
    {
        SceneManager.LoadScene(3);
    }

    public void backButton()
    {
        Panel.SetActive(false);
    }

}
