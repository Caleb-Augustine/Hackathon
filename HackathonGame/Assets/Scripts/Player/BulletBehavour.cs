using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavour : MonoBehaviour
{
    public string targetTag;

    public int bulletDamage;
    public float bulletTimeAlive;
    float currentTime;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = bulletTimeAlive;
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
        if (col.gameObject.CompareTag(targetTag))
        {
            int enemyHealth = col.transform.gameObject.GetComponent<EnemyBase>().currentHealth;
            enemyHealth -= bulletDamage;
        }
    }




}