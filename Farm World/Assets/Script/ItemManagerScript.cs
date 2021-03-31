using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagerScript : MonoBehaviour
{
    public int meat;
    public int spinach;
    public int honey;
    public int carrot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMeat(int meatNumber)
    {
        meat += meatNumber;
    }
    public void AddHoney(int honeyNumber)
    {
        meat += honeyNumber;
    }
    public void AddSpinach(int spinachNumber)
    {
        meat += spinachNumber;
    }
    public void AddCarrot(int carrotNumber)
    {
        meat += carrotNumber;
    }

}
