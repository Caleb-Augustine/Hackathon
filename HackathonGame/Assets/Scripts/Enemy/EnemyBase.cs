using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public EnemyScriptable enemyType;

    public int currentHealth;
    public GameObject coin;
    public int enemyDamage;

    // Start is called before the first frame update
    void Start()
    {
        enemyType = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScriptable>();
        currentHealth = enemyType.enemyHealth;
        enemyDamage = 1;
        //currentHealth = 1;
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
    
}
