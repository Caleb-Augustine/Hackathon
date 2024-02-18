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

    public EnemyBase enemyScript;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = playerHealth;
        enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyBase>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            currHealth -= enemyScript.enemyDamage;          
        }
    }

}
