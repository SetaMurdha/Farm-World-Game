using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SawiScript : MonoBehaviour
{
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
        if(item.tag == "player")
        {
            Destroy(gameObject);
            spinachPoint++;
            itemMngScrpt.AddSpinach(spinachPoint);

        }
        
    }


}
