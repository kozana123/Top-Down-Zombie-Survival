using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
 
    public float moveSpeed = 5f;
    private Rigidbody rb;
    public GameObject target;
    public int health;
    private int currentHealth;

    public PlayerMove thePlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerMove>();
        currentHealth = health;

    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(thePlayer.transform.position);

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

     void FixedUpdate()
    {
        rb.velocity = (transform.forward * moveSpeed);
    }

    public void HurtEnemy (int damage)
    {
        currentHealth -= damage;
    }
    
}
