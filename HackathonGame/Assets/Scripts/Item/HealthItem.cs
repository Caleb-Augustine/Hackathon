using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{

    [Tooltip("This is the percent that is added to health. This is a float.")]
    public float modPercent = 0.1f;
    public PlayerHealth playerH;
    // Start is called before the first frame update
    void Start()
    {
        float ratio = playerH.currHealth/playerH.playerHealth;
        playerH.playerHealth += (int) ((float) playerH.playerBaseHealth * modPercent);
        float playerHealth = playerH.playerHealth;
        int currHealth = (int) (ratio * playerHealth);
        playerH.currHealth = currHealth;
        /*
        Random randy = new Random();
        randy %= 3;
        switch (randy) {
            case 0:
                modPercent = 0.1;
                break;
            case 1:
                modPercent = 0.15;
                break;
            case 2:
                modPercent = 0.25;
                break;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
