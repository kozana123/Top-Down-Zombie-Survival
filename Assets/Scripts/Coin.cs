using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(360 * Time.deltaTime, 0 * Time.deltaTime, 0 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            GameManager.coinAmount += 1;
            Destroy(this.gameObject);
        }
    }

    
}