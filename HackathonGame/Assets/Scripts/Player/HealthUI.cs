using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    public TMP_Text healthText;
    public Image healthBar;

    public PlayerHealth healthScript;

    // Start is called before the first frame update
    void Start()
    {

        healthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        // sets health UI
        healthText.text = "0 / 10";
        healthBar.fillAmount = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {

        // Update Health UI
        healthText.text = (int)(healthScript.currHealth) + " / " + (int)(healthScript.playerHealth);
        healthBar.fillAmount = ((float)healthScript.currHealth / (float)healthScript.playerHealth);
    }
}
