using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPanelScript : MonoBehaviour
{
    public GameObject setPanel;
    public GameObject setPanel1 = null;
    public GameObject setPanel2 = null;

    // Start is called before the first frame update
    void Start()
    {
        setPanel.SetActive(false);
        setPanel1.SetActive(false);
        setPanel2.SetActive(false);
        Time.timeScale = 1f;
    }

}
