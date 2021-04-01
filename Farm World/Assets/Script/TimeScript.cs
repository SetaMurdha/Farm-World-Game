using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeRemaining = 10f;
    public GameObject panelLost;
    public Text timeText;
    
    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
        }
        else
        {
            panelLost.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
