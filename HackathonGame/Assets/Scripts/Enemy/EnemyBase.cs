using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public EnemyScriptable enemyType;

    public int currentHealth;

    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = enemyType.enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthCheck();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentHealth = 0;
        }
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
