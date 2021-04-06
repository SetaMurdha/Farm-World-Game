using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCatch : MonoBehaviour
{
    public int meatPoint = 0;
    public int honeyPoint = 0;
    public int carrotPoint = 0;
    public int spinachPoint = 0;
    private ItemManagerScript itemMngScrpt;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        itemMngScrpt = FindObjectOfType<ItemManagerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D item)
    {
        if(item.tag == "Daging")
        {
            meatPoint++;
            itemMngScrpt.AddMeat(meatPoint);

        }
        if(item.tag == "Sawi")
        {
            spinachPoint++;
            itemMngScrpt.AddSpinach(spinachPoint);

        }
        if(item.tag == "Madu")
        {
            honeyPoint++;
            itemMngScrpt.AddHoney(honeyPoint);

        }
        if(item.tag == "Wortel")
        {
            carrotPoint++;
            itemMngScrpt.AddCarrot(carrotPoint);

        }
        
    }


}
