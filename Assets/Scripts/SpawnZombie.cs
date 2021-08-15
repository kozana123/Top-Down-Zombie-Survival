using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{

    public Vector3 center;
    public Vector3 size;

    public GameObject zombie;
    public GameObject coin;
    public float spawnCounter = 0.65f;
    public float spawnCoin = 10;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (spawnCounter > 0)
        {
            spawnCounter -= Time.deltaTime;

            if (spawnCounter <= 0)
            {
                SpwanZombie();
            }

        }

        if (spawnCounter <= 0)
        {
            spawnCounter += 0.65f;
        }

        if (spawnCoin > 0)
        {
            spawnCoin -= Time.deltaTime;

            if (spawnCoin <= 0)
            {
                SpwanCoin();
            }

        }

        if (spawnCoin <= 0)
        {
            spawnCoin += 10;
        }

    }

    public void SpwanCoin()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
 

        Instantiate(coin, pos, Quaternion.identity);

    }



    public void SpwanZombie()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(zombie, pos, Quaternion.identity);

    } 
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube( center, size);

    }
}
