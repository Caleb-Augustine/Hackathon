using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{

    public int playerLevel;
    public float currLevelProgress;
    public float currLevelMax;
    public float exponentValue;
    

    // Start is called before the first frame update
    void Start()
    {
        playerLevel = 1;
        currLevelProgress = 0;

        // how much XP until next level
        currLevelMax = 10f;
        exponentValue = 0.2f;      


        
    }

    // Update is called once per frame
    void Update()
    {


        if (currLevelProgress >= currLevelMax)
        {
            playerLevel++;
            currLevelProgress -= currLevelMax;

            currLevelMax = (Mathf.Pow(currLevelMax, exponentValue) + currLevelMax);
        }
        
    }
}
