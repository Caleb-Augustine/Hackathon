using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Tooltip("This is the total player health. This is an int.")]
    public int playerHealth; 
    [Tooltip("This is the player base health. This is an int.")]
    public int playerBaseHealth;
    [Tooltip("This is the current player health. This is an int.")]
    public int currHealth;
    public DeathScene deathScene;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = playerHealth;
        deathScene = GameObject.FindGameObjectWithTag("GameManager").GetComponent<DeathScene>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if(currHealth <= 0)
        {
            gameObject.SetActive(false); //Setting the player inactive to allow the death screen to spawn.
            deathScene.isPause = true;
            //Play End Screen
        }
        
    }


}
