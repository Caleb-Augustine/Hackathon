using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUpItems : MonoBehaviour
{
    public GameObject levelUpItems;
    public bool isPause = false;

    //Script Calls
    //Because these are set in script, they do not need to be public
    public PlayerHealth playerH;
    public PlayerMovement playerM;
    public PlayerBullets bulletB;
    public PlayerFire playerF;

    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
        playerH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        playerM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        bulletB = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBullets>();
        playerF = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerFire>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPause) {
            Debug.Log("hi");
            Time.timeScale = 0; 
            levelUpItems.SetActive(true);
        }
    }


    public void HealthButton() {
        float modPercent = 0.1f;
        float ratio = playerH.currHealth/playerH.playerHealth;
        playerH.playerHealth += (int) ((float) playerH.playerBaseHealth * modPercent);
        float playerHealth = playerH.playerHealth;
        int currHealth = (int) (ratio * playerHealth);
        playerH.currHealth = currHealth;
        resumeGame();
    }
    
    public void SpeedButton() {
        playerM.playerSpeed += 0.25f;
        resumeGame();
    }

    public void ShootDamageButton() {
        bulletB.bulletDamage += 2;
        resumeGame();
    }

    public void ShootSpeedButton() {
        playerF.bulletFireSpeed += 0.25f;
        resumeGame();
    }

    public void ShootLifeButton() {
        bulletB.bulletTimeAlive += 0.25f;
        resumeGame();
    }

    public void ShootRateButton() {
        playerF.bulletFireTime += 0.25f;
        resumeGame();
    }

    public void resumeGame() {
        levelUpItems.SetActive(false);
        isPause = false;
        Time.timeScale = 1.0f;
    }
}
