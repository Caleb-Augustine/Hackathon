using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DeathScene : MonoBehaviour
{
    public GameObject deathScene;
    public bool isPause;
    //level
    public LevelSystem levelS;
    //public TMP_Text levelText;
    //player health
    public PlayerHealth playerH;
    public TMP_Text healthText;
    public Timer timer;
    //player movement ???
    public PlayerMovement playerM;
    //bulletFireSpeed bulletFireTime
    public PlayerFire playerF;
    //bulletDamage bulletTimeAlive
    public PlayerBullets playerB;

    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
        playerH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        playerM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerF = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerFire>();
        playerB = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBullets>();
        levelS = GameObject.FindGameObjectWithTag("GameManager").GetComponent<LevelSystem>();
        timer = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPause) {
            Time.timeScale = 0; 
            deathScene.SetActive(true);
            showValues();
        }
    }

    public void showValues() {
        //levelText.text = "Level: " + levelS.playerLevel.ToString();
        //healthText.text = ("Level: " + levelS.playerLevel + "Max Health: " + playerH.playerHealth.ToString());
        healthText.text = ("Level: " + levelS.playerLevel + "\nTime: " + timer.timer + "\nPlayer Stats:\n\tHealth: " + playerH.playerHealth +"\n\tSpeed: " + playerM.playerSpeed +"\n\tBullet Damage: "+ playerB.bulletDamage +"\n\tBullet Speed: "+ playerF.bulletFireSpeed +"\n\tBullet Life: " + playerB.bulletTimeAlive );
 
    }

    public void MainMenuButton() {
        // go to title screen
        deathScene.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void QuitButton() {
        deathScene.SetActive(false);
        Application.Quit();
        Debug.Log("quit");
    }
}
