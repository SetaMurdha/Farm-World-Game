using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagerScript : MonoBehaviour
{
    public int meat = 0;
    public int spinach;
    public int honey;
    public int carrot;
    public GameObject WinPanel;
    public Text SkorDaging;
    public Text SkorMadu;
    public Text SkorBayam;
    public Text SkorWortel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameLevel1();
        gameLevel2();
        gameLevel3();
        displayScore();
    }

    public void gameLevel1()
    {
        if(meat == 2)
        {
            WinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void gameLevel2()
    {
        if(meat == 23 && spinach == 12 && honey == 6)
        {
            WinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void gameLevel3()
    {
        if(meat == 29 && spinach == 17 && honey == 13 && carrot == 9)
        {
            WinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void AddMeat(int meatNumber)
    {
        meat = meatNumber;
    }
    public void AddHoney(int honeyNumber)
    {
        honey = honeyNumber;
    }
    public void AddSpinach(int spinachNumber)
    {
        spinach = spinachNumber;
    }
    public void AddCarrot(int carrotNumber)
    {
        carrot = carrotNumber;
    }

    public void displayScore()
    {
        SkorDaging.text = string.Format("{0}", meat);
        SkorMadu.text = string.Format("{0}", honey);
        SkorBayam.text = string.Format("{0}", spinach);
        SkorWortel.text = string.Format("{0}", carrot);
    }

}
