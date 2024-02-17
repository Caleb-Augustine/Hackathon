using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUpItems : MonoBehaviour
{
    public PlayerHealth playerH;
    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale = 0; 
       playerH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void HealthButton() {
        float modPercent = 0.1f;
        float ratio = playerH.currHealth/playerH.playerHealth;
        playerH.playerHealth += (int) ((float) playerH.playerBaseHealth * modPercent);
        float playerHealth = playerH.playerHealth;
        int currHealth = (int) (ratio * playerHealth);
        playerH.currHealth = currHealth;
    }
    
    public void SpeedButton() {

    }

    public void ShootDamageButton() {

    }

    public void ShootSpeedButton() {

    }

    public void ShootTimeButton() {

    }
}
