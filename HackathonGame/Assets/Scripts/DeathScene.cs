using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScene : MonoBehaviour
{
    public GameObject deathScene;
    public bool isPause;
    //player health
    public PlayerHealth playerH;
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
        bulletB = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBullets>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPause) {
            Time.timeScale = 0; 
            deathScene.SetActive(true);
        }
    }

    public void MainMenuButton() {
        // go to title screen
        deathScene.SetActive(false);
    }

    public void QuitButton() {
        deathScene.SetActive(false);
        Application.Quit();
    }
}
