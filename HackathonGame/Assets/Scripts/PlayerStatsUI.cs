using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatsUI : MonoBehaviour
{

    public TMP_Text playerStatsText;

    //Script Calls
    PlayerHealth ph;
    PlayerMovement pm;
    PlayerFire pf;
    PlayerBullets pb;


    // Start is called before the first frame update
    void Start()
    {
        ph = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        pf = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerFire>();
        pb = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBullets>(); 
    }

    // Update is called once per frame
    void Update()
    {
        playerStatsText.text = ("Player Stats:\r\n\r\nHealth: " + ph.playerHealth +"\r\n\r\nSpeed: " + pm.playerSpeed +"\r\n\r\nBullet Damage: "+ pb.bulletDamage +"\r\n\r\nBullet Speed: "+ pf.bulletFireSpeed +"\r\n\r\nBullet Life: " + pb.bulletTimeAlive );
    }
}
