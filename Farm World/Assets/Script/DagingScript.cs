﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DagingScript : MonoBehaviour
{
    public int meatPoint = 0;
    private ItemManagerScript itemMngScrpt;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        itemMngScrpt = FindObjectOfType<ItemManagerScript>();
        DisplayScore(meatPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D item)
    {
        if(item.tag == "player")
        {
            Destroy(gameObject);
            meatPoint++;
            itemMngScrpt.AddMeat(meatPoint);

        }
        
    }

    void DisplayScore(int Score)
    {
        score.text = string.Format("{0}", Score);
    }

}
