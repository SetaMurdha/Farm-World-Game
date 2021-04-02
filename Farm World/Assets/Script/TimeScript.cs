using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 10;
    public GameObject panelLost;
    public Text timeText;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeRemaining > 1)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
            DisplayTime(timeRemaining);
        }
        else
        {
            panelLost.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
