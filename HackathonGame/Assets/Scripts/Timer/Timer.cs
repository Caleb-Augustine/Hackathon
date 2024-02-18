using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float timer;
    public TMP_Text lastUpdatedTimer;
    public PlayerHealth healthScript;
    void Start(){
        timer = 0f;
        healthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        RectTransform rectTransform = timerText.GetComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(1f, 1f);
        rectTransform.anchorMax = new Vector2(1f, 1f);
        rectTransform.anchoredPosition = new Vector2(-10f, -10f);
    }

    void Update(){
        timer += Time.deltaTime;
        if(healthScript.currHealth == 0){
               lastUpdatedTimer.text = string.Format("{0:00}:{1:00}", Mathf.Floor(timer / 60), timer % 60);
//             Display game over menu
        }
        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay(){
        string formattedTime = string.Format("{0:00}:{1:00}", Mathf.Floor(timer / 60), timer % 60);
        timerText.text = formattedTime;
    }
}