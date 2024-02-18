using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavour : PlayerBullets
{
    public string targetTag;
    float currentTime;
    public EnemyBase enemyScript;



    // Start is called before the first frame update
    void Start()
    {
        currentTime = bulletTimeAlive;
        enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyBase>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            Destroy(gameObject, 1f);
        }
    }



    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit Target Tag");
            enemyScript.currentHealth -= bulletDamage;
        }
    }




}
