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
    public int playerExpThreshold = 0;
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
        // the player defutls stats
        playerLevel = 1;
        playerAttack = 15;
        playerExp = 0;
        playerExpThreshold = 125;
        playerAttackIncreaseRate = 1.25f;
        playerExpThresholdIncreaseRate = 1.25f;
        playerGainExp = Random.Range(30, 60 + 1);
        // the Enmey stats for the game
        enemyLevel = Random.Range(0, 4 + 1);
        enemyHealth = Random.Range(156, 356 + 1);


        gameIsPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        gameIsPlaying = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            AttackEnemy(Mathf.RoundToInt(playerAttack));
            


            // if the enemy less than or equal to 0 health 
            if (IsEnemyDead() == true)
            {
                GainExp();
                LevelUp();
                // spawn new Koopa
                SpawnNewEnemy();
            }




        }


    }
    public void AttackEnemy(int amount)
    {
        // the enemy taken damage from player who control Mario
        enemyHealth = enemyHealth - amount;
        Debug.Log("The Enemy: " + enemyName + " Has " + enemyHealth + " HP " + " level " + enemyLevel);
    }
    public void SpawnNewEnemy()
    {
        // the Enemies will Bowser along with Bowser Jr. and the Kooopalings
        enemyHealth = Random.Range(120, 500 + 1);
        enemyLevel = Random.Range(1, 5 + 1);

        int randomNumber = Random.Range(0, 8);

        if (randomNumber == 0)
        {
            enemyName = "Bowser";
        }
        if (randomNumber == 1)
        {
            enemyName = "Bowser Jr.";
        }
        if (randomNumber == 2)
        {
            enemyName = "Larry Koopa";
        }
        if (randomNumber == 3)
        {
            enemyName = "Morton Koopa Jr.";
        }
        if (randomNumber == 4)
        {
            enemyName = "Wendy O. Koopa";
        }
        if (randomNumber == 5)
        {
            enemyName = "Iggy Koopa";
        }
        if (randomNumber == 6)
        {
            enemyName = "Roy Koopa";
        }
        if (randomNumber == 7)
        {
            enemyName = "Lemmy Koopa";
        }
        if (randomNumber == 8)
        {
            enemyName = "Ludwig von Koopa";
        }
    }
    public bool IsEnemyDead()
    {
        // this for koopa is defeat it
        bool isDead = (enemyHealth <= 0);
        Debug.Log("Koopa is defeat it?" + true);
        return true;
    }
    public void LevelUp()
    {
        //if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (playerExp >= playerExpThreshold)
            {
                // the player level up faction 
                playerLevel = playerLevel + 1;
                playerExp = playerExp - playerExpThreshold;
                playerExpThreshold = playerExpThreshold + 25;

                Debug.Log(playerName + " level " + playerLevel);
            }
        }

    }
    public void GainExp()
    {
        playerExp = playerExp + playerGainExp + Random.Range(30, 60 + 1);

        Debug.Log(" Ganied this " + playerGainExp + " Exp! "); 
    }
}
    