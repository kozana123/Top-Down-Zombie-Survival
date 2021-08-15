using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public int playerHealth;
    public int currentPlayerHealth;

    public float flashLengh;
    private float flashCounter;

    private Renderer rend;
    private Color storedColor;



    // Start is called before the first frame update
    void Start()
    {
        currentPlayerHealth = playerHealth;
        rend = GetComponent<Renderer>();
        storedColor = rend.material.GetColor("_Color");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlayerHealth <= 0)
        {
            gameObject.SetActive(false);
        }

        if (flashCounter > 0)
        {
            flashCounter -= Time.deltaTime;

            if (flashCounter <= 0)
            {
                rend.material.SetColor("_Color", storedColor);
            }
        }

        GameManager.HealthAmount = currentPlayerHealth;

        if (currentPlayerHealth <= 0)
        {
            FindObjectOfType<GameManager>().LoseGame();
        }
    }

    public void HurtPlayer(int damageAmount)
    {
        currentPlayerHealth -= damageAmount;
        flashCounter = flashLengh;
        rend.material.SetColor("_Color", Color.red);
    }


}
