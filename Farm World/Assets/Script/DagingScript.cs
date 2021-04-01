using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DagingScript : MonoBehaviour
{
    public int meatPoint = 0;
    private ItemManagerScript itemMngScrpt;

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
        if(item.tag == "player")
        {
            Destroy(gameObject);
            itemMngScrpt.AddMeat(meatPoint);
        }
        
    }

}
