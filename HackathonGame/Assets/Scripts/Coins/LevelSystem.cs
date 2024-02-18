using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{

    public int playerLevel;
    public float currLevelProgress;
    public float currLevelMax = 10f;
    public float exponentValue;
    public EnemySpawn enemyScript;
    public TMP_Text levelText;
    public TMP_Text experienceText;
    public Image experienceBar;
    public LevelUpItems levelUpItems;
    public DeathScene deathScene;
    public EnemyScriptable enemyS;

    // Start is called before the first frame update
    void Start()
    {
        playerLevel = 1;
        currLevelProgress = 0;

        levelUpItems = GameObject.FindGameObjectWithTag("LevelUpItems").GetComponent<LevelUpItems>();
        enemyS = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScriptable>();


        // how much XP until next level
        currLevelMax = 10f;
        exponentValue = 0.4f;      

        // sets experience UI
        levelText.text = "Level : " + playerLevel.ToString();
        experienceText.text = "0 / 10";
        experienceBar.fillAmount = 0f;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //To delete soon
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currLevelProgress += 2;
        }

        //Level up
        if (currLevelProgress >= currLevelMax)
        {
            currLevelProgress -= currLevelMax;
            playerLevel++;
            currLevelMax = ((0.3f*currLevelMax) + currLevelMax);

            //Enemies spawn faster each level up
            if (enemyScript.spawnDelay > 1f)
            {
                enemyScript.spawnDelay -= 1f;
            }
            
            levelUpItems.isPause = true;
            deathScene.isPause = true
            increaseEnemy();
        }

        // Update Experience UI
        experienceText.text = (int)(currLevelProgress) + " / " + (int)(currLevelMax);
        experienceBar.fillAmount = (currLevelProgress / currLevelMax);
        levelText.text = "Level : " + playerLevel.ToString();

    }

    public void increaseEnemy() {
        enemyS.enemyHealth += 5;
        enemyS.enemyDamage += 3;
        enemyS.coinDropAmount += 1;
    }
}
