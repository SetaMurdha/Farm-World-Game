using System.Collections;
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
        
    }


}
