using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public int damageToGive = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision coli)
    {
        if (coli.gameObject.tag == "Enemy")
        {
            coli.gameObject.GetComponent<Enemy>().HurtEnemy(damageToGive);
            Destroy(gameObject);
        }
    }
}
