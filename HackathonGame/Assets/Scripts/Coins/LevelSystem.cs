using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{

    public int playerLevel;
    public float currLevelProgress;
    public float currLevelMax;
    public float exponentValue;
    public EnemySpawn enemyScript;
    public TMP_Text LevelText;
    public TMP_Text ExperienceText;
    public Image ExperienceBar;
    

    // Start is called before the first frame update
    void Start()
    {
        playerLevel = 1;
        currLevelProgress = 0;

        // how much XP until next level
        currLevelMax = 10f;
        exponentValue = 0.2f;      

        LevelText.text = "Level : " + playerLevel.ToString();
        ExperienceText.text = "0 / 10";
        ExperienceBar.fillAmount = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currLevelProgress += 2;
        }

        //Level up
        if (currLevelProgress >= currLevelMax)
        {
            currLevelProgress -= currLevelMax;
            playerLevel++;
            currLevelMax = (Mathf.Pow(currLevelMax, exponentValue) + currLevelMax);

            //Enemies spawn faster each level up
            if (enemyScript.spawnDelay > 0.5f)
            {
                enemyScript.spawnDelay -= 0.5f;
            }
            

        }

        // Update Experience UI
        ExperienceText.text = (int)(currLevelProgress) + " / " + (int)(currLevelMax);
        ExperienceBar.fillAmount = (currLevelProgress / currLevelMax);
        LevelText.text = "Level : " + playerLevel.ToString();
    }
}
