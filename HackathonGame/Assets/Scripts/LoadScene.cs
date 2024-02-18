using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpitionMenu()
    {
        //Do Pause Menu Here;
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
