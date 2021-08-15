using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageToGive;

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            Other.gameObject.GetComponent<PlayerManager>().HurtPlayer(damageToGive);

        }
    }
}
