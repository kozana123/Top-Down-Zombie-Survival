using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject coinText;
    public GameObject HealthText;
    public static int coinAmount;
    public static int HealthAmount;

    bool gameHasEnded = false;
    bool gameHasWon = false;
    public float restartDelay = 1f;

    void Update()
    {
        coinText.GetComponent<Text>().text = "Coins: " + coinAmount + " / 8";

        HealthText.GetComponent<Text>().text = "Health: " + HealthAmount + " / 5";

        WinGame();
    }

    public void LoseGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            coinAmount = 0;
            Debug.Log("EndGame");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            
        }
    }

    public void WinGame()
    {
        if (coinAmount == 8)
        {
            gameHasWon = true;
            Debug.Log("WinGame");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

 
}
