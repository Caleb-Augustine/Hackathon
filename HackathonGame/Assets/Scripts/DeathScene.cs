using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScene : MonoBehaviour
{
    public GameObject deathScene;
    public bool isPause;
    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
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
        Application.Quit();
    }
}
