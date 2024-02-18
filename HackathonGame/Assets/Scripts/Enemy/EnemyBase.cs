using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public EnemyScriptable enemyType;


    public GameObject coin;

    public int currentHealth;
    public int enemyDamage;
    public int coinDropAmount;




    // Start is called before the first frame update
    void Start()
    {
        enemyDamage = enemyType.enemyDamage;
        currentHealth = enemyType.enemyHealth;
        coinDropAmount = enemyType.coinDropAmount;


    }

    // Update is called once per frame
    void Update()
    {
        HealthCheck();
    }

    public void HealthCheck()
    {
        if (currentHealth <= 0)
        {
            Instantiate(coin, transform.position, transform.rotation);
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if(playerHealth != null )
        {
            playerHealth.currHealth -= enemyDamage;
        }
    }

}
