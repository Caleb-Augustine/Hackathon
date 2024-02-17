using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public float bulletFireSpeed;

    public float bulletFireTime;
    public float currentTime;



    // Start is called before the first frame update
    void Start()
    {
        currentTime = bulletFireTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime -= Time.deltaTime;
        if(currentTime <= 0 )
        {
            var bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(-bullet.transform.up * bulletFireSpeed * Time.deltaTime);
            currentTime = bulletFireTime;
        }

    }
}
