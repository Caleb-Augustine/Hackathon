using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public EnemyScriptable enemyType;

    public int currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = enemyType.enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void HealthCheck()
    {
        if (currentHealth <= 0)
        {
            //Spawn Coin function here.
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 1f);
        }
    }
}
