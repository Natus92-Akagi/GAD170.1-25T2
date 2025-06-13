using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GADOneSevenZeroProjectOne : MonoBehaviour
{
   // the Player's variables 
    public string playerName = "Mario";
    public int playerLevel = 0;
    public int playerAttack = 0;
    public int playerExp = 0;
    public int playerGainExp = 0;
    public int[] playerExpThreshold = new int[4] { 125, 156, 195, 243 };
    public float playerAttackIncreaseRate = 0;
    public float playerExpThresholdIncreaseRate = 0;
    
    // the Enemy's variables 
    public string enemyName = "";
    public int enemyLevel = 0;
    public int enemyHealth = 0;

    //check the game is playing
    public bool gameIsPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        playerLevel = 1;
        playerAttack = 15;
        playerExp = 0;
        playerAttackIncreaseRate = 1.25f;
        playerExpThresholdIncreaseRate = 1.25f;
        enemyLevel = Random.Range(0, 4 + 1);
        enemyHealth = Random.Range(156, 356 + 1);
        playerGainExp = Random.Range(30, 60 + 1);

        gameIsPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
