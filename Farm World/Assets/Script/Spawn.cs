using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] items;
    public GameObject[] obstacles;

    public float xBounds;
    public float yBounds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    // Update is called once per frame
    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomItem = Random.Range(0, items.Length);
        int randomObstacle = Random.Range(0, obstacles.Length);

        if (Random.value <= .6f){
            Instantiate(items[randomItem], new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        }
        else
        {
            Instantiate(obstacles[randomObstacle], new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        }
        StartCoroutine(SpawnRandomGameObject());
    }

}
