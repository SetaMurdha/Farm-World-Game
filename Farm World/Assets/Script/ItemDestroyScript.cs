using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDestroyScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D item)
    {
        if(item.tag == "player" || item.tag == "Destroyer")
        {
            Destroy(gameObject);

        }
        
    }


}
